using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    internal class QuestionsList
    {
        public int[] questionsNumbers { get; }
        Question[] questions;
        int index;

        public QuestionsList(int numberOfQuestions)
        {
            questionsNumbers = new int[numberOfQuestions];
            questions = new Question[numberOfQuestions];
            index = 0;
        }

        public QuestionsList(int numberOfQuestion, Question[] questions) : this(numberOfQuestion)
        {
            for (int i = 0; i < questions.Length; i++)
            {
                this.questionsNumbers[i] = i + 1;
                this.questions[i] = questions[i];
                index++;
            }
            index++;
        }

        // Work only if number of Question is Greater Than Questions[] Length
        public void AddQuestion(Question question)
        {
            if (question == null)
            {
                Console.WriteLine("Please Enter a True Question");
            }
            else
            {
                if (questions.Length == index)
                {
                    Console.WriteLine("Question List is Full");
                }
                else
                {
                    questionsNumbers[index] = index+1; // bug
                    questions[index] = question;
                    index++;
                }

            }
        }

        public Question this[int questionNumber]
        {
            get
            {
                if (questionNumber == 0)
                {
                    Console.WriteLine($"There is No Question With this Number {questionNumber}");
                    return null;
                }
                else
                {

                    for (int i = 0; i < index; i++)
                    {
                        if (questionsNumbers[i] == questionNumber)
                        {
                            return questions[i];
                        }
                    }
                    Console.WriteLine($"There is No Question with This Number {questionNumber}");
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
                                Console.WriteLine($"Question Number {questionNumber} is Updated!");
                                questions[i] = value;
                            }
                        }
                        Console.WriteLine("New Question Added!");
                        AddQuestion(value);
                    }
                    else
                    {
                        Console.WriteLine("Please Enter a True Question, Value of Question Can not be Null");
                    }

                }
            }
        }
    }
}
