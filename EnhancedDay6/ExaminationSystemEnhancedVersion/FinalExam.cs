namespace ExaminationSystemEnhancedVersion
{
    internal class FinalExam : Exam
    {
        public FinalExam(int time, int numberOfQuestion, Dictionary<Question, AnswerList> examQuestions, Subject subject, Student subjectInfo) : base(time, numberOfQuestion, examQuestions, subject, subjectInfo)
        {
        }
        public override void ShowExam()
        {
            Console.Clear();
            this.CenterText($"================ Your {subjectInfo.subjectName} Exam Results ================");
            foreach (KeyValuePair<Question, AnswerList> item in examQuestions)
            {
                int index = 0;
                Console.WriteLine($"{item.Key}");
                foreach (Answer ans in item.Value)
                {
                    Console.WriteLine($"{ans}\n");
                }
                Console.WriteLine($"your Answer is: {studentInfo.examAnswers[index]}");
                index++;
                this.CenterText("\n==============================================\n");
            }
            this.CenterText($"Your Exam Grade: \n{studentInfo}");
        }
        public override void PrintExam()
        {
            throw new NotImplementedException();
        }


    }
}
