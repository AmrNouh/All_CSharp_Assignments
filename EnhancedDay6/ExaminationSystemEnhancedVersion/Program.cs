using ExaminationSystemEnhancedVersion;

#region Questions
List<Question> questions = new List<Question>();
List<AnswerList> answers = new List<AnswerList>();

TrueOrFalseQuestion question1 = new TrueOrFalseQuestion(1, "Is C# oop Language", 5);
questions.Add(question1);
AnswerList answerList1 = new AnswerList(1);
answerList1.Add(new Answer(1, "True"));
answerList1.Add(new Answer(2, "Fasle"));
answers.Add(answerList1);

TrueOrFalseQuestion question2 = new TrueOrFalseQuestion(2, "Fish Live on Land", 5);
questions.Add(question2);
AnswerList answerList2 = new AnswerList(2);
answerList2.Add(new Answer(1, "True"));
answerList2.Add(new Answer(2, "Fasle"));
answers.Add(answerList2);

TrueOrFalseQuestion question3 = new TrueOrFalseQuestion(3, "Addition of 2 + 5 = 7", 5);
questions.Add(question3);
AnswerList answerList3 = new AnswerList(1);
answerList3.Add(new Answer(1, "True"));
answerList3.Add(new Answer(2, "Fasle"));
answers.Add(answerList3);

TrueOrFalseQuestion question4 = new TrueOrFalseQuestion(4, "Fish Live on water", 5);
questions.Add(question4);
AnswerList answerList4 = new AnswerList(1);
answerList4.Add(new Answer(1, "True"));
answerList4.Add(new Answer(2, "Fasle"));
answers.Add(answerList4);

TrueOrFalseQuestion question5 = new TrueOrFalseQuestion(5, "subtraction of 10 - 2 = 5", 5);
questions.Add(question5);
AnswerList answerList5 = new AnswerList(2);
answerList5.Add(new Answer(1, "True"));
answerList5.Add(new Answer(2, "Fasle"));
answers.Add(answerList5);

SingleChoiceQuestion question6 = new SingleChoiceQuestion(6, "How Many Number of Days in The Week", 10);
questions.Add(question6);
AnswerList answerList6 = new AnswerList(3);
answerList6.Add(new Answer(1, "2 days"));
answerList6.Add(new Answer(2, "3 days"));
answerList6.Add(new Answer(3, "7 days"));
answerList6.Add(new Answer(4, "9 days"));
answerList6.Add(new Answer(5, "8 days"));
answers.Add(answerList6);

SingleChoiceQuestion question7 = new SingleChoiceQuestion(2, "How Many Number of Days in Month", 10);
questions.Add(question7);
AnswerList answerList7 = new AnswerList(2);
answerList7.Add(new Answer(1, "12 days"));
answerList7.Add(new Answer(2, "30 days"));
answerList7.Add(new Answer(3, "25 days"));
answerList7.Add(new Answer(4, "40 days"));
answerList7.Add(new Answer(5, "20 days"));
answers.Add(answerList7);

SingleChoiceQuestion question8 = new SingleChoiceQuestion(2, "How Many Number of Days in year", 10);
questions.Add(question8);
AnswerList answerList8 = new AnswerList(4);
answerList8.Add(new Answer(1, "500 days"));
answerList8.Add(new Answer(2, "600 days"));
answerList8.Add(new Answer(3, "900 days"));
answerList8.Add(new Answer(4, "365 days"));
answerList8.Add(new Answer(5, "1000 days"));
answers.Add(answerList8);
SingleChoiceQuestion question9 = new SingleChoiceQuestion(2, "division of 25 / 5 equal", 10);
questions.Add(question9);
AnswerList answerList9 = new AnswerList(5);
answerList9.Add(new Answer(1, "10 days"));
answerList9.Add(new Answer(2, "3 days"));
answerList9.Add(new Answer(3, "15 days"));
answerList9.Add(new Answer(4, "4 days"));
answerList9.Add(new Answer(5, "5 days"));
answers.Add(answerList9);
SingleChoiceQuestion question10 = new SingleChoiceQuestion(2, "addition of 100 + 900", 10);
questions.Add(question10);
AnswerList answerList10 = new AnswerList(5);
answerList10.Add(new Answer(1, "500 days"));
answerList10.Add(new Answer(2, "600 days"));
answerList10.Add(new Answer(3, "900 days"));
answerList10.Add(new Answer(4, "365 days"));
answerList10.Add(new Answer(5, "1000 days"));
answers.Add(answerList10);
#endregion

#region Main
int choice = 0;
Subject subject;
Student student;
int examTime = 0;
int numberOfQuestion = 0;
Dictionary<Question, AnswerList> examQuestions = new Dictionary<Question, AnswerList>();
do
{
    Console.WriteLine("Please Select Exam Type:\n 1) Practice Exam\n 2) Final Exam\n");
    Console.Write("\tYour Choice: ");
} while (!int.TryParse(Console.ReadLine(), out choice));

switch (choice)
{
    case 1:
        PracticeExam practiceExam;
        subject = new Subject();
        student = new Student();
        Subject.TakeSubjectInfo(subject);
        Exam.CreateExam(out examTime, out numberOfQuestion);
        for (int i = 0; i < numberOfQuestion; i++)
        {
            examQuestions[questions[i]] = answers[i];
        }
        Student.TakeStudentData(student);
        practiceExam = new PracticeExam(examTime, numberOfQuestion, examQuestions, subject, student);
        Console.WriteLine($"{student.Name}, Are you ready for Starting Exam ? (Y/N)");
        if (Console.Read() == (int)ConsoleKey.Y)
        {
            Exam.CalculateExamFullMark(practiceExam);
            Exam.ShowExamHeader(practiceExam);
            practiceExam.StartExam(student);
            practiceExam.CorrectExam(student.examAnswers, examQuestions);
            practiceExam.ShowExam();

        }
        break;
    case 2:
        FinalExam finalExam;
        subject = new Subject();
        student = new Student();
        Subject.TakeSubjectInfo(subject);
        Exam.CreateExam(out examTime, out numberOfQuestion);
        for (int i = 0; i < numberOfQuestion; i++)
        {
            examQuestions[questions[i]] = answers[i];
        }
        Student.TakeStudentData(student);
        finalExam = new FinalExam(examTime, numberOfQuestion, examQuestions, subject, student);
        Console.WriteLine($"{student.Name}, Are you ready for Starting Exam ? (Y/N)");
        if (Console.Read() == (int)ConsoleKey.Y)
        {
            Exam.CalculateExamFullMark(finalExam);
            Exam.ShowExamHeader(finalExam);
            finalExam.StartExam(student);
            finalExam.CorrectExam(student.examAnswers, examQuestions);
            finalExam.ShowExam();

        }
        break;
    default:
        Console.WriteLine("Please Enter a vaild Number");
        break;
}
#endregion
