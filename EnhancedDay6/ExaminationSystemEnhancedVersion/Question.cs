using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystemEnhancedVersion
{
    abstract internal class Question
    {
        public int questionNumber { get; set; }
        public string questionHeader { get; set; }
        public string questionBody { get; set; }
        public int mark { get; set; }

        public Question(int questionNumber, string questionHeader, string questionBody, int mark)
        {
            this.questionNumber = questionNumber;
            this.questionHeader = questionHeader;
            this.questionBody = questionBody;
            this.mark = mark;
        }

        public override string ToString()
        {
            return $" - {questionHeader}\t\t\t\t[{mark} mark]\n\n {questionNumber}) {questionBody} ?\n";
        }
    }
}
