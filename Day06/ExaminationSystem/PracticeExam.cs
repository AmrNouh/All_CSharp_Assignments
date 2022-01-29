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

        public override double Correct(QuestionsList examQuestions, AnswersList correctAnswers)
        {
            double studentGrade;
            return studentGrade = 0;
        }

        public override void PrintExam()
        {
            throw new NotImplementedException();
        }

        public override void ShowExam()
        {
            object answer;
            Console.WriteLine($"{subjectInfo}\t\tExam Time: {examTime.Hours}\n");
            Console.WriteLine($"\n================== {subjectInfo.subjectName} Exam ==================\n");
            Console.WriteLine($"{this.studentInfo}");
            Console.WriteLine($"\n===================================================================\n");
            for (int i = 0; i < this.numberOfQuestions; i++)
            {
                Console.WriteLine(examQuestions[i + 1]);
                do
                {
                    Console.WriteLine("Please Enter The Answer:");
                } while (!Enum.TryParse(typeof(Enum),Console.ReadLine(),out answer));
                this.questionsAnswers[i+1] = (Answer)answer;
                Console.WriteLine(this.questionsAnswers[i + 1]);
            }
        }
    }
}
