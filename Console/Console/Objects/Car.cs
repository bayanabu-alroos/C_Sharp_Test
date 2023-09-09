using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempProject.Objects
{
    internal class Car:Contract
    {
        internal string brandName;
        internal string modleName;
        int manufacturingYear;
        internal int EngineCapcity;
        internal float Tourq;
        internal int hoursPower;
        string FuleConsuming { get; set; }
        internal float price;
        internal string EngineNumber;
        internal string bodyNumber;
        public override void TypeContract()
        {
            base.TypeContract();
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

        private Car()
        {

        }
        public Car(string brandName, string modleName, int manufacturingYear, int engineCapcity, float tourq, int hoursPower, string fuleConsuming, float price, string engineNumber, string bodyNumber)
        {
            this.brandName = brandName;
            this.modleName = modleName;
            this.manufacturingYear = manufacturingYear;
            EngineCapcity = engineCapcity;
            Tourq = tourq;
            this.hoursPower = hoursPower;
            FuleConsuming = fuleConsuming;
            this.price = price;
            EngineNumber = engineNumber;
            this.bodyNumber = bodyNumber;
        }

        ~ Car() { }
        
    }
}
