using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplus_Temp_System.Classes.Courses
{
    public sealed class Goals
    {
        private Goals() { }
        public Goals(string description, string name)
        {
            Description = description;
            Name = name;
        }

        public string Description { get; set; }
        public string Name { get; set; }

        ~ Goals() { }

    }
}
