using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;


namespace XMLPoc
{
    public class SerializeDeserialize<T>
    {
        StringBuilder sbData;
        StringWriter swWriter;
        XmlDocument xDoc;
        XmlNodeReader xNodeReader;
        XmlSerializer xmlSerializer;
        public SerializeDeserialize()
        {
            sbData = new StringBuilder();
        }
        public string SerializeData(T data)
        {
            XmlSerializer employeeSerializer = new XmlSerializer(typeof(T));
            swWriter = new StringWriter(sbData);
            employeeSerializer.Serialize(swWriter, data);
            return sbData.ToString();
        }
        public T DeserializeData(string dataXML, string xmlnamespace = "")
        {
            xDoc = new XmlDocument();
            xDoc.LoadXml(dataXML);
            var xRoot = new XmlRootAttribute(xDoc.DocumentElement.Name)
            { Namespace = xmlnamespace };
            var serializer = new XmlSerializer(typeof(T), xRoot);
            var reader = new XmlNodeReader(xDoc.DocumentElement);
            return (T)serializer.Deserialize(reader);
        }
        public T DeserializeDataByXMLPath(string dataXML, string xmlPath, string xmlnamespace = "")
        {
            xDoc = new XmlDocument();
            xDoc.LoadXml(dataXML);
            var xRoot = new XmlRootAttribute(xDoc.DocumentElement.Name)
            { Namespace = xmlnamespace };
            var serializer = new XmlSerializer(typeof(T), xRoot);
            var reader = new XmlNodeReader(xDoc.DocumentElement);
            return (T)serializer.Deserialize(XmlReader.Create(xmlPath));


        }
    }
    

}
