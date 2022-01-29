using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    abstract class Question
    {
        public string header { get; set; }
        public double marks { get; set; }
        public string body { get; set; }
        public Answer studentAnswer { get; set; }
        public Answer correctAnswer { get; set; }

        public Question(string questionHeader,double marks, string questionBody,Answer correctAnswer, Answer studentAnswer = null)
        {
            this.header = questionHeader;
            this.marks = marks;
            this.body = questionBody;
            this.correctAnswer = correctAnswer;
        }

        abstract public string QuestionFormat();
    }
}
