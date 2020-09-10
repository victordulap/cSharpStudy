using System;
using System.Diagnostics;

namespace Euler28
{
    class Program
    {
        static void Main()
        {
            Stopwatch clock = Stopwatch.StartNew();

            int gridN = 1001;
            long sum = 0;
            int k = 0, plus = 2, i = 1;
            while (i <= Math.Pow(gridN,2))
            {
                sum += i;

                i += plus;
                k++;
                if (k % 4 == 0)
                {
                    plus += 2;
                }
            }
            Console.WriteLine($"Sum: {sum}");
            clock.Stop();
            Console.WriteLine($"Elapsed time: {clock.ElapsedMilliseconds} ms.");
        }
    }
}
