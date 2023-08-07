
using Ky.Hbe.WorkerPortal.SharedServices.Contracts.Models.SSPDC;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;//Got it from nuget, Microsoft.Data.SqlClient(initially installed) does not work.
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLPoc
{
    public static class GetDBData
    {

        public static List<APFields> FetchAPFields()
        {
            List<APFields> aPFieldsList = new List<APFields>();
            string connectionString = @"data source=USBLRSUBDEB4\SQLEXPRESS; database=SubhaDB; integrated security=SSPI";
            string queryString = "select APFieldId, FieldName,WPDisplayName,SectionName,ModuleName from Framework.APField F join Framework.APSection S on F.APSectionId = S.APSectionId join Framework.APModule M on S.ApModuleId=M.ApModuleId";
            int paramValue = 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(queryString, connection))
                {
                    //command.Parameters.AddWithValue("@id", paramValue);

                    //--------------------------DATASET PROPERTIES
                    //--------------------------#3.1 The DataSet is a in-memory representation of data. It can be used with multiple data sources.
                    //-------------------------- That is A single DataSet can hold the data from different data sources holdng data from different databases/tables.
                    //--------------------------#3.2 The DataSet represents a complete set of data including related tables, constraints, 
                    //-------------------------- and relationships among the tables. 
                    //--------------------------#3.3 The DataAdapter acts as a bridge between a DataSet and a data source for retrieving and saving data. 
                    Console.WriteLine("Using DataSet: ");

                    DataSet dataSet = new DataSet();
                    var dataAdapter = new SqlDataAdapter(command);

                    dataAdapter.Fill(dataSet);


                    foreach (DataRow row in dataSet.Tables[0].Rows)
                    {
                        APFields aPFields = new APFields();
                        aPFields.APFieldId = Convert.ToInt32(row[0]);
                        aPFields.APFieldName = row[1].ToString();
                        aPFields.WPDisplayName = row[2].ToString();
                        aPFields.SectionName = row[3].ToString();
                        aPFields.ModuleName = row[4].ToString();

                        aPFieldsList.Add(aPFields);
                    }
                }
            }
            return aPFieldsList;
        }
        public static List<APClassIdentier> FetchAPClassIdentiers()
        {
            List<APClassIdentier> aPClassIdentiersList  = new List<APClassIdentier>();



            APClassIdentier aPClassIdentier4 = new APClassIdentier();
            aPClassIdentier4.ParentClass = "ApplicationIndividual.LivingArrangement";
            aPClassIdentier4.IdentifierName = "LivingArrangementId";
            aPClassIdentiersList.Add(aPClassIdentier4);


            APClassIdentier aPClassIdentier5 = new APClassIdentier();
            aPClassIdentier5.ParentClass = "ApplicationIndividual.Resource.RealEstatePropertyDetails.ResourceOwnership";
            aPClassIdentier5.IdentifierName = "ResourceOwnershipDetailId";
            aPClassIdentiersList.Add(aPClassIdentier5);


            APClassIdentier aPClassIdentier6 = new APClassIdentier();
            aPClassIdentier6.ParentClass = "ApplicationIndividual.Individual.SpecificIncomeDetails";
            aPClassIdentier6.IdentifierName = "SpecificIncomeDetailId";
            aPClassIdentiersList.Add(aPClassIdentier6);


           

            APClassIdentier aPClassIdentier7 = new APClassIdentier();
            aPClassIdentier7.ParentClass = "ApplicationIndividual.LivingArrangement";
            aPClassIdentier7.IdentifierName = "LivingArrangementId";
            aPClassIdentiersList.Add(aPClassIdentier7);

            APClassIdentier aPClassIdentier8 = new APClassIdentier();
            aPClassIdentier8.ParentClass = "ApplicationIndividual.Individual.MedicareDetails";
            aPClassIdentier8.IdentifierName = "HealthInsurancePolicyDetailId";
            aPClassIdentiersList.Add(aPClassIdentier8);

            APClassIdentier aPClassIdentier9 = new APClassIdentier();
            aPClassIdentier9.ParentClass = "ApplicationIndividual.Incarceration";
            aPClassIdentier9.IdentifierName = "IncarcerationId";
            aPClassIdentiersList.Add(aPClassIdentier9);

            APClassIdentier aPClassIdentier10 = new APClassIdentier();
            aPClassIdentier10.ParentClass = "ApplicationIndividual.EntitledBenefits";
            aPClassIdentier10.IdentifierName = "EntitledBenefitId";
            aPClassIdentiersList.Add(aPClassIdentier10);


            APClassIdentier aPClassIdentier11 = new APClassIdentier();
            aPClassIdentier11.ParentClass = "ApplicationIndividual.Resource.LiquidAssetDetails.ResourceOwnership";
            aPClassIdentier11.IdentifierName = "ResourceOwnershipDetailId";
            aPClassIdentiersList.Add(aPClassIdentier11);

            APClassIdentier aPClassIdentier12 = new APClassIdentier();
            aPClassIdentier12.ParentClass = "ApplicationIndividual.Individual.Employer.EmploymentInfo";
            aPClassIdentier12.IdentifierName = "EmploymentDetaild";
            aPClassIdentiersList.Add(aPClassIdentier12);

            APClassIdentier aPClassIdentier3 = new APClassIdentier();
            aPClassIdentier3.ParentClass = "ApplicationIndividual.Individual.SelfEmploymentIncomeDetail.IncomePayDetail";
            aPClassIdentier3.IdentifierName = "IncomePayDetailId";
            aPClassIdentiersList.Add(aPClassIdentier3);

            APClassIdentier aPClassIdentier13 = new APClassIdentier();
            aPClassIdentier13.ParentClass = "ApplicationIndividual.Individual.Employer.EmploymentDetail.IncomePayDetail";
            aPClassIdentier13.IdentifierName = "IncomePayDetailId";
            aPClassIdentiersList.Add(aPClassIdentier13);


            APClassIdentier aPClassIdentier14 = new APClassIdentier();
            aPClassIdentier14.ParentClass = "ApplicationIndividual.Individual.UnearnedIncomeDetail.IncomePayDetail";
            aPClassIdentier14.IdentifierName = "IncomePayDetailId";
            aPClassIdentiersList.Add(aPClassIdentier14);


            APClassIdentier aPClassIdentier15 = new APClassIdentier();
            aPClassIdentier15.ParentClass = "ApplicationIndividual.AccidentInjuryDetails.Address";
            aPClassIdentier15.IdentifierName = "AddressId";
            aPClassIdentiersList.Add(aPClassIdentier15);

            APClassIdentier aPClassIdentier16 = new APClassIdentier();
            aPClassIdentier16.ParentClass = "ApplicationIndividual.Individual.IndividualDisability";
            aPClassIdentier16.IdentifierName = "IndividualId";
            aPClassIdentiersList.Add(aPClassIdentier16);

            APClassIdentier aPClassIdentier17 = new APClassIdentier();
            aPClassIdentier17.ParentClass = " ApplicationIndividual.AccidentInjuryDetails";
            aPClassIdentier17.IdentifierName = "IndividualId";
            aPClassIdentiersList.Add(aPClassIdentier17);

            APClassIdentier aPClassIdentier18 = new APClassIdentier();
            aPClassIdentier18.ParentClass = "ApplicationIndividual.Individual.VerifyCurrentIncome";
            aPClassIdentier18.IdentifierName = "VerifyCurrentIncomeId";
            aPClassIdentiersList.Add(aPClassIdentier18);


            APClassIdentier aPClassIdentier19 = new APClassIdentier();
            aPClassIdentier19.ParentClass = "ApplicationIndividual.Individual.Employer.EmploymentDetail";
            aPClassIdentier19.IdentifierName = "EmploymentDetaild";
            aPClassIdentiersList.Add(aPClassIdentier19);

            APClassIdentier aPClassIdentier20 = new APClassIdentier();
            aPClassIdentier20.ParentClass = "ApplicationIndividual.Individual";
            aPClassIdentier20.IdentifierName = "IndividualId";
            aPClassIdentiersList.Add(aPClassIdentier20);


            APClassIdentier aPClassIdentier21 = new APClassIdentier();
            aPClassIdentier21.ParentClass = "ApplicationIndividual.Individual.SelfEmploymentIncomeDetail";
            aPClassIdentier21.IdentifierName = "SelfEmploymentIncomeDetailId";
            aPClassIdentiersList.Add(aPClassIdentier21);

            APClassIdentier aPClassIdentier22 = new APClassIdentier();
            aPClassIdentier22.ParentClass = "ApplicationIndividual.Resource.LiquidAssetDetails";
            aPClassIdentier22.IdentifierName = "ResourceId";
            aPClassIdentiersList.Add(aPClassIdentier22);

            APClassIdentier aPClassIdentier23 = new APClassIdentier();
            aPClassIdentier23.ParentClass = "ApplicationIndividual.Individual.UnearnedIncomeDetail";
            aPClassIdentier23.IdentifierName = "UnearnedIncomeDetailId";
            aPClassIdentiersList.Add(aPClassIdentier23);

            APClassIdentier aPClassIdentier24 = new APClassIdentier();
            aPClassIdentier24.ParentClass = "ApplicationIndividual.UnpaidEmploymentDetails";
            aPClassIdentier24.IdentifierName = "UnpaidEmploymentId";
            aPClassIdentiersList.Add(aPClassIdentier24);

            APClassIdentier aPClassIdentier25 = new APClassIdentier();
            aPClassIdentier25.ParentClass = "ApplicationIndividual.StatusOfTaxFiling";
            aPClassIdentier25.IdentifierName = "StatusofTaxFilingId";
            aPClassIdentiersList.Add(aPClassIdentier25);

            
            APClassIdentier aPClassIdentier26 = new APClassIdentier();
            aPClassIdentier26.ParentClass = "ApplicationIndividual.IndividualEducation.EnrollmentSummary";
            aPClassIdentier26.IdentifierName = "EducationEnrollmentId";
            aPClassIdentiersList.Add(aPClassIdentier26);


            APClassIdentier aPClassIdentier27 = new APClassIdentier();
            aPClassIdentier27.ParentClass = "ApplicationIndividual.Individual.SpecificIncomeDetails.IncomePayDetail";
            aPClassIdentier27.IdentifierName = "IncomePayDetailId";
            aPClassIdentiersList.Add(aPClassIdentier27);


            APClassIdentier aPClassIdentier28 = new APClassIdentier();
            aPClassIdentier28.ParentClass = "ApplicationIndividual.Resource.VehicleDetails.ResourceOwnership.JointOwnersDetails";
            aPClassIdentier28.IdentifierName = "JointOwnerDetailID";
            aPClassIdentiersList.Add(aPClassIdentier28);


            APClassIdentier aPClassIdentier29 = new APClassIdentier();
            aPClassIdentier29.ParentClass = "ApplicationIndividual.Resource.VehicleDetails.ResourceOwnership";
            aPClassIdentier29.IdentifierName = "ResourceOwnershipDetailId";
            aPClassIdentiersList.Add(aPClassIdentier29);

         

            APClassIdentier aPClassIdentier30 = new APClassIdentier();
            aPClassIdentier30.ParentClass = "ApplicationIndividual.Individual.Contact";
            aPClassIdentier30.IdentifierName = "ContactId";
            aPClassIdentiersList.Add(aPClassIdentier30);


            APClassIdentier aPClassIdentier31 = new APClassIdentier();
            aPClassIdentier31.ParentClass = "ApplicationIndividual.Resource.LifeInsuranceDetails";
            aPClassIdentier31.IdentifierName = "ResourceId";
            aPClassIdentiersList.Add(aPClassIdentier31);


            APClassIdentier aPClassIdentier32 = new APClassIdentier();
            aPClassIdentier32.ParentClass = "ApplicationIndividual.Resource.TrustDetails";
            aPClassIdentier32.IdentifierName = "ResourceId";
            aPClassIdentiersList.Add(aPClassIdentier32);


            APClassIdentier aPClassIdentier33 = new APClassIdentier();
            aPClassIdentier33.ParentClass = "ApplicationIndividual.OutOfStateBenefits";
            aPClassIdentier33.IdentifierName = "IndividualId";
            aPClassIdentiersList.Add(aPClassIdentier33);


            APClassIdentier aPClassIdentier34 = new APClassIdentier();
            aPClassIdentier34.ParentClass = "ApplicationIndividual.DisabilityInformation";
            aPClassIdentier34.IdentifierName = "DisabilityId";
            aPClassIdentiersList.Add(aPClassIdentier34);


            APClassIdentier aPClassIdentier35 = new APClassIdentier();
            aPClassIdentier35.ParentClass = "ApplicationIndividual.Individual.MedicalCoverage.CoveredIndividual";
            aPClassIdentier35.IdentifierName = "CoveredIndividualId";
            aPClassIdentiersList.Add(aPClassIdentier35);


            APClassIdentier aPClassIdentier36 = new APClassIdentier();
            aPClassIdentier36.ParentClass = "ApplicationIndividual.SSIBenefit";
            aPClassIdentier36.IdentifierName = "SSIBenefitId";
            aPClassIdentiersList.Add(aPClassIdentier36);


            APClassIdentier aPClassIdentier37 = new APClassIdentier();
            aPClassIdentier37.ParentClass = "ApplicationIndividual.WorkRequirementExemption";
            aPClassIdentier37.IdentifierName = "WorkRequirementExemptionId";
            aPClassIdentiersList.Add(aPClassIdentier37);


            APClassIdentier aPClassIdentier38 = new APClassIdentier();
            aPClassIdentier38.ParentClass = "ApplicationIndividual.Resource";
            aPClassIdentier38.IdentifierName = "ResourceId";
            aPClassIdentiersList.Add(aPClassIdentier38);


            APClassIdentier aPClassIdentier39 = new APClassIdentier();
            aPClassIdentier39.ParentClass = "ApplicationIndividual.Resource.VehicleDetails";
            aPClassIdentier39.IdentifierName = "ResourceDetailId";
            aPClassIdentiersList.Add(aPClassIdentier39);


            APClassIdentier aPClassIdentier40 = new APClassIdentier();
            aPClassIdentier40.ParentClass = "ApplicationIndividual.IndividualEducation";
            aPClassIdentier40.IdentifierName = "EducationId";
            aPClassIdentiersList.Add(aPClassIdentier40);


            APClassIdentier aPClassIdentier41 = new APClassIdentier();
            aPClassIdentier41.ParentClass = "ApplicationIndividual.Resource.RealEstatePropertyDetails.ResourceOwnership.JointOwnersDetails";
            aPClassIdentier41.IdentifierName = "JointOwnerDetailID";
            aPClassIdentiersList.Add(aPClassIdentier41);


            APClassIdentier aPClassIdentier42 = new APClassIdentier();
            aPClassIdentier42.ParentClass = "ApplicationIndividual.Resource.LiquidAssetDetails.ResourceOwnership.JointOwnersDetails";
            aPClassIdentier42.IdentifierName = "JointOwnerDetailID";
            aPClassIdentiersList.Add(aPClassIdentier42);


            APClassIdentier aPClassIdentier43 = new APClassIdentier();
            aPClassIdentier43.ParentClass = "ApplicationIndividual.Individual.Expense";
            aPClassIdentier43.IdentifierName = "ExpenseDetailId";
            aPClassIdentiersList.Add(aPClassIdentier43);



            return aPClassIdentiersList;
        }
    }

    public class APFields
    {
        public int APFieldId { get; set; }
        public string APFieldName { get; set; }
        public string WPDisplayName { get; set; }
        public string SectionName { get; set; }
        public string ModuleName { get; set; }

    }

    public class APClassIdentier
    {
        public string ParentClass { get; set; }
        public string IdentifierName { get; set; }

        public string IdentifierName2 { get; set; }
    }

}
