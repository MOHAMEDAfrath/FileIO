using CsvHelper;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIOOperations
{
   public class JSONtoCsv
    {
        public static void ReadJSONAndWriteToCSV()
        {
           
            string jsonfile = @"C:\Users\afrat\source\repos\FileIOOperations\FileIOOperations\JSON.json";
            string csvfile = @"C:\Users\afrat\source\repos\FileIOOperations\FileIOOperations\JSONtoCSV.csv";
            //deserializes the object 
            List<NewMember> list = JsonConvert.DeserializeObject<List<NewMember>>(File.ReadAllText(jsonfile));
            using(var writer = new StreamWriter(csvfile))
                using(var csv = new CsvWriter(writer,System.Globalization.CultureInfo.InvariantCulture))
            {
                //writes the record to csv
                csv.WriteRecords(list);
            }
            Console.WriteLine("Converted successfully");

        }
    }
}
