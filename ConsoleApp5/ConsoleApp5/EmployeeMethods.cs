using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal partial class Employee
    {
        public Employee()
        {
            Console.WriteLine("Object is created");
        }

        public void DisplayTimeSheet() { }

        public decimal CalculateSalary()
        {
            return 1000;
        }
    }
}
