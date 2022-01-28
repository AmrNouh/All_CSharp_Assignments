using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter stetment to reverse");
            string[] arr = Console.ReadLine().Split(' ');
            for (int i = arr.Length-1; i >= 0; i--)
            {
                Console.Write(arr[i] + " ");  
            }
            Console.WriteLine();
        }
    }
}
