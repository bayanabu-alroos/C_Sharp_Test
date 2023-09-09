using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplus_Temp_System.Classes.Courses
{
    public sealed class Level
    {
        private Level() { }
        public Level(string name, short numberOfHours, short numberofLecture)
        {
            Name = name;
            NumberOfHours = numberOfHours;
            NumberofLecture = numberofLecture;
        }

        public string Name { get; set; }
        public short NumberOfHours { get; set; }
        public short NumberofLecture { get; set; }

        ~ Level() { }
    }
}
