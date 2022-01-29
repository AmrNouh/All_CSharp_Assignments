using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    abstract internal class Exam
    {
        protected const int leftAlignment = -7;
        protected const int rightAlignment = 40;
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

        public abstract void ShowExam();
        public abstract void PrintExam();
        public abstract double Correct(QuestionsList examQuestions, AnswersList studentAnswers);

        public static void CreateExam(TimeSpan examTime, Subject subjectInfo, int numberOfQuestion)
        {
            double fullMark;
            do
            {
                Console.Clear();
                Console.WriteLine("Please Enter Exam Time in Format HH:MM");
            } while (!TimeSpan.TryParse(Console.ReadLine(),out examTime));
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
            } while (!string.IsNullOrWhiteSpace(subjectInfo.profName) && subjectInfo.profName.Length <= 2);
            do
            {
                Console.Clear();
                Console.WriteLine("Please Enter Exam Full Mark");
            } while (!double.TryParse(Console.ReadLine(), out fullMark));
            subjectInfo.fullMark = fullMark;

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

            Console.Clear();
        }

        public static void PrintExamHeader(Exam exam)
        {
            Console.WriteLine($"{exam.subjectInfo}\t\t\t\t{"Exam Time:",rightAlignment} {exam.examTime.ToString()}\n");
            Console.WriteLine($"\t\t\t================== {exam.subjectInfo.subjectName} Exam ==================");
            Console.WriteLine($"{exam.studentInfo}");
        }
        public static void TakeStudentData(Student student)
        {
            do
            {
                Console.WriteLine("Please Enter Your Name:");
                student.Name = Console.ReadLine();
            } while (!string.IsNullOrWhiteSpace(student.Name) && student.Name.Length <= 2);
            do
            {
                Console.WriteLine("Please Enter Your Department:");
                student.department = Console.ReadLine();
            } while (!string.IsNullOrWhiteSpace(student.department) && student.department.Length <= 2);

            Console.Clear();
        }

    }
}
