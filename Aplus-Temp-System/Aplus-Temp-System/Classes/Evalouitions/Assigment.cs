using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplus_Temp_System.Classes.Evalouitions
{
    public sealed  class Assigment
    {
        private Assigment() { }
        public Assigment(DateTime date, TimeSpan startime, TimeSpan endtime, string title, double mark, string doumentPath)
        {
            Date = date;
            Startime = startime;
            Endtime = endtime;
            Title = title;
            Mark = mark;
            DoumentPath = doumentPath;
        }

        public DateTime Date { get; set; }
        public TimeSpan Startime { get; set; }
        public TimeSpan Endtime { get; set; }
        public string Title { get; set; }
        public double Mark { get; set; }
        public string DoumentPath { get; set; }

        ~ Assigment() { }

    }
}
