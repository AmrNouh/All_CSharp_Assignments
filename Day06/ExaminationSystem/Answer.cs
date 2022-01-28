using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    internal class Answer
    {
        //public TypeOfQuestion toq { get; set; }
        public Enum answer { get; set; }


        public Answer(Enum answer)
        {
           this.answer = answer;
        }

    }
}
