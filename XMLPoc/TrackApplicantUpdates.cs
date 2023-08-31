using Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

/*
 SDEB:
1
List<APClassIdentier> aPClassIdentiers = GetDBData.FetchAPClassIdentiers();
2
var fullName = string.Join(" ", preferredfirstName, preferredSuffix, preferredLastName);


 
 */


namespace XMLPoc
{
    public class TrackApplicantUpdates
    {

        private static int propetyLevelCounter = -1000;
        private static Dictionary<string, int> propertyDictionary = new Dictionary<string, int>();
        private static string prevIndivid = null;
        public static int itemId = 0;
        private static string prevParentClassWithSectionIdentifier = null;
        private static string prevSectionIdentifier = null;
        public List<ObjectField> GetPropertyValues(object obj, string parentClass = "")
        {
            List<ObjectField> propList = new List<ObjectField>();
            List<APClassIdentier> aPClassIdentiers = GetDBData.FetchAPClassIdentiers();


            propetyLevelCounter--;
            var propertiesOfobj = obj.GetType().GetProperties();
            string individualId = null;
            //Populate individualId/prevIndivid if the object has Individual Id.
            if (propertiesOfobj.Any(x => x.Name == "IndividualId"))
            {
                var individualIdObj = propertiesOfobj.FirstOrDefault(x => x.Name == "IndividualId");
                individualId = individualIdObj.GetValue(obj, null)?.ToString();
                if (!string.IsNullOrEmpty(individualId))
                {
                    prevIndivid = individualId;
                }
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
                    if (!string.IsNullOrEmpty(individualId))
                    {
                        prevIndivid = individualId;
                    }
                }
            }
            if (parentClass == "ApplicationIndividual.Resource.TrustDetails")
            {
                var test = "debug";
            }

            if (parentClass == "ApplicationIndividual.Resource.TrustDetails.ResourceTrustIndividual")
            {
                var test = "debug";
            }

            //Populate the identifierId from the parentClass object.
            string identifierName = string.Empty;
            string identifierId = string.Empty;
            string sectionIdentifier = string.Empty;
            if (aPClassIdentiers.Any(x => x.ClassName == parentClass))
            {
                var aPClassIdentierObj = aPClassIdentiers.FirstOrDefault(x => x.ClassName == parentClass);
                identifierName = aPClassIdentierObj.ClassIdentifier;

                if (!string.IsNullOrEmpty(identifierName) && !identifierName.ToUpper().StartsWith("CUSTOM_") && propertiesOfobj.Any(x => x.Name == identifierName))
                {

                    var identifierObj = propertiesOfobj.FirstOrDefault(x => x.Name == identifierName);
                    identifierId = identifierObj.GetValue(obj, null)?.ToString();

                }
                else if (identifierName.ToUpper().StartsWith("CUSTOM_") && identifierName.ToUpper() == "CUSTOM_PARENTINDIDIVIDUALID"
                        && !string.IsNullOrEmpty(individualId))
                {
                    identifierId = individualId;
                }
                else if (identifierName.ToUpper().StartsWith("CUSTOM_COMBINE{"))
                {
                    var arrIdentifierCustomCombine = identifierName.Split(new char[] { '{', '}' }, StringSplitOptions.RemoveEmptyEntries);
                    if (arrIdentifierCustomCombine != null && arrIdentifierCustomCombine.Length == 2 && !string.IsNullOrEmpty(arrIdentifierCustomCombine[1]))
                    {
                        var combineItems = arrIdentifierCustomCombine[1].Split(',').ToList();
                        if (combineItems != null && combineItems.Any())
                        {
                            foreach (var field in combineItems)
                            {
                                if (propertiesOfobj.Any(x => x.Name == field))
                                {
                                    var identifierObj = propertiesOfobj.FirstOrDefault(x => x.Name == field);
                                    var val = identifierObj.GetValue(obj, null)?.ToString();

                                    //SDEB have to get details from RT/FieldName to make the display value.
                                    identifierId = identifierId + (string.IsNullOrEmpty(identifierId) ? "" : ",") + val;
                                }
                            }
                        }
                    }

                }


                var miscIdentifier = aPClassIdentierObj.MiscellaneousIdentifier;
                if (!string.IsNullOrEmpty(miscIdentifier))
                {
                    List<string> miscIdentifierList = miscIdentifier.Split(',').ToList();
                    if (miscIdentifierList != null && miscIdentifierList.Any())
                    {
                        foreach (var miscField in miscIdentifierList)
                        {
                            if (propertiesOfobj.Any(x => x.Name == miscField))
                            {
                                var identifierObj = propertiesOfobj.FirstOrDefault(x => x.Name == miscField);
                                var val = identifierObj.GetValue(obj, null)?.ToString();

                                //SDEB have to get details from RT/FieldName to make the display value.
                                sectionIdentifier = sectionIdentifier + (string.IsNullOrEmpty(sectionIdentifier) ? "" : ", ") + miscField + "-" + val;
                            }
                        }
                        if (!string.IsNullOrEmpty(sectionIdentifier))
                        {
                            prevParentClassWithSectionIdentifier = parentClass;
                            prevSectionIdentifier = sectionIdentifier;
                        }
                    }
                }
            }
            if (string.IsNullOrEmpty(sectionIdentifier) && !string.IsNullOrEmpty(prevSectionIdentifier)
                && !string.IsNullOrEmpty(prevParentClassWithSectionIdentifier) && parentClass.Contains(prevParentClassWithSectionIdentifier))
            {
                sectionIdentifier = prevSectionIdentifier;
            }

            if (identifierName == "EmploymentDetaild")
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
                itemId++;

                if (pinfo.PropertyType.IsArray)
                {
                    var arr = value as object[];
                    if (arr != null)
                    {
                        var arrayName = arr.GetType().Name;
                        for (var i = 0; i < arr.Length; i++)
                        {
                            var arrayElement = arr[i];
                            if (pinfo != null && !string.IsNullOrEmpty(pinfo.Name + i.ToString()))
                            {
                                var propKey = (!string.IsNullOrEmpty(parentClass) ? parentClass + "." : string.Empty) + pinfo.Name + i.ToString();
                                if (propertyDictionary.ContainsKey(propKey))
                                {
                                    propertyDictionary[propKey] = propertyDictionary[propKey] + 1;
                                }
                                else
                                {
                                    propertyDictionary.Add(propKey, 1);
                                }
                            }
                            if (arrayElement != null && arrayElement.GetType().IsPrimitive)
                            {
                                propList.Add(new ObjectField()
                                {
                                    Name = pinfo.Name + i.ToString(),
                                    Value = arrayElement.ToString(),
                                    ParentClass = parentClass,
                                    PropertyLevel = propetyLevelCounter,
                                    PropertySubLevel = propertyDictionary.ContainsKey((!string.IsNullOrEmpty(parentClass) ? parentClass + "." : string.Empty) + pinfo.Name) ?
                                    propertyDictionary[(!string.IsNullOrEmpty(parentClass) ? parentClass + "." : string.Empty) + pinfo.Name] :
                                    0,
                                    IsArray = true,
                                    ArrayName = arrayName,
                                    ArraryIndex = i,
                                    IndividualId = individualId,
                                    IdentifierName = identifierName,
                                    IdentifierId = identifierId,
                                    ItemId = itemId,
                                    SectionIdentifier = sectionIdentifier,
                                });
                            }
                            else if (value != null && pinfo.PropertyType.IsValueType)
                            {
                                propList.Add(new ObjectField()
                                {
                                    Name = pinfo.Name,
                                    Value = value.ToString(),
                                    ParentClass = parentClass,
                                    PropertyLevel = propetyLevelCounter,
                                    PropertySubLevel = propertyDictionary.ContainsKey((!string.IsNullOrEmpty(parentClass) ? parentClass + "." : string.Empty) + pinfo.Name) ?
                                        propertyDictionary[(!string.IsNullOrEmpty(parentClass) ? parentClass + "." : string.Empty) + pinfo.Name] :
                                        0,
                                    IsArray = true,
                                    ArrayName = arrayName,
                                    ArraryIndex = i,
                                    IndividualId = individualId,
                                    IdentifierName = identifierName,
                                    IdentifierId = identifierId,
                                    ItemId = itemId,
                                    SectionIdentifier = sectionIdentifier,
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
                                    PropertySubLevel = propertyDictionary.ContainsKey((!string.IsNullOrEmpty(parentClass) ? parentClass + "." : string.Empty) + pinfo.Name) ?
                                        propertyDictionary[(!string.IsNullOrEmpty(parentClass) ? parentClass + "." : string.Empty) + pinfo.Name] :
                                        0,
                                    IsArray = true,
                                    ArrayName = arrayName,
                                    ArraryIndex = i,
                                    IndividualId = individualId,
                                    IdentifierName = identifierName,
                                    IdentifierId = identifierId,
                                    ItemId = itemId,
                                    SectionIdentifier = sectionIdentifier,
                                });
                            }

                            else if (arrayElement != null && arrayElement.GetType().IsClass)
                            {
                                var parentClassName = !string.IsNullOrEmpty(parentClass) ? parentClass + "." + arrayElement.GetType().Name
                                    : arrayElement.GetType().Name;
                                propetyLevelCounter--;
                                var lst = GetPropertyValues(arrayElement, parentClassName);
                                propetyLevelCounter++;
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
                        if (pinfo != null && !string.IsNullOrEmpty(pinfo.Name))
                        {
                            var propKey = (!string.IsNullOrEmpty(parentClass) ? parentClass + "." : string.Empty) + pinfo.Name;
                            if (propertyDictionary.ContainsKey(propKey))
                            {
                                propertyDictionary[propKey] = propertyDictionary[propKey] + 1;

                            }
                            else
                            {
                                propertyDictionary.Add(propKey, 1);
                            }
                        }
                        propList.Add(new ObjectField()
                        {
                            Name = pinfo.Name,
                            Value = value.ToString(),
                            ParentClass = parentClass,
                            PropertyLevel = propetyLevelCounter,
                            PropertySubLevel = propertyDictionary.ContainsKey((!string.IsNullOrEmpty(parentClass) ? parentClass + "." : string.Empty) + pinfo.Name) ?
                                        propertyDictionary[(!string.IsNullOrEmpty(parentClass) ? parentClass + "." : string.Empty) + pinfo.Name] :
                                        0,

                            IndividualId = individualId,
                            IdentifierName = identifierName,
                            IdentifierId = identifierId,
                            ItemId = itemId,
                            SectionIdentifier = sectionIdentifier,
                        });
                    }
                    else if (value != null & pinfo.PropertyType.IsValueType)
                    {
                        if (pinfo != null && !string.IsNullOrEmpty(pinfo.Name))
                        {
                            var propKey = (!string.IsNullOrEmpty(parentClass) ? parentClass + "." : string.Empty) + pinfo.Name;
                            if (propertyDictionary.ContainsKey(propKey))
                            {
                                propertyDictionary[propKey] = propertyDictionary[propKey] + 1;

                            }
                            else
                            {
                                propertyDictionary.Add(propKey, 1);
                            }
                        }
                        propList.Add(new ObjectField()
                        {
                            Name = pinfo.Name,
                            Value = value.ToString(),
                            ParentClass = parentClass,
                            PropertyLevel = propetyLevelCounter,
                            PropertySubLevel = propertyDictionary.ContainsKey((!string.IsNullOrEmpty(parentClass) ? parentClass + "." : string.Empty) + pinfo.Name) ?
                                        propertyDictionary[(!string.IsNullOrEmpty(parentClass) ? parentClass + "." : string.Empty) + pinfo.Name] :
                                        0,
                            IndividualId = individualId,
                            IdentifierName = identifierName,
                            IdentifierId = identifierId,
                            ItemId = itemId,
                            SectionIdentifier = sectionIdentifier,
                        });
                    }
                    else if (value != null && value.GetType().IsClass)
                    {
                        var parentClassName = !string.IsNullOrEmpty(parentClass) ? parentClass + "." + value.GetType().Name
                                    : value.GetType().Name;
                        propetyLevelCounter--;
                        var lst = GetPropertyValues(value, parentClassName);
                        propetyLevelCounter++;
                        if (lst != null && lst.Count > 0)
                        {
                            propList.AddRange(lst);
                        }
                    }
                    else
                    {
                        if (pinfo != null && !string.IsNullOrEmpty(pinfo.Name))
                        {
                            var propKey = (!string.IsNullOrEmpty(parentClass) ? parentClass + "." : string.Empty) + pinfo.Name;
                            if (propertyDictionary.ContainsKey(propKey))
                            {
                                propertyDictionary[propKey] = propertyDictionary[propKey] + 1;
                            }
                            else
                            {
                                propertyDictionary.Add(propKey, 1);
                            }
                        }
                    }
                }
            }
            return propList;
        }
        static Dictionary<string, string> dicIndivNameNew = new Dictionary<string, string>();
        public VarianceResults GetChanges(List<ObjectField> originalXMLValues, List<ObjectField> newXMLValues)
        {
            VarianceResults varianceResults = new VarianceResults();
            List<ReportedFieldValues> variances = new List<ReportedFieldValues>();
            var IndividualIdsNew = newXMLValues.Where(x => x.ParentClass == "ApplicationIndividual.Individual").Select(x => x.IndividualId).Distinct().ToList();
            foreach (var indivId in IndividualIdsNew)
            {
                var indivProperties = newXMLValues.Where(x => x.ParentClass == "ApplicationIndividual.Individual" && x.IndividualId == indivId).ToList();
                if (indivProperties != null && indivProperties.Any())
                {
                    //Will call GetFormattedNameWithSuffix
                    var firstName = indivProperties.FirstOrDefault(x => x.Name == "FirstName")?.Value;
                    var MiddleInitial = indivProperties.FirstOrDefault(x => x.Name == "MiddleInitial")?.Value;
                    var LastName = indivProperties.FirstOrDefault(x => x.Name == "LastName")?.Value;
                    var Suffix = indivProperties.FirstOrDefault(x => x.Name == "SuffixCode")?.Value;



                    var preferredfirstName = indivProperties.FirstOrDefault(x => x.Name == "PreferredFirstName")?.Value;
                    var preferredMiddleInitial = indivProperties.FirstOrDefault(x => x.Name == "PreferredMiddleName")?.Value;
                    var preferredLastName = indivProperties.FirstOrDefault(x => x.Name == "PreferredLastName")?.Value;
                    var preferredSuffix = indivProperties.FirstOrDefault(x => x.Name == "PreferredSuffix")?.Value;
                    var fullName = string.Join(" ", preferredfirstName, preferredSuffix, preferredLastName);
                    if (!dicIndivNameNew.ContainsKey(indivId))
                    {
                        dicIndivNameNew.Add(indivId, fullName);
                    }
                }
            }

            //### ParentClass is blank. 
            var caseLevelFieldsNoParentOrig = originalXMLValues.Where(x => string.IsNullOrEmpty(x.ParentClass)).ToList();
            var caseLevelFieldsNoParentNew = newXMLValues.Where(x => string.IsNullOrEmpty(x.ParentClass)).ToList();
            List<int> comparedItemidsOrig = new List<int>();
            List<int> comparedItemidsNew = new List<int>();

            foreach (var objOrig in caseLevelFieldsNoParentOrig)
            {
                comparedItemidsOrig.Add(objOrig.ItemId);
                foreach (var objNew in caseLevelFieldsNoParentNew)
                {
                    if (!comparedItemidsNew.Contains(objNew.ItemId))
                    {
                        comparedItemidsNew.Add(objNew.ItemId);
                    }

                    if (objOrig.Name == objNew.Name && objOrig.ParentClass == objNew.ParentClass
                        && objOrig.Value != objNew.Value)
                    {
                        variances.Add(PopulateVarianceMixed(objOrig, objNew));
                    }
                }
            }

            //### ParentClass is not blank but IndividualId is blank, Identifiers are not blank. These will be case level data
            var addedItemIdNew = new List<int>();
            var caseLevelFieldsWithParentAndIdentifierOrig = originalXMLValues.Where(x => !string.IsNullOrEmpty(x.ParentClass)
            && string.IsNullOrEmpty(x.IndividualId) && !string.IsNullOrEmpty(x.IdentifierName) && !string.IsNullOrEmpty(x.IdentifierId)).ToList();
            var caseLevelFieldsWithParentAndIdentifierNew = newXMLValues.Where(x => !string.IsNullOrEmpty(x.ParentClass)
            && string.IsNullOrEmpty(x.IndividualId) && !string.IsNullOrEmpty(x.IdentifierName) && !string.IsNullOrEmpty(x.IdentifierId)).ToList();
            foreach (var objOrig in caseLevelFieldsWithParentAndIdentifierOrig)
            {
                comparedItemidsOrig.Add(objOrig.ItemId);
                foreach (var objNew in caseLevelFieldsWithParentAndIdentifierNew)
                {
                    if (!comparedItemidsNew.Contains(objNew.ItemId))
                    {
                        comparedItemidsNew.Add(objNew.ItemId);
                    }

                    if (objOrig.Name == objNew.Name && objOrig.ParentClass == objNew.ParentClass
                        && objOrig.IdentifierName == objNew.IdentifierName
                        && objOrig.IdentifierId == objNew.IdentifierId
                        && objOrig.Value != objNew.Value)
                    {
                        variances.Add(PopulateVarianceMixed(objOrig, objNew));
                    }
                    //If There is a new entry for this ParentClass/IdentifierName/IdentifierId combination
                    if (!caseLevelFieldsWithParentAndIdentifierOrig.Any(x => x.ParentClass == objNew.ParentClass && x.IdentifierName == objNew.IdentifierName
                    && x.IdentifierId == objNew.IdentifierId) && !addedItemIdNew.Contains(objNew.ItemId))
                    {
                        addedItemIdNew.Add(objNew.ItemId);
                        variances.Add(PopulateVarianceNew(objNew));
                    }
                }

            }



            //### ParentClass is not blank but IndividualId is blank. These will be case level data
            var caseLevelFieldsWithParentOrig = originalXMLValues.Where(x => !string.IsNullOrEmpty(x.ParentClass)
            && string.IsNullOrEmpty(x.IndividualId) && !comparedItemidsOrig.Contains(x.ItemId)).ToList();
            var caseLevelFieldsWithParentNew = newXMLValues.Where(x => !string.IsNullOrEmpty(x.ParentClass)
            && string.IsNullOrEmpty(x.IndividualId) && !comparedItemidsNew.Contains(x.ItemId)).ToList();

            foreach (var objOrig in caseLevelFieldsWithParentOrig)
            {
                comparedItemidsOrig.Add(objOrig.ItemId);
                foreach (var objNew in caseLevelFieldsWithParentNew)
                {
                    if (!comparedItemidsNew.Contains(objNew.ItemId))
                    {
                        comparedItemidsNew.Add(objNew.ItemId);
                    }

                    if (objOrig.Name == objNew.Name && objOrig.ParentClass == objNew.ParentClass
                        && objOrig.Value != objNew.Value)
                    {
                        variances.Add(PopulateVarianceMixed(objOrig, objNew));
                    }
                }
            }



            //### If Individual is Removed display as Removed and display Death Date if Any. Everything apart from this can be removed. 
            var removedIndividuals = newXMLValues.Where(x => x.Name == "deleteIndicator"
            && x.ParentClass == "ApplicationIndividual.Individual" && !string.IsNullOrEmpty(x.IndividualId) && !string.IsNullOrEmpty(x.Value)
            && x.Value.ToLower() == "true")
                .Select(x => x.IndividualId).ToList();

            if (removedIndividuals != null && removedIndividuals.Any())
            {
                foreach (var indiv in removedIndividuals)
                {
                    var individualFields = newXMLValues.Where(x => x.ParentClass == "ApplicationIndividual.Individual"
                    && x.IndividualId == indiv).ToList();
                    var origIndivDetails = originalXMLValues.Where(x => x.ParentClass == "ApplicationIndividual.Individual" && x.IndividualId == indiv).ToList();

                    //Will call GetFormattedNameWithSuffix

                    var firstName = origIndivDetails.FirstOrDefault(x => x.Name == "FirstName")?.Value;
                    var MiddleInitial = origIndivDetails.FirstOrDefault(x => x.Name == "MiddleInitial")?.Value;
                    var LastName = origIndivDetails.FirstOrDefault(x => x.Name == "LastName")?.Value;
                    var Suffix = origIndivDetails.FirstOrDefault(x => x.Name == "SuffixCode")?.Value;



                    var preferredfirstName = origIndivDetails.FirstOrDefault(x => x.Name == "PreferredFirstName")?.Value;
                    var preferredMiddleInitial = origIndivDetails.FirstOrDefault(x => x.Name == "PreferredMiddleName")?.Value;
                    var preferredLastName = origIndivDetails.FirstOrDefault(x => x.Name == "PreferredLastName")?.Value;
                    var preferredSuffix = origIndivDetails.FirstOrDefault(x => x.Name == "PreferredSuffix")?.Value;
                    //var fullName = GlobalFunctions.GetFormattedName(firstName, MiddleInitial, LastName, preferredfirstName, preferredMiddleInitial, preferredLastName);
                    var fullName = string.Join(" ", preferredfirstName, preferredSuffix, preferredLastName);
                    if (dicIndivNameNew.ContainsKey(indiv) && !string.IsNullOrEmpty(fullName))
                    {
                        dicIndivNameNew[indiv] = fullName;
                    }

                    ReportedFieldValues rfb = new ReportedFieldValues()
                    {
                        Field = "Removed",
                        oldValue = "N/A",
                        NewValue = "Removed",
                        ParentClass = "ApplicationIndividual.Individual",
                        SectionIdentifier = "",
                        Name = fullName,
                        PropertyLevel = 0,
                        ItemId = 0,
                        PropertySubLevel = 0
                    };
                    variances.Add(rfb);
                    //For Death Date:
                    var origDeathDate = originalXMLValues.FirstOrDefault(x =>
                      x.ParentClass == "ApplicationIndividual.Individual" && x.IndividualId == indiv
                     && x.Name == "DeathDate");
                    var newDeathDate = newXMLValues.FirstOrDefault(x =>
                     x.ParentClass == "ApplicationIndividual.Individual" && x.IndividualId == indiv
                     && x.Name == "DeathDate");
                    var isDeathDateNewOrUpdated = false;
                    if ((origDeathDate == null || (origDeathDate != null && string.IsNullOrEmpty(origDeathDate.Value)))
                        && (newDeathDate != null && !string.IsNullOrEmpty(newDeathDate.Value)))
                    {
                        isDeathDateNewOrUpdated = true;
                        variances.Add(PopulateVarianceNew(newDeathDate));
                    }
                    //No need of comparisons and displaying fields for removed individual
                    originalXMLValues.RemoveAll(x => x.IndividualId == indiv);
                    if (isDeathDateNewOrUpdated)
                    {
                        newXMLValues.RemoveAll(x => x.IndividualId == indiv && x.ItemId != newDeathDate.ItemId);
                        if (!comparedItemidsNew.Contains(newDeathDate.ItemId))
                        {
                            comparedItemidsNew.Add(newDeathDate.ItemId);
                        }
                    }
                    else
                    {
                        newXMLValues.RemoveAll(x => x.IndividualId == indiv);
                    }

                }
            }

            var deletedItemsNew = newXMLValues.Where(x => x.Name == "deleteIndicator" && !string.IsNullOrEmpty(x.Value)
            && x.Value.ToLower() == "true").ToList();
            if (deletedItemsNew != null && deletedItemsNew.Any())
            {
                foreach (var objNew in deletedItemsNew)
                {
                    var parentClass = objNew.ParentClass;
                    var identifierId = objNew.IdentifierId;
                    ReportedFieldValues rfb = new ReportedFieldValues()
                    {
                        Field = "Deleted",
                        oldValue = "N/A",
                        NewValue = "Deleted",
                        ParentClass = objNew.ParentClass,
                        SectionIdentifier = objNew.SectionIdentifier,
                        PropertyLevel = objNew.PropertyLevel,
                        ItemId = objNew.ItemId,
                        PropertySubLevel = objNew.PropertySubLevel
                    };
                    if (!string.IsNullOrEmpty(objNew.IndividualId) && dicIndivNameNew.ContainsKey(objNew.IndividualId))
                    {
                        rfb.Name = dicIndivNameNew[objNew.IndividualId];
                    }
                    variances.Add(rfb);

                    newXMLValues.RemoveAll(x => x.ParentClass == parentClass && x.IdentifierId == identifierId);
                    originalXMLValues.RemoveAll(x => x.ParentClass == parentClass && x.IdentifierId == identifierId);
                }
            }


            //### Identifier is Individual
            var individualLevelFieldsOrig = originalXMLValues.Where(x => x.IdentifierName == "IndividualId"
            && x.IndividualId != null && !comparedItemidsOrig.Contains(x.ItemId)).ToList();
            var individualLevelFieldsNew = newXMLValues.Where(x => x.IdentifierName == "IndividualId"
            && x.IndividualId != null && !comparedItemidsNew.Contains(x.ItemId)).ToList();
            addedItemIdNew = new List<int>();


            foreach (var objOrig in individualLevelFieldsOrig)
            {
                comparedItemidsOrig.Add(objOrig.ItemId);
                foreach (var objNew in individualLevelFieldsNew)
                {
                    if (!comparedItemidsNew.Contains(objNew.ItemId))
                    {
                        comparedItemidsNew.Add(objNew.ItemId);
                    }
                    if (objOrig.Name == objNew.Name && objOrig.ParentClass == objNew.ParentClass
                        && objOrig.IndividualId == objNew.IndividualId
                        && objOrig.Value != objNew.Value)
                    {
                        variances.Add(PopulateVarianceMixed(objOrig, objNew));
                    }
                    //If There is a new entry for this ParentClass/IdentifierName/IdentifierId combination
                    if (!individualLevelFieldsOrig.Any(x => x.ParentClass == objNew.ParentClass && x.IdentifierName == objNew.IdentifierName
                    && x.IdentifierId == objNew.IdentifierId && objNew.Name == x.Name) && !addedItemIdNew.Contains(objNew.ItemId))
                    {
                        addedItemIdNew.Add(objNew.ItemId);
                        variances.Add(PopulateVarianceNew(objNew));
                    }
                }
            }



            //### For New Individual All changes should be displayed.
            var newXMLIndividualId = newXMLValues.Where(x => originalXMLValues.All(y => y.IndividualId != x.IndividualId)).ToList();
            foreach (var objNew in newXMLIndividualId)
            {
                if (!comparedItemidsNew.Contains(objNew.ItemId))
                {
                    comparedItemidsNew.Add(objNew.ItemId);
                }
                if (!string.IsNullOrEmpty(objNew.Value))
                {
                    variances.Add(PopulateVarianceNew(objNew));
                }
            }
            //var deletedXMLIndividualId = originalXMLValues.Where(x => newXMLValues.All(y => y.IndividualId != x.IndividualId)).ToList();
            //foreach (var obj in newXMLIndividualId)
            //{
            //    variances.Add(new ReportedFieldValues()
            //    {
            //        Field = obj.Name,
            //        oldValues = obj.Value,
            //        NewValue = "N/A",
            //        ParentClass = obj.ParentClass,
            //    });
            //}





            //###. For All Non IndividualId Identifiers whose IdentifierId is not 0.
            var nonIndivIdentifiersFieldsUpdatedOrig = originalXMLValues.Where(x =>
            !string.IsNullOrEmpty(x.ParentClass) && !string.IsNullOrEmpty(x.IdentifierName) && x.IdentifierName != "IndividualId"
            && x.IndividualId != null && !string.IsNullOrEmpty(x.IdentifierId) && x.IdentifierId != "0" && !comparedItemidsOrig.Contains(x.ItemId)).ToList();
            var nonIndivIdentifiersFieldsUpdatedNew = newXMLValues.Where(x =>
            !string.IsNullOrEmpty(x.ParentClass) && !string.IsNullOrEmpty(x.IdentifierName) && x.IdentifierName != "IndividualId"
            && x.IndividualId != null && !string.IsNullOrEmpty(x.IdentifierId) && x.IdentifierId != "0" && !comparedItemidsNew.Contains(x.ItemId)).ToList();


            addedItemIdNew = new List<int>();//Resetting
            foreach (var objOrig in nonIndivIdentifiersFieldsUpdatedOrig)
            {
                comparedItemidsOrig.Add(objOrig.ItemId);

                foreach (var objNew in nonIndivIdentifiersFieldsUpdatedNew)
                {
                    if (!comparedItemidsNew.Contains(objNew.ItemId))
                    {
                        comparedItemidsNew.Add(objNew.ItemId);
                    }
                    if (objOrig.Name == objNew.Name && objOrig.ParentClass == objNew.ParentClass
                            && objOrig.IndividualId == objNew.IndividualId
                             && !string.IsNullOrEmpty(objOrig.IdentifierName)
                             && objOrig.IdentifierName == objNew.IdentifierName)
                    {
                        //If IdentifierId is same but value is different.
                        if (objOrig.IdentifierId == objNew.IdentifierId && objOrig.Value != objNew.Value)
                        {
                            variances.Add(PopulateVarianceMixed(objOrig, objNew));
                        }
                    }

                    //If There is a new entry for this Name/ParentClass/IdentifierName/IdentifierId combination

                    if (!nonIndivIdentifiersFieldsUpdatedOrig.Any(x => x.ParentClass == objNew.ParentClass && x.IdentifierName == objNew.IdentifierName
                    && x.IndividualId == objNew.IndividualId
                    && x.IdentifierId == objNew.IdentifierId && x.Name == objNew.Name) && !addedItemIdNew.Contains(objNew.ItemId))
                    {
                        addedItemIdNew.Add(objNew.ItemId);
                        variances.Add(PopulateVarianceNew(objNew));
                    }
                }
            }

            //###. For All Non IndividualId Identifiers whose IdentifierId is 0.
            var nonIndivIdentifiersFieldsAddedNew = newXMLValues.Where(x =>
            !string.IsNullOrEmpty(x.ParentClass) && !string.IsNullOrEmpty(x.IdentifierName) && x.IdentifierName != "IndividualId"
            && x.IndividualId != null && !string.IsNullOrEmpty(x.IdentifierId) && x.IdentifierId == "0"
            && !string.IsNullOrEmpty(x.Value) && !comparedItemidsNew.Contains(x.ItemId)).ToList();
            foreach (var objNew in nonIndivIdentifiersFieldsAddedNew)
            {
                if (!comparedItemidsNew.Contains(objNew.ItemId))
                {
                    comparedItemidsNew.Add(objNew.ItemId);
                }
                if (!string.IsNullOrEmpty(objNew.Value))
                {
                    variances.Add(PopulateVarianceNew(objNew));
                }

            }
            //### Remaining Fields  not yet covered should be considered as new.
            var newFieldsNotYetCovered = newXMLValues.Where(x => !comparedItemidsNew.Contains(x.ItemId)).ToList();
            foreach (var objNew in newFieldsNotYetCovered)
            {
                if (!comparedItemidsNew.Contains(objNew.ItemId))
                {
                    comparedItemidsNew.Add(objNew.ItemId);
                }
                if (!string.IsNullOrEmpty(objNew.Value))
                {
                    variances.Add(PopulateVarianceNew(objNew));
                }
            }


            varianceResults.variances = variances;
            varianceResults.individualNames = dicIndivNameNew;
            return varianceResults;
        }

        static ReportedFieldValues PopulateVarianceMixed(ObjectField objOrig, ObjectField objNew)
        {
            ReportedFieldValues rfb = new ReportedFieldValues()
            {
                Field = objOrig.Name,
                oldValue = objOrig.Value,
                NewValue = objNew.Value,
                ParentClass = objNew.ParentClass,
                SectionIdentifier = objNew.SectionIdentifier,
                PropertyLevel = objNew.PropertyLevel,
                ItemId = objNew.ItemId,
                PropertySubLevel = objNew.PropertySubLevel
            };
            if (!string.IsNullOrEmpty(objNew.IndividualId) && dicIndivNameNew.ContainsKey(objNew.IndividualId))
            {
                rfb.Name = dicIndivNameNew[objNew.IndividualId];
            }
            return rfb;
        }
        static ReportedFieldValues PopulateVarianceNew(ObjectField objNew)
        {
            ReportedFieldValues rfb = new ReportedFieldValues()
            {
                Field = objNew.Name,
                oldValue = "N/A",
                NewValue = objNew.Value,
                ParentClass = objNew.ParentClass,
                SectionIdentifier = objNew.SectionIdentifier,
                PropertyLevel = objNew.PropertyLevel,
                ItemId = objNew.ItemId,
                PropertySubLevel = objNew.PropertySubLevel
            };
            if (!string.IsNullOrEmpty(objNew.IndividualId) && dicIndivNameNew.ContainsKey(objNew.IndividualId))
            {
                rfb.Name = dicIndivNameNew[objNew.IndividualId];
            }
            return rfb;
        }

        public static List<ReportedFieldValues> UpdateVarinaces(List<ReportedFieldValues> list)
        {
            var fieldProperties = GetSectionDisplayFieldProperties();
            for (int i = 0; i < list.Count; i++)
            {
                var varianceItem = list[i];
                string newSectionIdentifier = "";
                if (!string.IsNullOrEmpty(varianceItem.SectionIdentifier))
                {
                    if (varianceItem.SectionIdentifier.Contains("UnearnedIncomeStartDate"))
                    { 
                    
                    }
                    foreach (var item in varianceItem.SectionIdentifier.Split(','))
                    {
                        var identifierNameDisplay = string.Empty;
                        var identifierValueDisplay = string.Empty;
                        var keyValue = item.Split('-');
                        if (keyValue != null && keyValue.Any() && keyValue.Length == 2)
                        {
                            var key = keyValue[0].Trim();
                            var val = keyValue[1].Trim();
                            if (fieldProperties.ContainsKey(key))
                            {
                                var dicItem = fieldProperties[key];
                                if (dicItem.ContainsKey("Display"))
                                {
                                    identifierNameDisplay = dicItem["Display"];
                                }
                                if (dicItem.ContainsKey("DataFormat"))
                                {
                                    if (dicItem["DataFormat"] == "Date" && !string.IsNullOrEmpty(val))
                                    {
                                        identifierValueDisplay = Convert.ToDateTime(val).ToString("MM/dd/yyyy");
                                    }

                                }
                                else if (dicItem.ContainsKey("RTName"))
                                {
                                    identifierValueDisplay = dicItem["RTName"];
                                }
                            }
                            if (!string.IsNullOrEmpty(identifierNameDisplay) && !string.IsNullOrEmpty(identifierValueDisplay))
                            {
                                newSectionIdentifier = newSectionIdentifier + (string.IsNullOrEmpty(newSectionIdentifier) ? "" : ", ") + identifierNameDisplay + "-" + identifierValueDisplay;
                            }
                            
                        }
                        
                    }

                }
                if (!string.IsNullOrEmpty(newSectionIdentifier))
                {
                    varianceItem.SectionIdentifier = newSectionIdentifier;
                }

            }

            return list;
        }
        public static Dictionary<string, Dictionary<string, string>> GetSectionDisplayFieldProperties()
        {


            Dictionary<string, Dictionary<string, string>> sectionDisplayFieldProperties = new Dictionary<string, Dictionary<string, string>>();
            var dicAnnuitizedDate = new Dictionary<string, string>();
            dicAnnuitizedDate.Add("Display", "Date Purchased");
            dicAnnuitizedDate.Add("DataFormat", "Date");
            sectionDisplayFieldProperties.Add("AnnuitizedDate", dicAnnuitizedDate);


            var dicExpenseTypeCode = new Dictionary<string, string>();
            dicExpenseTypeCode.Add("NoDisplay", "Yes");
            sectionDisplayFieldProperties.Add("ExpenseTypeCode", dicExpenseTypeCode);

            var dicHighestEducationLevelCode = new Dictionary<string, string>();
            dicHighestEducationLevelCode.Add("Display", "Highest Level of Education");
            dicHighestEducationLevelCode.Add("RTName", "HIGHESTLEVELEDU");
            sectionDisplayFieldProperties.Add("HighestEducationLevelCode", dicHighestEducationLevelCode);

            var dicIncarcerationBeginDate = new Dictionary<string, string>();
            dicIncarcerationBeginDate.Add("Display", "Incarceration Begin Date");
            dicIncarcerationBeginDate.Add("DataFormat", "Date");
            sectionDisplayFieldProperties.Add("IncarcerationBeginDate", dicIncarcerationBeginDate);

            var dicIncomeCategoryCode = new Dictionary<string, string>();
            dicIncomeCategoryCode.Add("Display", "Income Category");
            dicIncomeCategoryCode.Add("RTName", "INCOMECATEGORY");
            sectionDisplayFieldProperties.Add("IncomeCategoryCode", dicIncomeCategoryCode);

            var dicIncomeTypeCode = new Dictionary<string, string>();
            dicIncomeTypeCode.Add("Display", "Income Type");
            dicIncomeTypeCode.Add("RTName", "INCOMETYPESCODE");
            sectionDisplayFieldProperties.Add("IncomeTypeCode", dicIncomeTypeCode);

            var dicEmployerName = new Dictionary<string, string>();
            dicEmployerName.Add("Display", "Employer Name/Business Name");
            sectionDisplayFieldProperties.Add("EmployerName", dicEmployerName);

            var dicLaTypeCode = new Dictionary<string, string>();
            dicLaTypeCode.Add("Display", "Living Arrangement Type");
            dicLaTypeCode.Add("RTName", "LIVINGARRANGEMENTTYPE");
            sectionDisplayFieldProperties.Add("LaTypeCode", dicLaTypeCode);

            var dicTypeOfCoverageCode = new Dictionary<string, string>();
            dicTypeOfCoverageCode.Add("Display", "Type Of Coverage");
            dicTypeOfCoverageCode.Add("RTName", "TPRTYPEOFCOVERAGE");
            sectionDisplayFieldProperties.Add("TypeOfCoverageCode", dicTypeOfCoverageCode);

            var dicUnearnedIncomeTypeCode = new Dictionary<string, string>();
            dicUnearnedIncomeTypeCode.Add("Display", "Unearned Income Type");
            dicUnearnedIncomeTypeCode.Add("RTName", "INCOMETYPESCODE");
            sectionDisplayFieldProperties.Add("UnearnedIncomeTypeCode", dicUnearnedIncomeTypeCode);

            var dicUnearnedIncomeStartDate = new Dictionary<string, string>();
            dicUnearnedIncomeStartDate.Add("Display", "Start Date");
            dicUnearnedIncomeStartDate.Add("DataFormat", "Date");
            sectionDisplayFieldProperties.Add("UnearnedIncomeStartDate", dicUnearnedIncomeStartDate);


           

            return sectionDisplayFieldProperties;
        }

    }






    public class ObjectField
    {
        public string Name { get; set; }
        public string Value { get; set; }
        public string ParentClass { get; set; }
        public int ItemId { get; set; }

        public int PropertyLevel { get; set; }
        public int PropertySubLevel { get; set; }
        public bool IsArray { get; set; }
        public string ArrayName { get; set; }
        public int ArraryIndex { get; set; }
        public string IndividualId { get; set; }
        public string IdentifierName { get; set; }
        public string IdentifierId { get; set; }
        public string SectionIdentifier { get; set; }
        public DateTime ReportedDate { get; set; }
    }

    public class ReportedFieldValues
    {
        public string ReportedDate { get; set; }
        public string Name { get; set; }
        public string Field { get; set; }
        public string oldValue { get; set; }
        public string NewValue { get; set; }

        public string ParentClass { get; set; }
        public string SectionIdentifier { get; set; }
        public int ItemId { get; set; }
        public int PropertyLevel { get; set; }
        public int PropertySubLevel { get; set; }
    }
    public class VarianceResults
    {
        public VarianceResults()
        {
            variances = new List<ReportedFieldValues>();
            individualNames = new Dictionary<string, string>();
        }
        public List<ReportedFieldValues> variances { get; set; }
        public Dictionary<string, string> individualNames { get; set; }
    }

}


