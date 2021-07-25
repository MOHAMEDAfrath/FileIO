using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIOOperations
{
    class FileOperations
    {
        public static void FileOperationsDemo()
        {
            string path = @"C:\Users\afrat\source\repos\FileIOOperations\FileIOOperations\FileIO.txt";
            //Checks whether the file exists or not
            if (File.Exists(path))
            {
                Console.WriteLine("File Exists");
            }
        }
    }
}
