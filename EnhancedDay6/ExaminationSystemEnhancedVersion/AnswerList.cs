namespace ExaminationSystemEnhancedVersion
{
    internal class AnswerList:List<Answer>
    {
        public int numberOfCorrectAnswer { get; set; }

        public AnswerList(int numberOfCorrectAnswer)
        {
            this.numberOfCorrectAnswer = numberOfCorrectAnswer;
        }
    }

}
