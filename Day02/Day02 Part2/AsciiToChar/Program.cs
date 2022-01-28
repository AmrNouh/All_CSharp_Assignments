using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsciiToChar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Number To Convert To Ascii");
            short num = short.Parse(Console.ReadLine());
            Console.WriteLine($"The Char is {(char)num}");
        }
    }
}
