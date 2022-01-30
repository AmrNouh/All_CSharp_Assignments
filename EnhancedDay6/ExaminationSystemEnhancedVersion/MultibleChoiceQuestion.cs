using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystemEnhancedVersion
{
    internal class MultibleChoiceQuestion : Question
    {
        public MultibleChoiceQuestion(int questionNumber, string questionHeader, string questionBody, int mark) : base(questionNumber, questionHeader, questionBody, mark)
        {
        }
    }
}
