using System;
using System.Diagnostics;

namespace Euler34
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch clock = Stopwatch.StartNew();

            int sum = 0;

            for (int i = 3; i < 3265920; i++) // 9 * (9!) = 3265920;
            {
                string strI = i.ToString();
                int sumI = 0;

                for (int j = 0; j < strI.Length; j++)
                {
                    int i2 = Convert.ToInt32(strI[j] - 48);

                    sumI += Factorial(i2);

                }

                if (sumI == i) { sum += i; Console.WriteLine(i); }
            }

            Console.WriteLine("sum = " + sum);

            clock.Stop();
            Console.WriteLine($"Time elapsed: {clock.ElapsedMilliseconds} ms.");
        }

        static int Factorial(int nr)
        {
            int factorialRezult = 1;
            for (int i = 2; i <= nr; i++)
            {
                factorialRezult *= i;
            }

            return factorialRezult;
        }
    }
}
