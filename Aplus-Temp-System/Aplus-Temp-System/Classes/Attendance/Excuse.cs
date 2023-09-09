using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplus_Temp_System.Classes.Attendance
{
    public class Excuse
    {
        private Excuse() { }
        public Excuse(string date, string lecture, string excusedocument, bool isApproved)
        {
            Date = date;
            Lecture = lecture;
            Excusedocument = excusedocument;
            IsApproved = isApproved;
        }

        public string Date {get; set;}
        public string Lecture {get; set;}
        public string Excusedocument {get; set;}
        public bool IsApproved {get; set;}

        ~ Excuse() { }
    }
}
