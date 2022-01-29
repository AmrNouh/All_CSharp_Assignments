using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    internal class FinalExam : Exam
    {
        public FinalExam() : base() { }
        public FinalExam(TimeSpan examTime, Subject subjectInfo, Student studentInfo, int numberOfQuestion, QuestionsList questions, AnswersList answers) : base(examTime, subjectInfo, studentInfo, numberOfQuestion, questions, answers) { }

        public override double Correct(QuestionsList examQuestions, AnswersList correctAnswers)
        {
            throw new NotImplementedException();
        }

        public override void PrintExam()
        {
            throw new NotImplementedException();
        }

        public override void ShowExam()
        {
            throw new NotImplementedException();
        }
    }
}
