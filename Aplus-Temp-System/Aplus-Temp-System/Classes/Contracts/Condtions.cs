using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplus_Temp_System.Classes.Contracts
{
    public sealed class Condtions
    {
        private Condtions() { }
        public Condtions(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public string Name { get; set; }
        public string Description { get; set; }

        ~ Condtions() { }
    }
}
