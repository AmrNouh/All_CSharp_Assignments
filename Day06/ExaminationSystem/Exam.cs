using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    abstract internal class Exam
    {
        public TimeSpan examTime { get; set; }
        public Subject subjectInfo { get; set; }
        public Student studentInfo { get; set; }
        public int numberOfQuestions { get; set; }
        public QuestionsList examQuestions { get; set; }
        public AnswersList questionsAnswers { get; set; }

        public Exam()
        {
            this.examTime = TimeSpan.Zero;
            this.subjectInfo = new Subject();
            this.studentInfo = new Student();
            this.numberOfQuestions = 25;
            this.examQuestions = new QuestionsList(numberOfQuestions);
            this.questionsAnswers = new AnswersList(numberOfQuestions);


        }
        public Exam(TimeSpan examTime, Subject subjectInfo, Student studentInfo, int numberOfQuestion, QuestionsList questions, AnswersList answers)
        {
            this.examTime = examTime;
            this.subjectInfo = subjectInfo;
            this.studentInfo = studentInfo;
            this.numberOfQuestions = numberOfQuestion;
            this.examQuestions = questions;
            this.questionsAnswers = answers;
        }

        protected abstract void ShowExam();

        public static void CreateExam(TimeSpan examTime, Subject subjectInfo, int numberOfQuestion)
        {
            do
            {
                Console.Clear();
                Console.WriteLine("Please Enter Exam Time in Format HH:MM");
            } while (TimeSpan.TryParse(Console.ReadLine(),out examTime));
            do
            {
                Console.Clear();
                Console.WriteLine("Please Enter Subject Name:");
                subjectInfo.subjectName = Console.ReadLine();
            } while (!string.IsNullOrWhiteSpace(subjectInfo.subjectName) && subjectInfo.subjectName.Length <= 3);
            do
            {
                Console.Clear();
                Console.WriteLine("Please Enter Professor Name:");
                subjectInfo.profName = Console.ReadLine();
            } while (!string.IsNullOrWhiteSpace(subjectInfo.profName) && subjectInfo.profName.Length <= 3);
            do
            {
                Console.Clear();
                Console.WriteLine("Please Enter Department Name:");
                subjectInfo.departmentName = Console.ReadLine();
            } while (!string.IsNullOrWhiteSpace(subjectInfo.departmentName) && subjectInfo.departmentName.Length <= 3);
            do
            {
                Console.Clear();
                Console.WriteLine("Please Enter Organization Name:");
                subjectInfo.organizationName = Console.ReadLine();
            } while (!string.IsNullOrWhiteSpace(subjectInfo.organizationName) && subjectInfo.organizationName.Length <= 3);
            do
            {
                Console.Clear();
                Console.WriteLine("Please Enter Number of Question in Exam");
            } while (!int.TryParse(Console.ReadLine(),out numberOfQuestion));

        }

    }
}
