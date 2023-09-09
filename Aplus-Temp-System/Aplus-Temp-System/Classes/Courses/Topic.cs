using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplus_Temp_System.Classes.Courses
{
    public sealed class Topic
    {
        private Topic() { }
        public Topic(string name, short numberofLecture, List<SubTopic> subTopics)
        {
            Name = name;
            NumberofLecture = numberofLecture;
            SubTopics = subTopics;
        }

        public string Name { get; set; }
       public short NumberofLecture { get; set; }
       public List<SubTopic> SubTopics { get; set; }

        ~ Topic() { }   
    }
}
