using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    internal class MultibleChooseQuestion : Question
    {
        public MultibleChooseQuestion(double mark, string body, Answer correctAnswer) : base("Select all correct answers:", mark, body, correctAnswer) { }
        public override string QuestionFormat()
        {
            return $"{header}\t\t\t\t[{marks} marks]\n\n *) {body}\n";
        }

        public override string ToString()
        {
            if (this.studentAnswer != null)
            {
                return $"{header}\t\t\t\t[{marks} marks]\n\n *) {body}\n -> Your Answer is: {studentAnswer}\n\n -> The Correct Answer is: {correctAnswer}\n";

            }
            else
            {
                return $"{header}\t\t\t\t[{marks} marks]\n\n *) {body}\n";
            }
        }
    }
}
