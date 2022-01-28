using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharToAscii
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter character to convert to Ascii: ");
            ConsoleKeyInfo ch = Console.ReadKey();
            Console.WriteLine($"\nThe Ascii Value is: {(int)ch.KeyChar}");
        }
    }
}
