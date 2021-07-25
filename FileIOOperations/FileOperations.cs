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
        public static string path = @"C:\Users\afrat\source\repos\FileIOOperations\FileIOOperations\FileIO.txt";
        public static void FileOperationsDemo()
        {
            string path = @"C:\Users\afrat\source\repos\FileIOOperations\FileIOOperations\FileIO.txt";
            string copypath = @"C:\Users\afrat\source\repos\FileIOOperations\FileIOOperations\FileIOCopy.txt";
            //Checks whether the file exists or not
            if (File.Exists(path))
            {
                Console.WriteLine("File Exists");
            }
            //Read all lines using ReadAllLines in the text
            Console.WriteLine("*Reads All lines in the text*");
            string[] lines = File.ReadAllLines(path);
            for (int i = 0; i < lines.Length; i++)
                Console.WriteLine(lines[i]);
            //Reads the content in the file using readalltext
            Console.WriteLine("*Reads All text in the text file*");
            string read = File.ReadAllText(path);
            Console.WriteLine(read);
            //Copy the data from one file to another,if file exists it is deleted
            Console.WriteLine("*Copy file from one to another*");
            if (File.Exists(copypath))
            {
                File.Delete(copypath);
                Console.WriteLine("*Deleted copy path file cause file already exist and data is added*");
            }
            File.Copy(path, copypath);
            Console.WriteLine("Copied");


        }
        public static void StreamReaderDemo()
        {
            using(StreamReader sr = File.OpenText(path))
            {
                string s = "";
                while((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
        }
    }
}
