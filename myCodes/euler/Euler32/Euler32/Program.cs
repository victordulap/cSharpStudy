using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Euler32
{
    class Program
    {
        static void Main()
        {
            Stopwatch clock = Stopwatch.StartNew();

            //long sum = 0;
            List<int> nums = new List<int>();
            for (int a = 1; a < 99999; a++)
            {
                // b = a to remove repetitives
                for (int b = 1; b < a; b++) // == for (int b = a; b < 99999; b++)
                {
                    int prod = a * b;
                    string str = a.ToString() + b.ToString() + (prod).ToString();

                    if (str.Length > 9) break;

                    //Console.WriteLine($"a: {a}, b: {b}, lenght: {str.Length}");

                    if (str.Length == 9)
                        if (IsPandigital(str))
                        {
                            //sum += prod;
                            nums.Add(prod);
                            Console.WriteLine($"a: {a}, b: {b}, a * b: {prod}");
                        }
                }
            }

            nums = nums.Distinct().ToList();
            Console.WriteLine("sum = " + nums.Sum());

            clock.Stop();
            Console.WriteLine("Time: " + clock.ElapsedMilliseconds + " ms.");
        }

        static bool IsPandigital(string nr)
        {
            if (nr.Contains('0')) return false;

            for (int i = 1; i <= nr.Length; i++)
            {
                int sumOfNChar = 0;
                for (int j = 0; j < nr.Length; j++)
                {
                    if (nr[j] == (i + 48)) sumOfNChar++;
                }

                if (sumOfNChar != 1) return false;
            }

            return true;
        }
    }
}
