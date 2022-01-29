using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    internal class Answer
    {
        //public TypeOfQuestion toq { get; set; }
        public Enum answer { get; set; }


        public Answer(Enum answer)
        {
           this.answer = answer;
        }

        public override string ToString()
        {
            return answer.ToString();
        }

        public static Type CheckQuestionType(Question question)
        {
            if (question != null)
            {
                if (question is TrueOrFalseQuestion)
                {
                    return typeof(TrueOrFalseAnswer);
                }
                else if (question is ChooseOneQuestion)
                {
                    return typeof(ChooseOneAnswer);
                }
                else
                {
                    return typeof(MultibleChooseAnswer);
                }
            }
            else
            {
                return null;
            }
        }
    }
}
