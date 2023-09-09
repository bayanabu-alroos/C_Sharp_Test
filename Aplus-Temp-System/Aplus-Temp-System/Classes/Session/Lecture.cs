using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplus_Temp_System.Classes.Session
{
    public sealed class Lecture
    {
        private Lecture() { }
        public Lecture(DateOnly date, int number, string topic, TimeSpan startingAt, TimeSpan endingSAt)
        {
            this.date = date;
            this.number = number;
            this.topic = topic;
            this.startingAt = startingAt;
            this.endingSAt = endingSAt;
        }

        public DateOnly date { get; set; }
        public int number{ get; set; }
        public string topic{ get; set; }
        public TimeSpan startingAt{ get; set; }
        public TimeSpan endingSAt { get; set; }

        ~ Lecture() { }  

    }
}
