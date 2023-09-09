using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class AplusExam
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Mark {get; set; }
        public string Description {get; set; }

        private AplusExam() { }
        public AplusExam(int id , string name, int mark,string description)
        {
             Id = id;
            Name = name;
            Mark = mark;
            Description = description;
        }
        public AplusExam(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public AplusExam(int id, string name, int mark)
        {
            Id = id;
            Name = name;
            Mark = mark;
        }
        ~ AplusExam() { }


    }
}
