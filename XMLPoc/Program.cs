// See https://aka.ms/new-console-template for more information

using Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient;
using System.Net;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using XMLPoc;
namespace XMLPoc
{
    class APDynamicKyeValue
    {
        public string Category { get; set; }
        public int? FieldId { get; set; }
        public Dictionary<string,string> KeyValuePairs { get; set; }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Test!");



            double tempResult;
            var str = "123";
            var result = double.TryParse(str, out tempResult) ? (double?)tempResult : null;
            Console.WriteLine(result);



            //SerializeDemo();
            Program p = new Program();
           //var abc = p.GetAPDynamicKeyValue("Dynamic-CSharp-Variance|ParentClass:ApplicationIndividual.DisabilityInformation,FieldName:IsDisabled,FieldCode:FLD_RREP,Logic:YesIfAnyValueExist",3);

            //p.POC();
            p.GetApplicantUpdates();


            //POCStackOverflow21091452.Invoke();

        }
      

        public void POC()
        {

            Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.Application app = new Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.Application();

        }
        public string GetApplicantUpdates()
        {

            //var OlxXMLFileName = @"C:\SDEB_code\poc\SSPRequestSupriya3_Old.xml";
            //var NewXMLFileName = @"C:\SDEB_code\poc\SSPRequestSupriya4_New.Xml";

            //var OlxXMLFileName = @"C:\SDEB_code\poc\temReqDebug1_Old.xml";
            //var NewXMLFileName = @"C:\SDEB_code\poc\temReqDebug2_New.Xml";

            var OlxXMLFileName = @"C:\SDEB_code\poc\temReqDebug1_Old.xml";
            var NewXMLFileName = @"C:\SDEB_code\poc\temReqDebug2_New.Xml";



            Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.Application app = new Application();
            var fileStream = new FileStream(OlxXMLFileName, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            string fileContents;
            using (StreamReader reader = new StreamReader(fileStream))
            {
                fileContents = reader.ReadToEnd();
            }
            var serializeApplication = new SerializeDeserialize<Application>();
            var deserialiedApplicationOriginal = serializeApplication.DeserializeDataByXMLPath(fileContents, OlxXMLFileName, "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd");

            var fileStream2 = new FileStream(NewXMLFileName, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            string fileContents2;
            using (StreamReader reader2 = new StreamReader(fileStream2))
            {
                fileContents2 = reader2.ReadToEnd();
            }
            var serializeApplication2 = new SerializeDeserialize<Application>();
            var deserialiedApplicationNew = serializeApplication.DeserializeDataByXMLPath(fileContents2, NewXMLFileName, "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd");

            TrackApplicantUpdates trackApplicantUpdates = new TrackApplicantUpdates();

            var originalXMLValues = trackApplicantUpdates.GetPropertyValues(deserialiedApplicationOriginal);
            var newXMLValues = trackApplicantUpdates.GetPropertyValues(deserialiedApplicationNew);

            var variances = trackApplicantUpdates.GetChanges(originalXMLValues,newXMLValues);
           


            //TrackApplicantUpdates.UpdateVarinaces(variances);

            var fileNameTextFile = string.Empty;
            //XmlSerializer serializer = new XmlSerializer(typeof(List<ObjectField>));
            //var path = @"C:\SDEB_code\GeneratedXMLs\ApplicationChangedElements" + DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss")+ ".xml";
            //System.IO.FileStream file = System.IO.File.Create(path);
            //serializer.Serialize(file, originalXMLValues);

            //StringBuilder sb = new StringBuilder();
            //sb.AppendLine("Name\tValue\tParentClass\tPropertyLevel\tIsArray\tArrayName\tArraryIndex\tIndividualId\tIdentifierName\tIdentifierId");
            //foreach (var obj in originalXMLValues)
            //{
            //    var strToAppend = obj.Name + "\t" + obj.Value + "\t" + obj.ParentClass + "\t" + obj.PropertyLevel
            //        + "\t" + obj.IsArray + "\t" + obj.ArrayName + "\t" + obj.ArraryIndex + "\t" + obj.IndividualId
            //        + "\t" + obj.IdentifierName + "\t" + obj.IdentifierId;
            //    sb.AppendLine(strToAppend);
            //}
            //fileNameTextFile = @"C:\SDEB_code\GeneratedXMLs\ApplicationChangedElementsTextFile_" + DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss_fff") + ".txt";
            ////File.WriteAllText(fileNameTextFile, sb.ToString());


            //StringBuilder sb2 = new StringBuilder();
            //sb2.AppendLine("Name\tValue\tParentClass\tPropertyLevel\tIsArray\tArrayName\tArraryIndex\tIndividualId\tIdentifierName\tIdentifierId");
            //foreach (var obj in newXMLValues)
            //{
            //    var strToAppend = obj.Name + "\t" + obj.Value + "\t" + obj.ParentClass + "\t" + obj.PropertyLevel
            //        + "\t" + obj.IsArray + "\t" + obj.ArrayName + "\t" + obj.ArraryIndex + "\t" + obj.IndividualId
            //        + "\t" + obj.IdentifierName + "\t" + obj.IdentifierId;
            //    sb2.AppendLine(strToAppend);
            //}
            //fileNameTextFile = @"C:\SDEB_code\GeneratedXMLs\ApplicationChangedElementsTextFile_" + DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss_fff") + ".txt";
            ////File.WriteAllText(fileNameTextFile, sb2.ToString());

            //StringBuilder sb3 = new StringBuilder();
            //sb3.AppendLine("Name\tField\toldValues\tNewValue\tParentClass\tSectionIdentifier");
            //foreach (var obj in variances)
            //{
            //    var strToAppend = obj.Name + "\t" + obj.Field + "\t" + obj.oldValues + "\t" + obj.NewValue
            //        + "\t" + obj.ParentClass + "\t" + obj.SectionIdentifier;
            //    sb3.AppendLine(strToAppend);
            //}
            //fileNameTextFile = @"C:\SDEB_code\GeneratedXMLs\ApplicationVariances_" + DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss") + ".txt";
            //File.WriteAllText(fileNameTextFile, sb3.ToString());


            string str = "";
            return str;
        }

    }

}
