using ExaminationSystem;

int choice;
TimeSpan examTime = TimeSpan.Zero;
Subject subjectInfo = new Subject();
//Console.WriteLine(subjectInfo);

Student stuednetInfo = new ();
//Console.WriteLine(stuednetInfo);

int numberOfQuestion = 6;

string multibleChooseBody = "How Many Days Are There in a week?\n\ta) 7 days\n\tb) 8 days\n\tc) seven days\n\td) All of The Above\n";

string singleChooseBody = "How Many Days Are There in a week?\n\ta) 7 days\n\tb) 8 days\n\tc) 2 days\n\td) None of The Above\n";

object solution;
Enum.TryParse(typeof(MultibleChooseAnswer), "a, c", out solution);

do
{
    Console.WriteLine("Please Select Type of Exam: \n1)Practice Exam\t\t\t2)Final Exam");
    Console.WriteLine("Your Choice >> ");
} while (!int.TryParse(Console.ReadLine(), out choice));

switch (choice)
{
    case 1:
        PracticeExam practicalExam;

        Exam.CreateExam(examTime,subjectInfo,numberOfQuestion);

        QuestionsList examQuestions = new QuestionsList(numberOfQuestion);
        AnswersList studentAnswers = new AnswersList(numberOfQuestion);

        examQuestions.AddQuestion(new TrueOrFalseQuestion(5, "Fish Live on Water", new Answer(TrueOrFalseAnswer.True)));

        examQuestions.AddQuestion(new TrueOrFalseQuestion(5, "Fish Live on Land", new Answer(TrueOrFalseAnswer.False)));

        examQuestions.AddQuestion(new TrueOrFalseQuestion(5, "Fish eat Meat", new Answer(TrueOrFalseAnswer.False)));

        examQuestions.AddQuestion(new TrueOrFalseQuestion(5, "Fish Live on Water", new Answer(TrueOrFalseAnswer.True)));

        //new Answer(ChooseOneAnswer.a) // answer
        examQuestions.AddQuestion(new ChooseOneQuestion(5, singleChooseBody, new Answer(ChooseOneAnswer.a)));
        //Console.WriteLine(examQuestions[5]);

        // new Answer((MultibleChooseAnswer)solution) // answer
        examQuestions.AddQuestion(new MultibleChooseQuestion(5, multibleChooseBody, new Answer(ChooseOneAnswer.a)));
        //Console.WriteLine(examQuestions[6]);

        Exam.TakeStudentData(stuednetInfo);

        practicalExam = new PracticeExam(examTime, subjectInfo,stuednetInfo, numberOfQuestion, examQuestions, studentAnswers);

        Exam.PrintExamHeader(practicalExam);

        practicalExam.ShowExam();

        practicalExam.PrintExam();
        break;
    case 2:
        break;
    default:
        Console.WriteLine("Please Try Again and Enter a valid Number");
        break;
}