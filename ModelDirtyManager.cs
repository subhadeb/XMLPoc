using System.Configuration;
using System.Web;
using Ky.Hbe.WorkerPortal.Infrastructure.Attributes;
using Ky.Hbe.WorkerPortal.Infrastructure.Extensions;
using Ky.Hbe.WorkerPortal.Infrastructure.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using Ky.Hbe.WorkerPortal.WPConstants;
using System.Web.Mvc;
using Ky.Hbe.WorkerPortal.Utilities;
using Ky.Hbe.WorkerPortal.CommonUtilities;

namespace Ky.Hbe.WorkerPortal.Infrastructure.Utilities
{
    public static class ModelDirtyManager
    {
        public static bool IsProcessing { get; set; }

        public const bool IsModelDirtyManagerEnabled = true;

        public static void TakeInitialSnapshot(string key, object value,System.Web.Mvc.ControllerContext controllerContext)
        {
            try
            {
                if (!IsModelDirtyManagerEnabled)
                {
                    return; //no need to capture
                }
                IsProcessing = true;
                var dtStart = DateTime.Now;
                ISessionContainer sessionContainer = DependencyResolver.Current.GetService<ISessionContainer>();
                if (string.IsNullOrEmpty(key))
                {
                    throw new Exception("key cannot be empty.");
                }
                var clonedObject = ObjectExtensions.DeepCopy(value);
                if (controllerContext != null)
                {
                    if (key.IndexOf('|') >= 0 && key.Split('|').LastOrDefault() == ConstantValues.IsPopUp)
                    {
                        controllerContext.Controller.TempData[sessionContainer.GetModifiedKey(key.Split('|').FirstOrDefault())] = clonedObject;
                    }
                    else {
                        controllerContext.Controller.TempData[sessionContainer.GetModifiedKey(SessionKeys.DataMergeSessionKey)]=clonedObject;
                    }
                }
                var runTime = DateTime.Now.Subtract(dtStart);
                Debug.WriteLine("SaveInitialSnapshot took time: " + runTime.TotalMilliseconds + " ms");
            }
            finally
            {
                IsProcessing = false;
            }
        }

        public static object GetInitialSnapshot(string key,System.Web.Mvc.ControllerContext controllerContext)
        {
            ISessionContainer sessionContainer = DependencyResolver.Current.GetService<ISessionContainer>();
            return controllerContext.Controller.TempData.Peek(sessionContainer.GetModifiedKey(key));
        }
        public static void FilterDirtyModels(string key, object newValueToFilter,System.Web.Mvc.ControllerContext controllerContext)
        {
            try
            {
                if (!IsModelDirtyManagerEnabled)
                {
                    return; //no need to filter
                }
                ISessionContainer sessionContainer = DependencyResolver.Current.GetService<ISessionContainer>();
                IsProcessing = true;
                var dtStart = DateTime.Now;
                if (controllerContext != null)
                {
                    string tempDatKey;
                    if (key.IndexOf('|') >= 0 && key.Split('|').LastOrDefault() == ConstantValues.IsPopUp)
                    {
                        tempDatKey = sessionContainer.GetModifiedKey(key.Split('|').FirstOrDefault());
                    }
                    else
                    {
                        tempDatKey = sessionContainer.GetModifiedKey(SessionKeys.DataMergeSessionKey);
                    }
                    if (controllerContext.Controller.TempData[tempDatKey] == null)
                    {
                        // Fix for DHSOHA Errors 
                        return;
                    }
                    var originalValue = controllerContext.Controller.TempData[tempDatKey];
                    if (newValueToFilter == null || originalValue == null)
                    {
                        return;
                    }
                    if (originalValue.GetType() != newValueToFilter.GetType())
                    {
                        throw new Exception("Original and new values are not of the same type.");
                    }
                    CompareAndFilter(newValueToFilter, originalValue);
                    var runTime = DateTime.Now.Subtract(dtStart);
                    Debug.WriteLine("FilterDirtyModels took time: " + runTime.TotalMilliseconds + " ms");
                }
            }
            finally
            {
                IsProcessing = false;
            }
        }

        private static void CompareAndFilter(object newValueToFilter, object originalValue)
        {
            if (originalValue == null && newValueToFilter == null)
            {
                return;
            }
            if (originalValue is IList || newValueToFilter is IList)
            {
                FilterDirtyModels(newValueToFilter as IList, originalValue as IList);
            }
            else
            {
                AreObjectsDifferent(newValueToFilter, originalValue);
            }
        }

        private static void FilterDirtyModels(IList newList, IList originalList, Type propertyType = null, bool retainListIfAnyChildDirty = false)
        {
            if (newList == null || originalList == null) //can't filter
            {
                return;
            }

            var objectsToRemove = new List<object>();
            const bool isListBasicType = false;
            if (propertyType != null && !IsTypeCustomClassType(propertyType.GetGenericArguments().First()))
            {
                    //retain the entire list if the List is of basic data types
                    if (originalList.Count == newList.Count)
                    {
                        // Check if All data is Same
                        var isDifferent = newList.Cast<object>().Any(item => !originalList.Contains(item));

                        // if nothing is different Clear list
                        if (!isDifferent)
                        {
                            newList.Clear();
                        }
                    }
                    return;
            }

            var i = -1;
            var newItemsInNewList = 0;
            foreach (var newItem in newList)
            {
                bool isDifferent = false;
                i++;
                var modelKeys = GetModelKeys(newItem);
                var keyValues = GetValuesOfKeysFromModel(newItem, modelKeys);
                object matchingOriginalObject = null;
                if (modelKeys != null)
                {
                    matchingOriginalObject = FindMatchingObjectByItemKeys(originalList, modelKeys, keyValues);
                }

                if (matchingOriginalObject == null)
                {
                    newItemsInNewList++;
                    //missing object in new list, what to do???
                    //ignore, treat as removed explicitely
                    continue;
                }
                if (!isListBasicType)
                {
                    isDifferent = AreObjectsDifferent(newItem, matchingOriginalObject);
                }

                if (!isDifferent)
                {
                    objectsToRemove.Add(newItem);
                }
            }

            if (!retainListIfAnyChildDirty || (retainListIfAnyChildDirty && objectsToRemove.Count == originalList.Count && newItemsInNewList == 0))
            {
                foreach (var objectToRemove in objectsToRemove)
                {
                    newList.Remove(objectToRemove);
                }
            }
        }

        private static List<object> GetValuesOfKeysFromModel(object modelInstance, List<string> modelKeys)
        {
            if (modelKeys == null)
                return null;
            List<object> objectKeys = new List<object>();
            foreach (var modelKey in modelKeys)
            {
                var propInfo = modelInstance.GetType().GetProperty(modelKey);
                var modelKeyValue = propInfo.GetValue(modelInstance, null);
                objectKeys.Add(modelKeyValue);
            }

            return objectKeys;
        }

        private static List<string> GetModelPropertiesToIgnore(object modelInstance)
        {
            List<string> modelProperties = new List<string>();

            if (modelInstance == null)
                return null;

            var listProp = modelInstance.GetType().GetProperties();
            foreach (var propertyInfo in listProp)
            {
                var modelIgnoreAttributes = propertyInfo.GetCustomAttributes(false).OfType<ModelDirtyIgnoreCompare>();
                foreach (var attribute in modelIgnoreAttributes)
                {
                    modelProperties.Add(propertyInfo.Name);
                }
            }

            return modelProperties;
        }

        private static List<string> GetModelKeys(object modelInstance)
        {
            var modelKeyOrder = new Dictionary<int, string>();

            if (modelInstance == null)
                return null;

            var listProp = modelInstance.GetType().GetProperties();
            foreach (var propertyInfo in listProp)
            {
                var modelKeyAttributes = propertyInfo.GetCustomAttributes(false).OfType<ModelKey>();
                foreach (var attribute in modelKeyAttributes)
                {
                    modelKeyOrder.Add(attribute.KeyIndex, propertyInfo.Name);
                }
            }

            var modelKeys = modelKeyOrder.OrderBy(x => x.Key).Select(x => x.Value).ToList();

            //fallback approach
            if (!modelKeys.Any())
            {
                //may be a proxy object, search keys using the server side ModelKeys property
                modelKeys = GetModelKeysFromModelKeyProperty(modelInstance);
            }

            return modelKeys;
        }

        private static List<string> GetModelKeysFromModelKeyProperty(object modelInstance)
        {
            List<string> modelKeys = null;

            if (modelInstance == null)
                return null;

            var prop = modelInstance.GetType().GetProperty("ModelKeys");
            if (prop != null)
            {
                object value = prop.GetValue(modelInstance, null);
                if (value != null)
                {
                    if (value is IEnumerable<string>)
                    {
                        modelKeys = ((IEnumerable<string>)value).ToList();
                    }
                    else if (value is string[])
                    {
                        modelKeys = ((string[])value).ToList();
                    }
                    else if (value is List<string>)
                    {
                        modelKeys = (List<string>)value;
                    }
                }
            }

            return modelKeys;
        }

        private static object FindMatchingObjectByItemKeys(IList listToSearchIn, List<string> modelKeys, List<object> keyValues)
        {
            foreach (var objectInList in listToSearchIn)
            {
                List<object> keyValuesFromMatchingobject = GetValuesOfKeysFromModel(objectInList, modelKeys);
                bool same = AreKeysSame(keyValuesFromMatchingobject, keyValues);
                if (same)
                {
                    return objectInList;
                }
            }

            return null;
        }

        private static bool AreKeysSame(List<object> keyValuesFromMatchingobject, List<object> keyValues)
        {
            bool areSame = true;
            for (int i = 0; i < keyValues.Count; i++)
            {
                var obj1Value = keyValuesFromMatchingobject[i];
                var obj2Value = keyValues[i];

                if (obj1Value is IComparable && obj2Value is IComparable)
                {
                    IComparable ic1 = (IComparable)obj1Value;
                    IComparable ic2 = (IComparable)obj2Value;
                    int returnValue = ic1.CompareTo(ic2);

                    if (returnValue != 0)
                    {
                        areSame = false;
                    }
                }
            }

            return areSame;
        }

        private static bool AreObjectsDifferent(object newObject, object originalObject)
        {
            var isDifferent = false;
            if ((newObject == null && originalObject == null))
            {
                return false;
            }
            if ((newObject == null && originalObject != null) || (newObject != null && originalObject == null))
            {
                return true;
            }
            if (newObject.GetType() != originalObject.GetType())
            {
                throw new ArgumentException("object1 and object2 are of different types.");
            }
            if (!IsTypeCustomClassType(newObject.GetType()) && !IsTypeCustomClassType(originalObject.GetType()))
            {
                return AreValuesDifferent(newObject, originalObject);
            }
            var properties = newObject.GetType().GetProperties().Where(p => p.CanWrite).ToList();
            var propertiesToIgnore = GetModelPropertiesToIgnore(newObject);
            foreach (var propertyInfo in properties)
            {
                if (!CanCompareProperty(propertyInfo))
                {
                    continue;
                }
                if (propertiesToIgnore != null && propertiesToIgnore.Contains(propertyInfo.Name))
                {
                    continue;
                }
                var newObjectValue = propertyInfo.GetValue(newObject, null);
                var originalObjectValue = propertyInfo.GetValue(originalObject, null);
                var attributes = propertyInfo.GetCustomAttributes(true);
                var retainListIfAnyChildDirty = attributes.Any(x => x is ModelDirtyRetainListIfAnyChildDirty);

                //if obj1/obj2 is a class type, do recursion?

                if (propertyInfo.PropertyType.IsGenericType)
                {
                    if (!propertyInfo.PropertyType.IsValueType)
                    {
                        if ((newObjectValue != null && originalObjectValue == null) || (newObjectValue == null && originalObjectValue != null))
                        {
                            isDifferent = true;
                        }
                        else if (newObjectValue is IEnumerable && originalObjectValue is IEnumerable)
                        {
                            IList originalValueList = null;
                            var originalObjectCollection = (IEnumerable)originalObjectValue;
                            try
                            {
                                originalValueList = Activator.CreateInstance(propertyInfo.PropertyType) as IList;
                            }
                            catch (Exception ex)
                            {
                                // Error handler
                                LogManager.Log(ex.Message);
                            }

                            if (originalValueList != null)
                            {
                                foreach (var item in originalObjectCollection)
                                {
                                    originalValueList.Add(item);
                                }
                            }

                            IList newValueList = null;
                            var newObjectCollection = (IEnumerable)newObjectValue;

                            try
                            {
                                newValueList = Activator.CreateInstance(propertyInfo.PropertyType) as IList;
                            }
                            catch (Exception ex)
                            {
                                //failed, ignore
                                LogManager.Log(ex.Message);
                            }

                            if (newValueList != null)
                            {
                                foreach (var item in newObjectCollection)
                                {
                                    newValueList.Add(item);
                                }
                            }

                            FilterDirtyModels(newValueList, originalValueList, propertyInfo.PropertyType, retainListIfAnyChildDirty);

                            if (newValueList != null && newValueList.Count > 0)
                            {
                                isDifferent = true; //there is something in the child list, retain this parent
                            }

                            //set the new list
                            if (newValueList == null)
                            {
                                propertyInfo.SetValue(newObject, null, null);
                            }
                            else
                            {
                                propertyInfo.SetValue(newObject, newValueList, null);
                            }
                        }
                    }
                    else
                    {
                        bool diff = AreValuesDifferent(newObjectValue, originalObjectValue);
                        if (diff)
                        {
                            Debug.WriteLine(newObject.GetType() + " - Property is different : " + propertyInfo.Name);
                            isDifferent = true;
                        }
                    }
                }
                else if (IsPropertyCustomClassType(propertyInfo))
                {
                    var isDifferentInternal = AreObjectsDifferent(newObjectValue, originalObjectValue);
                    if (!isDifferentInternal)
                    {
                        if (!(propertyInfo.PropertyType == typeof(ClientDatesModel)))
                        {
                            //nullify object
                            propertyInfo.SetValue(newObject, null, null);
                        }
                    }
                    else
                    {
                        isDifferent = true;
                    }
                }
                else
                {
                    bool diff = AreValuesDifferent(newObjectValue, originalObjectValue);
                    if (diff)
                    {
                        Debug.WriteLine(newObject.GetType() + " - Property is different : " + propertyInfo.Name);
                        isDifferent = true;
                    }
                }
            }

            return isDifferent;
        }

        private static bool CanCompareProperty(PropertyInfo propertyInfo)
        {
            if (propertyInfo.Name == "CreateUserId" ||
                     propertyInfo.Name == "CreateDate" ||
                     propertyInfo.Name == "UpdateUserId" ||
                     propertyInfo.Name == "UpdateDate" ||
                     propertyInfo.Name == "Action")
                return false;

            if (ObjectExtensions.IsDictionary(propertyInfo.PropertyType))
                return false;

            var typeActionInfo = ObjectExtensions.GetTypeActionInfo(propertyInfo.PropertyType);
            if (typeActionInfo != null && typeActionInfo.SkipForCompare)
            {
                    return false;
            }

            return true;
        }

        private static bool AreValuesDifferent(object obj1Value, object obj2Value)
        {
            bool isDifferent = false;

            //if the values are null then return false
            if ((obj1Value == null && obj2Value == null))
            {
                return false;
            }

            //if values are string, null and blank should not be treated as different - from UI point of view
            if (obj1Value is string && obj2Value is string && string.IsNullOrEmpty((string)obj1Value) && string.IsNullOrEmpty((string)obj2Value))
            {
                    return false;
            }

            //check for nullable columns
            if ((obj1Value == null && obj2Value != null))
            {
                if (obj2Value is string && string.IsNullOrEmpty((string)obj2Value))
                {
                    return false;
                }
                else
                {
                    isDifferent = true;
                }
            }
            else if ((obj1Value != null && obj2Value == null))
            {
                if (obj1Value is string && string.IsNullOrEmpty((string)obj1Value))
                {
                    return false;
                }
                else
                {
                    isDifferent = true;
                }
            }

            if (obj1Value is IComparable && obj2Value is IComparable)
            {
                IComparable ic1 = (IComparable)obj1Value;
                IComparable ic2 = (IComparable)obj2Value;
                int returnValue = ic1.CompareTo(ic2);

                if (returnValue != 0)
                {
                    isDifferent = true;
                }
            }

            return isDifferent;
        }

        public static bool IsPropertyCustomClassType(PropertyInfo p)
        {
            return IsTypeCustomClassType(p.PropertyType);
        }

        public static bool IsTypeCustomClassType(Type type)
        {
            bool isClass;

            if (type.IsValueType || type.IsPrimitive ||
                new Type[] {
                           typeof(String),
                           typeof(Decimal),
                           typeof(DateTime),
                           typeof(DateTimeOffset),
                           typeof(TimeSpan),
                           typeof(Guid)
                    }.Contains(type) || Convert.GetTypeCode(type) != TypeCode.Object)
            {
                isClass = false;
            }
            else
            {
                return true;
            }

            return isClass;
        }
    }
};
