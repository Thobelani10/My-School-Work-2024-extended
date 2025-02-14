using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class DataLayerClass
    {
        string filepath = @"C:\Users\user\source\repos\221067451_Sibisi_SemTest2\DataLayer\bin\Debug\Employee.txt";

        public void writeToFile(string contents)
        {
            File.AppendAllText(filepath, contents);
        }

        public List<string> readFromFile()
        {
            List<string> records = new List<string>();
            records = File.ReadAllLines(filepath).ToList();

            return records;
        }
    }
}
