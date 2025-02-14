using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
    public class BusinesslayerClass
    {
        DataLayerClass datalayer = new DataLayerClass();

        public int DetermineAge(string idNumber)
        {
            int birthYear = int.Parse(idNumber.Substring(0, 2));
            int century = birthYear < 22 ? 2000 : 1900;
            int fullYear = century + birthYear;
            return DateTime.Now.Year - fullYear;
        }

        public void SavingToFile(string name, string age)
        {
            string information = $"{name},{age}";
            datalayer.WritingToFile(information);
        }

        public string[] ReadFromFile()
        {
            return datalayer.ReadingFromFile();
        }
    }
}
