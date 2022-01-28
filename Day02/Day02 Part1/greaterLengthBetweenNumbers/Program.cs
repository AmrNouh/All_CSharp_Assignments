using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace greaterLengthBetweenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter The Size of Array:");
            int sizeOfArray = int.Parse(Console.ReadLine());

            int[] numberArray = new int[sizeOfArray];
            for (int i = 0; i < numberArray.Length;i++)
            {
                Console.WriteLine($"Please Enter Value at index {i+1}");
                numberArray[i] = int.Parse(Console.ReadLine());
            }

            // compute large Length
            int distance = 0;
            int LongestDistance = 0;
            for (int i = 0; i < numberArray.Length; i++)
            {
                for (int j = 1; j < numberArray.Length; j++)
                {
                    if (numberArray[i] == numberArray[j])
                    {
                        distance = (j - i) - 1;

                        if (LongestDistance < distance)
                        {
                            LongestDistance = distance;
                        }
                    }
                }
            }
            Console.WriteLine($"large Length = {LongestDistance}");
        }
    }
}
