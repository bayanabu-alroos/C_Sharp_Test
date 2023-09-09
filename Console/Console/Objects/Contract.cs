using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempProject.Objects
{
    internal class Contract
    {
        string title;
        string description;
        string startDate;
        string endDate;
        float totalPrice;
        int rentDays;

        public static void MyMethod()
        {
            Console.WriteLine(Math.Pow(8, 2));
        }

        public virtual void TypeContract () 
        {
            string first = "Rent Contract";

        }
    }
}
