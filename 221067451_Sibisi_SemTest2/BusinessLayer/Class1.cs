using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;


namespace BusinessLayer
{
    public class BusinessLayerClass
    {
        DataLayerClass data = new DataLayerClass();

        public string generateEmail(string name, string surname)
        {
            string email = $"{name.ToLower()[0]}{surname.ToLower()}@coders.co.za";
            return email;
        }

        public List<string> ReadfromFiles()
        {
            List<string> records = data.readFromFile();
            return records;
        }

        public void SaveToFile(string contents)
        {
            data.writeToFile(contents);
        }

        public string formatNumber(int number)
        {
            string num = $"{number}-{number}-{number}";
            return num;
        }
    }
}
