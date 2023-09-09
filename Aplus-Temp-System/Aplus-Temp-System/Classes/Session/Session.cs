using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplus_Temp_System.Classes.Session
{
    public sealed class Session
    {
        private Session() { }
        public Session(string name, DateOnly startDate, DateOnly endDate, int numberofLecture, TimeSpan startTime, TimeSpan endTime, string lectureLink, string whatsAppGroupLink, string schudule, int capcity, List<Lecture> lectures)
        {
            Name = name;
            StartDate = startDate;
            EndDate = endDate;
            NumberofLecture = numberofLecture;
            StartTime = startTime;
            EndTime = endTime;
            LectureLink = lectureLink;
            WhatsAppGroupLink = whatsAppGroupLink;
            Schudule = schudule;
            Capcity = capcity;
            Lectures = lectures;
        }

        public string Name { get; set; }
        public DateOnly StartDate{ get; set; }
        public DateOnly EndDate { get; set; }
        public int NumberofLecture{ get; set; }
        public TimeSpan StartTime{ get; set; }
        public TimeSpan EndTime { get; set; }
        public string LectureLink{ get; set; }
        public string WhatsAppGroupLink{ get; set; }
        public string Schudule{ get; set; }
        public int Capcity{ get; set; }
        public List<Lecture> Lectures { get; set; }

        ~ Session  ( ) { }

    }
}
