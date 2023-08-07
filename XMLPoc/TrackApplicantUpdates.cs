using Ky.Hbe.WorkerPortal.SharedServices.Contracts.Models.SSPDC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XMLPoc
{
    public static class TrackApplicantUpdates
    {

        private static int propetyLevelCounter = -1000;
        private static string? prevIndivid = null;
        public static List<ObjectField> GetPropertyValues(object obj, string parentClass = "")
        {
            List<ObjectField> propList = new List<ObjectField>();
            List<APClassIdentier> aPClassIdentiers = GetDBData.FetchAPClassIdentiers();


            propetyLevelCounter--;
            var propertiesOfobj = obj.GetType().GetProperties();
            string? individualId = null;
            //Populate individualId/prevIndivid if the object has Individual Id.
            if (propertiesOfobj.Any(x => x.Name == "IndividualId"))
            {
                var individualIdObj = propertiesOfobj.FirstOrDefault(x => x.Name == "IndividualId");
                individualId = individualIdObj.GetValue(obj, null)?.ToString();
                prevIndivid = individualId;
            }
            //Populate individualId for Nested Clasess, comparison for WP screen can be done based on IndividualId and Identifier Id combination.
            if (individualId == null && obj.GetType().Name != null && !string.IsNullOrEmpty(parentClass)
               && parentClass.Contains(obj.GetType().Name) && parentClass.Contains("ApplicationIndividual."))
            {
                individualId = prevIndivid;
            }


            //ApplicationIndividual does not have IndividualId, Individual is populated from it's Child Node Individual class.
            if (individualId == null && obj.GetType().Name != null && !string.IsNullOrEmpty(parentClass)
                && obj.GetType().Name == "ApplicationIndividual" && parentClass == "ApplicationIndividual"
                && propertiesOfobj.Any(x => x.Name == "Individual"))
            {
                var individualObj = propertiesOfobj.FirstOrDefault(x => x.Name == "Individual").GetValue(obj, null);
                if (individualObj.GetType() != null && individualObj.GetType().GetProperties().Any(x => x.Name == "IndividualId"))
                {
                    var individualIdObj = individualObj.GetType().GetProperties().FirstOrDefault(x => x.Name == "IndividualId");
                    individualId = individualIdObj.GetValue(individualObj, null)?.ToString();
                    prevIndivid = individualId;
                }
            }
            //Populate the identifierId from the parentClass object.
            string identifierName = string.Empty;
            int identifierId = -1;
            if (aPClassIdentiers.Any(x => x.ParentClass == parentClass))
            {
                identifierName = aPClassIdentiers.FirstOrDefault(x => x.ParentClass == parentClass).IdentifierName;
                if (propertiesOfobj.Any(x => x.Name == identifierName))
                {
                    var identifierObj = propertiesOfobj.FirstOrDefault(x => x.Name == identifierName);
                    var identifierVal = identifierObj.GetValue(obj, null);
                    if (identifierVal != null && identifierVal.GetType().IsValueType)
                    {
                        identifierId = Convert.ToInt32(identifierVal);
                    }
                }
            }

            if (propetyLevelCounter == -1011)
            {
                var test = "debug";
            }
            if (propetyLevelCounter == -1145)
            {
                var test = "debug";
            }

            foreach (PropertyInfo pinfo in propertiesOfobj)
            {
                var value = pinfo.GetValue(obj, null);


                //Properties ending with Specified can be ignored as these are not used in Applicant Portal.
                if (pinfo.Name.EndsWith("Specified"))
                {
                    continue;
                }


                if (pinfo.PropertyType.IsArray)
                {
                    var arr = value as object[];
                    if (arr != null)
                    {
                        var arrayName = arr.GetType().Name;
                        for (var i = 0; i < arr.Length; i++)
                        {
                            var arrayElement = arr[i];
                            if (arrayElement != null && arrayElement.GetType().IsPrimitive)
                            {
                                propList.Add(new ObjectField()
                                {
                                    Name = pinfo.Name + i.ToString(),
                                    Value = arrayElement.ToString(),
                                    ParentClass = parentClass,
                                    PropertyLevel = propetyLevelCounter,
                                    IsArray = true,
                                    ArrayName = arrayName,
                                    ArraryIndex = i,
                                    IndividualId = individualId,
                                    IdentifierName = identifierName,
                                    IdentifierId = identifierId
                                });
                            }
                            else if (value != null & pinfo.PropertyType.IsValueType)
                            {
                                propList.Add(new ObjectField()
                                {
                                    Name = pinfo.Name,
                                    Value = value.ToString(),
                                    ParentClass = parentClass,
                                    PropertyLevel = propetyLevelCounter,
                                    IsArray = true,
                                    ArrayName = arrayName,
                                    ArraryIndex = i,
                                    IndividualId = individualId,
                                    IdentifierName = identifierName,
                                    IdentifierId = identifierId
                                });
                            }
                            else if (arrayElement != null && arrayElement.GetType() == typeof(string))
                            {
                                propList.Add(new ObjectField()
                                {
                                    Name = pinfo.Name,
                                    Value = arrayElement.ToString(),
                                    ParentClass = parentClass,
                                    PropertyLevel = propetyLevelCounter,
                                    IsArray = true,
                                    ArrayName = arrayName,
                                    ArraryIndex = i,
                                    IndividualId = individualId,
                                    IdentifierName = identifierName,
                                    IdentifierId = identifierId
                                });
                            }

                            else if (arrayElement != null && arrayElement.GetType().IsClass)
                            {
                                var parentClassName = !string.IsNullOrEmpty(parentClass) ? parentClass + "." + arrayElement.GetType().Name
                                    : arrayElement.GetType().Name;
                                var lst = GetPropertyValues(arrayElement, parentClassName);
                                if (lst != null && lst.Count > 0)
                                {
                                    propList.AddRange(lst);
                                }

                            }
                        }
                    }

                }
                else
                {
                    if (pinfo.PropertyType.IsPrimitive || (value != null && value.GetType() == typeof(string)))
                    {
                        propList.Add(new ObjectField()
                        {
                            Name = pinfo.Name,
                            Value = value.ToString(),
                            ParentClass = parentClass,
                            PropertyLevel = propetyLevelCounter,
                            IndividualId = individualId,
                            IdentifierName = identifierName,
                            IdentifierId = identifierId
                        });
                    }
                    else if (value != null & pinfo.PropertyType.IsValueType)
                    {
                        propList.Add(new ObjectField()
                        {
                            Name = pinfo.Name,
                            Value = value.ToString(),
                            ParentClass = parentClass,
                            PropertyLevel = propetyLevelCounter,
                            IndividualId = individualId,
                            IdentifierName = identifierName,
                            IdentifierId = identifierId
                        });
                    }
                    else if (value != null && value.GetType().IsClass)
                    {
                        var parentClassName = !string.IsNullOrEmpty(parentClass) ? parentClass + "." + value.GetType().Name
                                    : value.GetType().Name;
                        var lst = GetPropertyValues(value, parentClassName);
                        if (lst != null && lst.Count > 0)
                        {
                            propList.AddRange(lst);
                        }
                    }
                }
            }
            return propList;
        }
        public static List<ReportedFieldValues> GetChanges(List<ObjectField> originalXMLValues, List<ObjectField> newXMLValues)
        {
            List<ReportedFieldValues> variances = new List<ReportedFieldValues>();


            //#1 ParentClass is blank. 
            var caseLevelFieldsOrig = originalXMLValues.Where(x => string.IsNullOrEmpty(x.ParentClass)).ToList();
            var caseLevelFieldsNew = newXMLValues.Where(x => string.IsNullOrEmpty(x.ParentClass)).ToList();


            foreach (var obj1 in caseLevelFieldsOrig)
            {
                foreach (var obj2 in caseLevelFieldsNew)
                {
                    if (obj1.Name == obj2.Name && obj1.ParentClass == obj2.ParentClass
                        && obj1.Value != obj2.Value)
                    {
                        variances.Add(new ReportedFieldValues()
                        {
                            Field = obj1.Name,
                            oldValues = obj1.Value,
                            NewValue = obj2.Value,
                            ParentClass = obj1.ParentClass,
                        });
                    }
                }
            }


            //#2 Identifier is Individual
            var individualLevelFieldsOrig = originalXMLValues.Where(x => x.IdentifierName == "IndividualId" && x.IndividualId != null).ToList();
            var individualLevelFieldsNew = newXMLValues.Where(x => x.IdentifierName == "IndividualId" && x.IndividualId != null).ToList();


            foreach (var obj1 in individualLevelFieldsOrig)
            {
                foreach (var obj2 in individualLevelFieldsNew)
                {
                    if (obj1.Name == obj2.Name && obj1.ParentClass == obj2.ParentClass
                        && obj1.IndividualId == obj2.IndividualId 
                        && obj1.Value != obj2.Value)
                    {
                        variances.Add(new ReportedFieldValues()
                        {
                            Field = obj1.Name,
                            oldValues = obj1.Value,
                            NewValue = obj2.Value,
                            ParentClass = obj1.ParentClass,
                        });
                    }
                }
            }



            foreach (var obj1 in originalXMLValues)
            {
                foreach (var obj2 in newXMLValues)
                {
                    if (obj1.Name == obj2.Name && obj1.ParentClass == obj2.ParentClass
                            && obj1.IndividualId == obj2.IndividualId
                             && !string.IsNullOrEmpty(obj1.IdentifierName)
                             && obj1.IdentifierName == obj2.IdentifierName)
                    {
                        if (obj1.Value != obj2.Value)
                        {
                            variances.Add(new ReportedFieldValues()
                            {
                                Field = obj1.Name,
                                oldValues = obj1.Value,
                                NewValue = obj2.Value,
                                ParentClass = obj1.ParentClass,
                            });
                        }
                    }
                }
            }
            return variances;
        }
    }


    public class ObjectField
    {
        public string Name { get; set; }
        public string Value { get; set; }
        public string ParentClass { get; set; }

        public int PropertyLevel { get; set; }
        public bool IsArray { get; set; }
        public string ArrayName { get; set; }
        public int ArraryIndex { get; set; }
        public string IndividualId { get; set; }
        public string IdentifierName { get; set; }
        public int IdentifierId { get; set; }
    }

    public class ReportedFieldValues
    {
        public string ReportedDate { get; set; }
        public string Name { get; set; }
        public string Field { get; set; }
        public string oldValues { get; set; }
        public string NewValue { get; set; }

        public string ParentClass { get; set; }

    }

}


