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
        public void WritingToFile(string information)
        {
            using (StreamWriter writer = new StreamWriter(@"C:\Users\user\source\repos\221067451_TSB SIBISI_Final Assessment\Question2\DataLayer\bin\Debug\People.txt", true))
            {
                writer.WriteLine(information);
            }
        }

        public string[] ReadingFromFile()
        {
            string[] records = File.ReadAllLines(@"C:\Users\user\source\repos\221067451_TSB SIBISI_Final Assessment\Question2\DataLayer\bin\Debug\People.txt");
            return records;
        }
    }
    
}
