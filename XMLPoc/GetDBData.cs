
using Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient;
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


            string connectionString = @"data source=USBLRSUBDEB4\SQLEXPRESS; database=SubhaDB; integrated security=SSPI";
            string queryString = "select ClassName,ClassIdentifier,MiscellaneousIdentifier from [Framework].[APClassIdentifier]";
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
                   
                    DataSet dataSet = new DataSet();
                    var dataAdapter = new SqlDataAdapter(command);

                    dataAdapter.Fill(dataSet);


                    foreach (DataRow row in dataSet.Tables[0].Rows)
                    {
                        APClassIdentier record = new APClassIdentier();
                        record.ParentClass = row[0].ToString();
                        record.IdentifierName = row[1].ToString();
                        record.MiscIdentifier = row[2].ToString();

                        aPClassIdentiersList.Add(record);
                    }
                }
            }

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

        public string MiscIdentifier { get; set; }
    }

}
