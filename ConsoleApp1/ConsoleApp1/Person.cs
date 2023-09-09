using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Person
    {
        public string Name { get; set; }

        public Country Country { get; set; }

        public Languge Languge { get; set; }
        public Person() { }

        public Person(string name, Country country, Languge languge)
        {
            Name = name;
            Country = country;
            Languge = languge;
        }
    }
}
