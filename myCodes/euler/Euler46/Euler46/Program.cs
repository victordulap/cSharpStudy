using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Euler46
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch clock = Stopwatch.StartNew();

            int i = 9;
            bool isOddComposite = true;

            List<int> primes = new List<int>();

            int lastPrimeN = 100000;
            for (int j = 2; j < lastPrimeN; j++)
            {
                if (isPrime(j)) primes.Add(j);
            }

            while (isOddComposite)
            {
                //if(primes[primes.Count - 1] < i)
                //{

                //}

                bool isCurrentComposite = false;
                if(isPrime(i))
                {
                    i += 2;
                    continue;
                }

                for (int j = 0; j <= primes.FindLastIndex(n => n < i); j++)
                {
                    //9 = 7 + 2×12
                    int currentPrime = primes[j];
                    for (int k = 0; k <= (i - currentPrime); k++)
                    {
                        if (i == (currentPrime + (2 * (k * k))))
                        {
                            //Console.WriteLine($"{i} = {currentPrime} + 2*{k}^2");
                            isCurrentComposite = true;
                            break;
                        }
                    }
                    if (isCurrentComposite) break;
                }


                if (!isCurrentComposite)
                {   
                    isOddComposite = false;
                    Console.WriteLine("Result: " + i);
                }

                i += 2;
            }

            clock.Stop();
            Console.WriteLine($"Ellapsed time: {clock.ElapsedMilliseconds} ms.");
        }

        static bool isPrime(long nr)
        {
            if (nr <= 1) { return false; }
            else if (nr == 2 || nr == 3) { return true; }

            for (int i = 2; i * i <= nr; i++)
            {
                if (nr % i == 0) { return false; }
            }

            return true;
        }
    }
}
