using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    internal class PracticeExam : Exam
    {
        public PracticeExam() : base() { }
        public PracticeExam(TimeSpan examTime, Subject subjectInfo, Student studentInfo, int numberOfQuestion, QuestionsList questions, AnswersList answers) : base(examTime, subjectInfo, studentInfo, numberOfQuestion, questions, answers) { }
        protected override void ShowExam()
        {
            
        }
    }
}
