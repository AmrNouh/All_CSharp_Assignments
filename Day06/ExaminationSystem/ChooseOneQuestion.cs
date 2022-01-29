using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    internal class ChooseOneQuestion : Question
    {
        public ChooseOneQuestion(double mark, string body, Answer studentAnswer, Answer correctAnswer) : base("Select the correct answer:", mark, body, studentAnswer, correctAnswer) { }
        public override string QuestionFormat()
        {
            return $"{header}\t\t\t\t [{marks} marks]\n{body}\n";
        }

        public override string ToString()
        {
            if (this.studentAnswer != null)
            {
                return $"{header}\t\t\t\t [{marks} marks]\n{body}\nYour Answer is: {studentAnswer}\n";

            }
            else
            {
                return $"{header}\t\t\t\t [{marks} marks]\n{body}\n";
            }
        }
    }
}
