using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplus_Temp_System.Classes.Evalouitions
{
    public sealed class Exam
    {
        private Exam() { }
        public Exam(DateOnly date, double mark, TimeSpan startTime, TimeSpan endTime, double questionSummation, List<Questions> questions)
        {
            Date = date;
            Mark = mark;
            StartTime = startTime;
            EndTime = endTime;
            QuestionSummation = questionSummation;
            Questions = questions;
        }

        public DateOnly Date{ get; set; }
        public double Mark{ get; set; }
        public TimeSpan StartTime{ get; set; }
        public TimeSpan EndTime { get; set; }
        public double QuestionSummation{ get; set; }
        public List<Questions> Questions { get; set; }

        ~ Exam() { }
    }
}
