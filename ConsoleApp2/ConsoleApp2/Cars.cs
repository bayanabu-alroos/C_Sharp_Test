using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Cars
    {
    
        string brandName;
        internal string modleName;
        int manufacturingYear;
        internal int EngineCapcity;
        internal float Tourq;
        internal int hoursPower;
        internal string FuleConsuming;
        internal float price;
        internal string EngineNumber;
        internal string bodyNumber;




        int ManufacturingYear
        {
            get
            {
                int x = manufacturingYear;
                return x;
            }
            set
            {
                if (value > 2011 || value <= 2023)
                {
                    manufacturingYear = value;
                }
                Console.WriteLine("Invalid Manufacturing Year");
                throw new Exception("Invalid Manufacturing Year");
            }
        }


        internal void SetManufacturingYear(int year)
        {
            if (year > 2011 || year <= 2023)
            {
                manufacturingYear = year;
            }
            Console.WriteLine("Invalid Manufacturing Year");
        }
        internal int GetManufacturingYear()
        {
            int x = manufacturingYear;
            return x;
        }

        public void SetBrandName(string name)
        {
            if (name != "")

            {

                brandName = name;

            }
            Console.WriteLine("Please enter name brand");
        }

        public string GetBrandName()
        {
            string x = brandName;
            return x;
        }
    }
}
