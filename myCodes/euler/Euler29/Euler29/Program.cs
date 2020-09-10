using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Euler29
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch clock = Stopwatch.StartNew();

            List<string> nrs = new List<string>();

            for(int a = 2; a <= 100; a++)
            {
                for (int b = 2; b <= 100; b++)
                {
                    nrs.Add(Convert.ToString(Math.Pow(a, b)));
                }
            }

            nrs = nrs.Distinct().ToList(); //without 9801, with 9183

            Console.WriteLine(nrs.Count);

            clock.Stop();
            Console.WriteLine($"Elapsed time: {clock.ElapsedMilliseconds} ms.");
        }
    }
}
