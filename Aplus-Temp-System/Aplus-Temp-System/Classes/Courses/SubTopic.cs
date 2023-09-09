using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplus_Temp_System.Classes.Courses
{
    public sealed class SubTopic
    {
        private SubTopic() { }
        public SubTopic(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        ~ SubTopic() { }
    }
}
