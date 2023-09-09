using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplus_Temp_System.Classes.Attendance
{
    public class Attendance
    {
        private Attendance() { }
        public Attendance(bool isPresent)
        {
            IsPresent = isPresent;
        }

        public bool IsPresent { get; set; }

        ~ Attendance() { }
    }
}
