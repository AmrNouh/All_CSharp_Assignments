using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystemEnhancedVersion
{
    internal class Answer
    {
        int answerNumber;
        string answerBody;

        public Answer(int answerNumber, string answerBody)
        {
            this.answerNumber = answerNumber;
            this.answerBody = answerBody;
        }

        public override string ToString()
        {
            return $"\t{answerNumber}) {answerBody}";
        }

    }

}
