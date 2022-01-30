using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystemEnhancedVersion
{
    internal class TrueOrFalseQuestion : Question
    {
        public TrueOrFalseQuestion(int questionNumber, string questionBody, int mark) : base(questionNumber, "True Or False :", questionBody, mark)
        {
        }
    }
}
