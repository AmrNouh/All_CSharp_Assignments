using ExaminationSystem;

int choice;
TimeSpan examTime = TimeSpan.Zero;
Subject subjectInfo = new Subject();
int numberOfQuestion = 25;
do
{
    Console.WriteLine("Please Select Type of Exam: \n1)Practice Exam\t\t\t2)Final Exam");
} while (!int.TryParse(Console.ReadLine(), out choice));

switch (choice)
{
    case 1:
        PracticeExam practicalExam;
        Exam.CreateExam(examTime,subjectInfo,numberOfQuestion);
        QuestionsList examQuestions = new QuestionsList(numberOfQuestion);
        //examQuestions.AddQuestion(new TrueOrFalseQuestion());

        break;
        case 2:
        break;
    default:
        Console.WriteLine("Please Try Again and Enter a valid Number");
        break;
}