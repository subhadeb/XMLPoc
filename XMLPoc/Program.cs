// See https://aka.ms/new-console-template for more information

using Ky.Hbe.WorkerPortal.SharedServices.Contracts.Models.SSPDC;
using System.Net;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using XMLPoc;
namespace XMLPoc
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Test!");
         
            //SerializeDemo();
            Program p = new Program();
            //p.POC();
            p.GetApplicantUpdates();

            
            
            //POCStackOverflow21091452.Invoke();

        }


        public void POC()
        {

            Ky.Hbe.WorkerPortal.SharedServices.Contracts.Models.SSPDC.Application app = new Ky.Hbe.WorkerPortal.SharedServices.Contracts.Models.SSPDC.Application();

        }
        public string GetApplicantUpdates()
        {

            //var OlxXMLFileName = @"C:\SDEB_code\poc\SSPRequestXMLRakesh1.xml";
            //var NewXMLFileName = @"C:\SDEB_code\poc\SSPRequestXMLRakesh2.xml";

            //var OlxXMLFileName = @"C:\SDEB_code\poc\SSPTable-Old.xml";
            //var NewXMLFileName = @"C:\SDEB_code\poc\SSPTable-New.xml";

            var OlxXMLFileName = @"C:\SDEB_code\poc\SSPRequestSprihaFriday1_Old.xml";
            var NewXMLFileName = @"C:\SDEB_code\poc\SSPRequestSprihaFriday2_New.xml";



            Ky.Hbe.WorkerPortal.SharedServices.Contracts.Models.SSPDC.Application app = new Application();
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
            
            var originalXMLValues = TrackApplicantUpdates.GetPropertyValues(deserialiedApplicationOriginal);
            var newXMLValues = TrackApplicantUpdates.GetPropertyValues(deserialiedApplicationNew);

            var variances = TrackApplicantUpdates.GetChanges(originalXMLValues,newXMLValues);


            
            XmlSerializer serializer = new XmlSerializer(typeof(List<ObjectField>));
            var path = @"C:\SDEB_code\GeneratedXMLs\ApplicationChangedElements" + DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss")+ ".xml";
            System.IO.FileStream file = System.IO.File.Create(path);
            serializer.Serialize(file, originalXMLValues);

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Name\tValue\tParentClass\tPropertyLevel\tIsArray\tArrayName\tArraryIndex\tIndividualId\tIdentifierName\tIdentifierId");
            foreach (var obj in originalXMLValues)
            {
                var strToAppend = obj.Name + "\t" + obj.Value + "\t" + obj.ParentClass + "\t" + obj.PropertyLevel
                    + "\t" + obj.IsArray + "\t" + obj.ArrayName + "\t" + obj.ArraryIndex + "\t" + obj.IndividualId
                    + "\t" + obj.IdentifierName + "\t" + obj.IdentifierId;
                sb.AppendLine(strToAppend);
            }
            var fileNameTextFile = @"C:\SDEB_code\GeneratedXMLs\ApplicationChangedElementsTextFile_" + DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss") + ".txt";
            File.WriteAllText(fileNameTextFile, sb.ToString());


            string str = "";
            return str;
        }
      

     



    }
   
}
