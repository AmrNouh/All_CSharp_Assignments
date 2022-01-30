using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystemEnhancedVersion
{
    abstract internal class Exam
    {
        protected const int leftAlignment = -7;
        protected const int rightAlignment = 40;

        protected int fullMark;
        public int examTime { get; set; }
        public Subject subjectInfo { get; set; }
        public Student studentInfo { get; set; }
        public int numberOfQuestions { get; set; }
        public Dictionary<Question, AnswerList> examQuestions { get; set; }


        public Exam(int time, int numberOfQuestions, Dictionary<Question, AnswerList> examQuestions, Subject subject,Student subjectInfo)
        {
            this.examTime = time;
            this.numberOfQuestions = numberOfQuestions;
            this.examQuestions = examQuestions;
            this.subjectInfo = subject;
            this.studentInfo = subjectInfo;
        }
        public static void CreateExam( out int examTime, out int numberOfQuestion)
        {
            do
            {
                Console.Clear();
                Console.WriteLine("Please Enter Exam Time in Format HH:MM");
            } while (!int.TryParse(Console.ReadLine(), out examTime));

            do
            {
                Console.Clear();
                Console.WriteLine("Please Enter Number of Question in Exam");
            } while (!int.TryParse(Console.ReadLine(), out numberOfQuestion));

            Console.Clear();
        }
        public static void CalculateExamFullMark(Exam exam)
        {
            foreach (KeyValuePair<Question, AnswerList> question in exam.examQuestions)
            {
                exam.fullMark += question.Key.mark;
            }
        }
        public static void ShowExamHeader(Exam exam)
        {
            Console.Clear();
            Console.WriteLine($"\n{exam}");
            exam.CenterText($"============ {exam.subjectInfo.subjectName} Exam ============");
            Console.WriteLine($"{exam.studentInfo}");
        }
        public void StartExam(Student student)
        {
            int choice;
            int number = 1;
            foreach (KeyValuePair<Question, AnswerList> item in examQuestions)
            {
                Console.WriteLine("\n===========================================\n");

                Console.WriteLine($"Question {number++} of {this.numberOfQuestions}");

                Console.WriteLine("\n===========================================\n");

                Console.WriteLine(item.Key);

                foreach (Answer ans in item.Value)
                {
                    Console.WriteLine($"{ans}\n");
                }

                Console.WriteLine("===========================================");

                do
                {
                    Console.Write("  -> Please Enter Answer:  ");
                } while (!int.TryParse(Console.ReadLine(), out choice));

                student.examAnswers.Add(choice);
                Console.Clear();

            }
            this.CenterText("Good Luck!");
            this.CenterText($"Eng\\ {subjectInfo.profName}");
        }
        public void CorrectExam(List<int> studentAnswers, Dictionary<Question, AnswerList> examQuestions)
        {
            foreach (KeyValuePair<Question, AnswerList> question in examQuestions)
            {
                foreach (int answer in studentAnswers)
                {
                    if (answer == question.Value.numberOfCorrectAnswer)
                    {
                        studentInfo.grade += question.Key.mark;
                    }

                }
            }
        }

        public abstract void ShowExam();
        public abstract void PrintExam();

        protected void CenterText(string text)
        {
            Console.Write(new string(' ', (Console.WindowWidth - text.Length) / 2));
            Console.WriteLine(text);
        }

        public override string ToString()
        {
            return $"  {subjectInfo}\n  Exam Time: {examTime} Hours\n  Full Mark: {fullMark} Marks";
        }

    }
}
