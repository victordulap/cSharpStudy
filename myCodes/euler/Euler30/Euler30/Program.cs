using System;
using System.Diagnostics;

namespace Euler30
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch clock = Stopwatch.StartNew();

            int sum = 0;
            for (int i = 2; i < 9*(Math.Pow(9, 5)); i++) //9 cifre  * max cifra la ^5
            {
                string str = i.ToString();
                int sumi = 0;
                for (int j = 0; j < str.Length; j++)
                {
                    sumi += Convert.ToInt32(Math.Pow(str[j] - 48, 5));
                }

                if (sumi == i) { sum += i; Console.WriteLine(i); }
            }

            Console.WriteLine("Sum = " + sum);

            clock.Stop();
            Console.WriteLine("Time  elapsed: " + clock.ElapsedMilliseconds + " ms.");
        }
    }
}
