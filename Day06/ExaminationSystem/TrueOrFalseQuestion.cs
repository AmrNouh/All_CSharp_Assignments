using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    internal class TrueOrFalseQuestion : Question
    {
        public TrueOrFalseQuestion(double mark, string body, Answer studentAnswer, Answer correctAnswer) : base("True or False", mark, body, studentAnswer, correctAnswer) { }
        public override string QuestionFormat()
        {
            return $"{header}\t\t\t\t [{marks} marks]\n{body}\t\t{"( )",7}\n";
        }
        public override string ToString()
        {
            if (this.studentAnswer != null)
            {
            return $"{header}\t\t\t\t [{this.marks} marks]\n{body}\t\t({studentAnswer})\n";

            }
            else
            {
                return $"{header}\t\t\t\t [{marks} marks]\n{body}\t\t{"( )",7}\n";
            }
        }
    }
}
