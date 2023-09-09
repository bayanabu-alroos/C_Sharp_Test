using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public abstract class Person
    {
        protected string Name { get; set; }

        protected string Phone { get; set; }
        protected string IdNational { get; set; }


        //Method abstract
        public abstract double CalculateSalary();
        public Person() { }
        public Person(string name, string phone, string idNational)
        {
            Name = name;
            Phone = phone;
            IdNational = idNational;
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine("Name : {0} \t Phone : {1}");
        } 

       
    }
}
