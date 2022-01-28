using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGrades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Studet Degree:");
            int degree = int.Parse(Console.ReadLine());

            if (degree <= 100 && degree >= 80)
            {
                Console.WriteLine("You Got Grade A");
            } 
            else if (degree < 80 && degree >= 70)
            {
                Console.WriteLine("You Got Grade B");
            } 
            else if (degree < 70 && degree >= 60)
            {
                Console.WriteLine("You Got Grade C");

            } 
            else if (degree < 60 && degree >= 50)
            {
                Console.WriteLine("You Got Grade D");
            }
            else if (degree < 50)
            {
                Console.WriteLine("You Got Grade F");
            }else
            {
                Console.WriteLine("Please Enter a Valid Number");
            }
        }
    }
}
