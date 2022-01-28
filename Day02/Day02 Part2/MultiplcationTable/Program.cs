using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplcationTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            for (int i = 1; i <= arr.Length; i++)
            {
                Console.WriteLine($"The Multiplcation Table of {i}");
                for (int j = 1; j <= arr.Length; j++)
                {
                    Console.WriteLine($"{i} X {j} =  {i*j}");
                }
                Console.WriteLine("_______________________________");
            }
        }
    }
}
