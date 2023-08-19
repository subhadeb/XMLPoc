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
        public static int itemId = 0;
        private static string? prevParentClassWithSectionIdentifier = null;
        private static string? prevSectionIdentifier = null;
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
            if (aPClassIdentiers.Any(x => x.ParentClass == parentClass))
            {
                var aPClassIdentierObj = aPClassIdentiers.FirstOrDefault(x => x.ParentClass == parentClass);
                identifierName = aPClassIdentierObj.IdentifierName;

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


                var miscIdentifier = aPClassIdentierObj.MiscIdentifier;
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
                                    IdentifierId = identifierId,
                                    ItemId = itemId,
                                    SectionIdentifier = sectionIdentifier,
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
                            IdentifierId = identifierId,
                            ItemId = itemId,
                            SectionIdentifier = sectionIdentifier,
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
                            IdentifierId = identifierId,
                            ItemId = itemId,
                            SectionIdentifier = sectionIdentifier,
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
        static Dictionary<string, string> dicIndivNameNew = new Dictionary<string, string>();
        public static List<ReportedFieldValues> GetChanges(List<ObjectField> originalXMLValues, List<ObjectField> newXMLValues)
        {
            List<ReportedFieldValues> variances = new List<ReportedFieldValues>();
            var IndividualIdsNew = newXMLValues.Where(x => x.ParentClass == "ApplicationIndividual.Individual").Select(x => x.IndividualId).Distinct().ToList();
            foreach (var indivId in IndividualIdsNew)
            {
                var indivProperties = newXMLValues.Where(x => x.ParentClass == "ApplicationIndividual.Individual" && x.IndividualId == indivId).ToList();
                if (indivProperties != null && indivProperties.Any())
                {
                    //Will call GetFormattedNameWithSuffix
                    var preferredfirstName = indivProperties.FirstOrDefault(x => x.Name == "PreferredFirstName")?.Value;
                    var preferredSuffix = indivProperties.FirstOrDefault(x => x.Name == "PreferredSuffix")?.Value;
                    var preferredLastName = indivProperties.FirstOrDefault(x => x.Name == "PreferredLastName")?.Value;
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

            //### ParentClass is not blank but IndividualId is blank. These will be case level data
            var caseLevelFieldsWithParentOrig = originalXMLValues.Where(x => !string.IsNullOrEmpty(x.ParentClass)
            && string.IsNullOrEmpty(x.IndividualId)).ToList();
            var caseLevelFieldsWithParentNew = newXMLValues.Where(x => !string.IsNullOrEmpty(x.ParentClass)
            && string.IsNullOrEmpty(x.IndividualId)).ToList();

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
            && x.ParentClass == "ApplicationIndividual.Individual" && !string.IsNullOrEmpty(x.IndividualId))
                .Select(x => x.IndividualId).ToList();

            if (removedIndividuals != null && removedIndividuals.Any())
            {
                foreach (var indiv in removedIndividuals)
                {
                    var individualFields = newXMLValues.Where(x => x.ParentClass == "ApplicationIndividual.Individual"
                    && x.IndividualId == indiv).ToList();
                    var origIndivDetails = originalXMLValues.Where(x => x.ParentClass == "ApplicationIndividual.Individual" && x.IndividualId == indiv).ToList();

                    //Will call GetFormattedNameWithSuffix
                    var preferredfirstName = origIndivDetails.FirstOrDefault(x => x.Name == "PreferredFirstName")?.Value;
                    var preferredSuffix = origIndivDetails.FirstOrDefault(x => x.Name == "PreferredSuffix")?.Value;
                    var preferredLastName = origIndivDetails.FirstOrDefault(x => x.Name == "PreferredLastName")?.Value;
                    var fullName = string.Join(" ", preferredfirstName, preferredSuffix, preferredLastName);

                    ReportedFieldValues rfb = new ReportedFieldValues()
                    {
                        Field = "Individual",
                        oldValues = "N/A",
                        NewValue = "Removed",
                        ParentClass = "ApplicationIndividual.Individual",
                        SectionIdentifier = "",
                        Name = fullName
                    };
                    variances.Add(rfb);
                    //For Death Date:
                    var origDeathDate = originalXMLValues.FirstOrDefault(x =>
                      x.ParentClass == "ApplicationIndividual.Individual" && x.IndividualId == indiv
                     && x.Name == "DeathDate");
                    var newDeathDate = originalXMLValues.FirstOrDefault(x =>
                     x.ParentClass == "ApplicationIndividual.Individual" && x.IndividualId == indiv
                     && x.Name == "DeathDate");
                    if ((origDeathDate == null || (origDeathDate != null && string.IsNullOrEmpty(origDeathDate.Value)))
                        && (newDeathDate != null && !string.IsNullOrEmpty(newDeathDate.Value)))
                    {
                        variances.Add(PopulateVarianceNew(newDeathDate));
                    }
                    //No need of comparisons and displaying fields for removed individual
                    originalXMLValues.RemoveAll(x => x.IndividualId == indiv);
                    newXMLValues.RemoveAll(x => x.IndividualId == indiv);
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
                        Field = objNew.SectionIdentifier,
                        oldValues = "N/A",
                        NewValue = "Deleted",
                        ParentClass = objNew.ParentClass,
                        SectionIdentifier = "",
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
            //        NewValue = "NA",
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



            return variances;
        }

        static ReportedFieldValues PopulateVarianceMixed(ObjectField objOrig, ObjectField objNew)
        {
            ReportedFieldValues rfb = new ReportedFieldValues()
            {
                Field = objOrig.Name,
                oldValues = objOrig.Value,
                NewValue = objNew.Value,
                ParentClass = objNew.ParentClass,
                SectionIdentifier = objNew.SectionIdentifier,
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
                oldValues = "NA",
                NewValue = objNew.Value,
                ParentClass = objNew.ParentClass,
                SectionIdentifier = objNew.SectionIdentifier,
            };
            if (!string.IsNullOrEmpty(objNew.IndividualId) && dicIndivNameNew.ContainsKey(objNew.IndividualId))
            {
                rfb.Name = dicIndivNameNew[objNew.IndividualId];
            }
            return rfb;
        }

    }




    public class ObjectField
    {
        public string Name { get; set; }
        public string Value { get; set; }
        public string ParentClass { get; set; }
        public int ItemId { get; set; }

        public int PropertyLevel { get; set; }
        public bool IsArray { get; set; }
        public string ArrayName { get; set; }
        public int ArraryIndex { get; set; }
        public string IndividualId { get; set; }
        public string IdentifierName { get; set; }
        public string? IdentifierId { get; set; }
        public string? SectionIdentifier { get; set; }
    }

    public class ReportedFieldValues
    {
        public string ReportedDate { get; set; }
        public string Name { get; set; }
        public string Field { get; set; }
        public string oldValues { get; set; }
        public string NewValue { get; set; }

        public string ParentClass { get; set; }
        public string? SectionIdentifier { get; set; }
    }

}


