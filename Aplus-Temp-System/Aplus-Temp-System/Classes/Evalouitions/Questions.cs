using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplus_Temp_System.Classes.Evalouitions
{
    public sealed class Questions
    {
        private Questions() { }
        public Questions(string title, string image, string description, string questionType, List<Answer> answers)
        {
            Title = title;
            Image = image;
            Description = description;
            QuestionType = questionType;
            Answers = answers;
        }

        public string Title{ get; set; }
        public string Image{ get; set; }
        public string Description{ get; set; }
        public string QuestionType{ get; set; }
        public List<Answer> Answers { get; set; }

        ~ Questions() { }
    }
}
