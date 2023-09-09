using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplus_Temp_System.Classes.Evalouitions
{
    public sealed class Answer
    {
        private Answer() { }
        public Answer(string answer, bool iSCorrect)
        {
            Answers = answer;
            ISCorrect = iSCorrect;
        }

        public string Answers{ get; set; }
        public bool ISCorrect{ get; set; }

        ~ Answer() { }
    }
}
