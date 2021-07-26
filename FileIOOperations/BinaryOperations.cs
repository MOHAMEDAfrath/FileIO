using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace FileIOOperations
{
    [Serializable]
    public class Demo
    {
        public string name
        {
            get;
            set;
        } = "Ram Kumar";
        public int age
        {
            get; set;
        } = 15;
    }
    public class BinaryOperations
    {
        //binary serialize
        public static string filepath = @"C:\Users\afrat\source\repos\FileIOOperations\FileIOOperations\BinaryIO.txt";
        public static void Serialization()
        {
            Demo demo = new Demo();
            FileStream fileStream = new FileStream(filepath, FileMode.Create);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            binaryFormatter.Serialize(fileStream, demo);
            
        }
    }
    //binary deserialize
    public class DeserializeDemo
    {
        public static string filepath = @"C:\Users\afrat\source\repos\FileIOOperations\FileIOOperations\BinaryIO.txt";
        public static void Deserialize()
        {
            Console.WriteLine("Data");
            FileStream fileStream1 = new FileStream(filepath, FileMode.Open,FileAccess.Read);
            BinaryFormatter binaryFormatter1 = new BinaryFormatter();
            Demo demo1 = (Demo)binaryFormatter1.Deserialize(fileStream1);
            Console.WriteLine($"Name {demo1.name}");
            Console.WriteLine($"Age {demo1.age}");
        }

    }

        
}
