using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace CountOfDigitOneInNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopWatch = new Stopwatch(); 
            ulong length;
            checked
            {
                length = 99999999;
            }
            //int count = 0;
            //stopWatch.Start();
            //for (ulong i = 0; i < length; i++)
            //{
            //    count += i.ToString().Count(f => (f == '1'));

            //}
            //stopWatch.Stop();
            //Console.WriteLine($"count = {count}");
            //Console.WriteLine($"Time Elased equal= {stopWatch.Elapsed}");


            // another Way
            ulong counter = 0;
            stopWatch.Start();
            counter = (length / 10 + 1) * (ulong)(length.ToString().Length);
            stopWatch.Stop();
            Console.WriteLine($"count = {counter}");
            Console.WriteLine($"Time Elased equal= {stopWatch.Elapsed}");
        }
    }
}
