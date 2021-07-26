using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace FileIOOperations
{
    public class XMLDemo1
    {
        public DateTime dateTime;
    }
    [DataContract]
    public class Blog
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Age { get; set; }

    }
    public class XMLDemo
    {
        //XML serialize
        public static void Serialize()
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(XMLDemo1));
            FileStream fileStream = new FileStream(@"C:\Users\afrat\source\repos\FileIOOperations\FileIOOperations\XMLIO.txt",FileMode.Create);
            XMLDemo1 xMLDemo = new XMLDemo1();
            DateTime date = new DateTime(2021, 7, 26);
            xMLDemo.dateTime = date;
            xmlSerializer.Serialize(fileStream,xMLDemo);
            Console.WriteLine("Serialize Successfull");
        }
        //XML Deserialize
        public static void Deserialize()
        {
            string json = @"{'Name':'Ram Kumar','Age':'15'}";
            Blog blog = JsonConvert.DeserializeObject<Blog>(json);
            Console.WriteLine(blog.Name);
                Console.WriteLine(blog.Age);
        }
    }
}
