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

        public override double Correct(QuestionsList examQuestions, AnswersList studentAnswers)
        {
            double studentGrade = 0;
            Question question;
            for (int i = 0; i < this.numberOfQuestions; i++)
            {
                question = examQuestions[i + 1];
                if (question.correctAnswer == studentAnswers[i+1])
                {
                    studentGrade += question.marks;
                }
            }
            return studentGrade;
        }

        public override void PrintExam()
        {
            Console.Clear();
            Console.WriteLine("\n==================== Practic Exam Result ====================\n");
            for (int i = 0; i < this.numberOfQuestions; i++)
            {
                Console.WriteLine($"\n - Question ({i + 1}) With answer:\n");
                Console.WriteLine(this.examQuestions[i + 1]);
                Console.WriteLine("==============================================");

            }
        }

        public override void ShowExam()
        {
            object answer;
            Question question;
            Type answerType;

            for (int i = 0; i < this.numberOfQuestions; i++)
            {
                Console.WriteLine($"\n===================================================================");
                Console.WriteLine($"\n - Question Number {i + 1} of {this.numberOfQuestions}");
                Console.WriteLine($"\n===================================================================\n");

                question = examQuestions[i + 1];
                answerType = Answer.CheckQuestionType(question);
                Console.WriteLine(question);
                do
                {
                    Console.WriteLine("Please Enter The Answer:");
                } while (!Enum.TryParse(answerType, Console.ReadLine(),true, out answer));
                this.questionsAnswers[i + 1] = question.studentAnswer = new Answer((Enum)answer);
                //Console.WriteLine($"your Answer is : {this.questionsAnswers[i + 1]}\n");
                Console.Clear();
            }
            Console.WriteLine($"\n================== {subjectInfo.subjectName} Exam End ==================\n");
            Console.WriteLine($"{"Best Wishes",rightAlignment}\n{"Eng\\",rightAlignment} {subjectInfo.profName}");
        }
    }
}
