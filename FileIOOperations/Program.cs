using System;

namespace FileIOOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            FileOperations.FileOperationsDemo();
            Console.WriteLine("Stream Reader");
            FileOperations.StreamReaderDemo();
            Console.WriteLine("Stream Writer");
            FileOperations.StreamWriterDemo();
            Console.WriteLine("***Binary Serialize***");
            //BinaryOperations.Serialization();
            Console.WriteLine("***Binary Deserialize***");
            DeserializeDemo.Deserialize();
            Console.WriteLine("###XML Serialize###");
            XMLDemo.Serialize();
            Console.WriteLine("###XML DeSerialize###");
            XMLDemo.Deserialize();




        }
    }
}
