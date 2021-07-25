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
        }
    }
}
