using System;
using System.Diagnostics;

namespace Euler27
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch clock = Stopwatch.StartNew();

            int Coeficent = 0, maxConsecutivePrimes = -1, n = 0, maxa = 0, maxb = 0;
            for (int a = -999; a <= 999; a++)
            {
                for (int b = -1000; b <= 1000; b++)
                {
                    n = 0;
                    while (true)
                    {
                        if (!Prime((n * n) + (a * n) + (b))) break;

                        n++;
                    }
                    //Console.WriteLine($"Consecutive from 0 to {n - 1} (a: {a}, b: {b})");
                    //Console.WriteLine($"maxConsecutivePrimes: {maxConsecutivePrimes}, Coeficent:{Coeficent}");
                    if (maxConsecutivePrimes < n) { maxConsecutivePrimes = n; Coeficent = a * b; maxa = a; maxb = b; }
                }
            }

            #region comment
            //int n = 0;
            //while (true)
            //{
            //    if (!Prime((n * n) + (-79 * n) + (1601))) break;

            //    n++;
            //}

            //Console.WriteLine("Consecutive from 0 to {0}", n - 1);
            #endregion

            Console.WriteLine($"maxConsecutivePrimes: {maxConsecutivePrimes}, Coeficent:{Coeficent} ({maxa} * {maxb})");

            clock.Stop();
            Console.WriteLine($"Time elapsed: {clock.ElapsedMilliseconds} ms.");
        }

        static bool Prime(int nr)
        {
            for (int i = 2; i <= Math.Sqrt(nr) /*nr / 2*/; i++)
            {
                if (nr % i == 0) return false;
            }

            if (nr < 2) return false;

            return true;
        }
    }
}
