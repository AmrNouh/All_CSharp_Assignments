using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter First Number:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter The Second Number:");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"The Sum of {num1} + {num2} = {num1+num2}");
            Console.WriteLine($"The subtraction of {num1} - {num2} = {num1-num2}");
            Console.WriteLine($"The Multiplication of {num1} * {num2} = {num1*num2}");
        }
    }
}
