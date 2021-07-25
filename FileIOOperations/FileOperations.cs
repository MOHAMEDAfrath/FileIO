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
            //Read all lines using ReadAllLines in the text
            Console.WriteLine("*Reads All lines in the text*");
            string[] lines = File.ReadAllLines(path);
            for(int i =0;i<lines.Length;i++)
                Console.WriteLine(lines[i]);
            //Reads the content in the file using readalltext
            Console.WriteLine("*Reads All text in the text file*");
            string read = File.ReadAllText(path);
            Console.WriteLine(read);
        }
    }
}
