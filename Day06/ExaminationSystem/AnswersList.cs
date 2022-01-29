using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    internal class AnswersList
    {
        public int[] questionsNumbers { get; }
        Answer[] answers;
        int index;

        public AnswersList(int numberOfQuestions)
        {
            questionsNumbers = new int[numberOfQuestions];
            answers = new Answer[numberOfQuestions];
            index = 0;
        }

        public AnswersList(int numberOfQuestion, Answer[] answers) : this(numberOfQuestion)
        {
            for (int i = 0; i < answers.Length; i++)
            {
                this.questionsNumbers[i] = i + 1;
                this.answers[i] = answers[i];
                index++;
            }
            index++;
        }

        // Work only if number of Question is Greater Than Answer[] Length
        public void AddAnswer(Answer answer)
        {
            if (answer == null)
            {
                Console.WriteLine("Please Enter a True Question");
            }
            else
            {
                if (answers.Length == index)
                {
                    Console.WriteLine("Question List is Full");
                }
                else
                {
                    questionsNumbers[index] = index+1;
                    answers[index] = answer;
                    index++;
                }

            }
        }

        public Answer this[int questionNumber]
        {
            get
            {
                if (questionNumber == 0)
                {
                    Console.WriteLine($"There is No Answer For this Question Number {questionNumber}");
                    return null;
                }
                else
                {

                    for (int i = 0; i <= index; i++)
                    {
                        if (questionsNumbers[i] == questionNumber)
                        {
                            return answers[i];
                        }
                    }
                    Console.WriteLine($"There is No Answer For this Question Number {questionNumber}");
                    return null;
                }

            }

            set
            {
                if (questionNumber == 0)
                {
                    throw new ArgumentOutOfRangeException($"Out of Range Quetion Number {questionNumber}, Question Number Must be Greater Than 1");
                }
                else
                {
                    if (value != null)
                    {
                        for (int i = 0; i < index; i++)
                        {
                            if (questionsNumbers[i] == questionNumber)
                            {
                                //Console.WriteLine($"Answer for Question Number {questionNumber} is Updated!");
                                answers[i] = value;
                            }
                        }
                        //Console.WriteLine("New Answer Added!");
                        AddAnswer(value);
                    }
                    else
                    {
                        Console.WriteLine("Please Enter a True Answer, Value of Answer Can not be Null");
                    }

                }
            }
        }
    }
}
