using System;
using System.Diagnostics;

namespace Euler43
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch clock = Stopwatch.StartNew();

            long sum = 0;

            int[] listOfPrimeNrs = new int[] { 2, 3, 5, 7, 11, 13, 17 };

            for (long i = 1023456789; i < 9876543210; i++)
            {
                string iToString = i.ToString();

                //Console.WriteLine($"{iToString} ----------------");

                bool addSum = true;
                bool toSkip = false;

                //clock.Reset();
                //clock.Start();
                for (int j = 0; j < iToString.Length - 1; j++)
                {
                    if (iToString[j] == iToString[j + 1])
                    {
                        i += (int)(Math.Pow(10, iToString.Length - 2 - j)) - 1;
                        toSkip = true;
                    }
                }
                //clock.Stop();
                //Console.WriteLine("skip iterations: " + clock.ElapsedTicks + " ticks.");

                if (toSkip) continue;

                //clock.Reset();
                //clock.Start();
                if (!IsPandigitalFrom0to9(iToString))
                {
                    continue;
                }
                //clock.Stop();
                //Console.WriteLine("is pandigital: " + clock.ElapsedTicks + " ticks.");




                //clock.Reset();
                //clock.Start();
                for (int j = 0; j < 7; j++)
                {
                    int subString = Convert.ToInt32(iToString.Substring(j + 1, 3));
                    if (subString % listOfPrimeNrs[j] != 0)
                    {
                        addSum = false;
                        break;
                    }
                }

                if (addSum) sum += i;

                //clock.Stop();
                //Console.WriteLine("division: " + clock.ElapsedTicks + " ticks.");

                //Console.ReadKey();
            }

            Console.WriteLine(sum);

            clock.Stop();
            Console.WriteLine($"Time: {clock.ElapsedMilliseconds} ms.");
        }

        static bool IsPandigitalFrom0to9(string nr)
        {
            for (int i = 0; i <= 9; i++)
            {
                if (!CheckIfCharUnique((char)(i + 48), nr)) return false;
            }

            return true;
        }

        static bool CheckIfCharUnique(char characterToCheck, string fromString)
        {
            int count = 0;

            for (int i = 0; i < fromString.Length; i++)
            {
                if (fromString[i] == characterToCheck)
                {
                    count++;
                    if (count > 1) return false;
                }
            }

            if (count == 1)
                return true;
            else
                return false;
        }
    }
}
