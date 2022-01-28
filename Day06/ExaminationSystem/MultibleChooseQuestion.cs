using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    internal class MultibleChooseQuestion:Question
    {
        public MultibleChooseQuestion(double mark, string body, Answer studentAnswer, Answer correctAnswer) : base("Select the correct answer:", mark, body, studentAnswer, correctAnswer) { }
        public override string QuestionFormat()
        {
            throw new NotImplementedException();
        }
    }
}
