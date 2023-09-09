using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public sealed class Employee : Person
    {

        public int Age { get; set; }

        public bool IsAvailable { get; set; }

        public Employee() { }

        public Employee(int age,bool isavailabe,string name) 
        {
            Name = name;
            Age = age;
            IsAvailable = isavailabe;
        }

        public override double CalculateSalary()
        {
            throw new NotImplementedException();
        }


    }
}
