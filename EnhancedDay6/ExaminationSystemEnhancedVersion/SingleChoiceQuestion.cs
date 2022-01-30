using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystemEnhancedVersion
{
    internal class SingleChoiceQuestion : Question
    {
        public SingleChoiceQuestion(int questionNumber, string questionBody, int mark) : base(questionNumber, "Select The correct Answer:", questionBody, mark)
        {
        }
    }
}
