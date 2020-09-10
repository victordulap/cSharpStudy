using System;
using System.Diagnostics;
using System.Numerics;

namespace Euler25
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch clock = Stopwatch.StartNew();

            BigInteger nr1 = 1;
            BigInteger nr2 = 1;
            BigInteger nr = 0;
            int index = 2;
            while (true)
            {
                nr = nr1 + nr2;
                nr1 = nr2;
                nr2 = nr;
                index++;
                Console.WriteLine(index + ". " + nr);

                if (nr.ToString().Length == 1000)
                {
                    Console.WriteLine("Result: " + index);
                    break;
                }
            }

            clock.Stop();
            Console.WriteLine("Solution took {0} ms", clock.ElapsedMilliseconds);
        }
    }
}
