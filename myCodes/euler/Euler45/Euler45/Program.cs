using System;
using System.Diagnostics;

namespace Euler45
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch clock = Stopwatch.StartNew();

            //works
            //Console.WriteLine(IsTriangle(40755));
            //Console.WriteLine(IsPentagonal(40755));
            //Console.WriteLine(IsHexagonal(40755));

            //for (int i = 1; i <= 5; i++)
            //{
            //    int tr = (i * (i + 1)) / 2;
            //    int pt = i * (3 * i - 1) / 2;
            //    int hg = i * (2 * i - 1);

            //    Console.WriteLine($"{tr} | {pt} | {hg}");
            //}

            // find next after 40755;

            long i = 285; //T285
            bool resultFound = false;
            long iToTriangle = 0;
            while (!resultFound)
            {
                i++;

                iToTriangle = (i * (i + 1)) / 2;

                if (IsPentagonal(iToTriangle) && IsHexagonal(iToTriangle))
                {
                    resultFound = true;
                }
            }

            Console.WriteLine(i + " / " + iToTriangle);

            clock.Stop();
            Console.WriteLine($"Time: {clock.ElapsedMilliseconds} ms.");
        }

        static bool IsTriangle(long number)
        {
            double nr = (Math.Sqrt((8 * number) + 1) - 1) / 2.0;
            return nr == ((int)nr);
        }

        static bool IsPentagonal(long number)
        {
            double nr = (Math.Sqrt(1 + 24 * number) + 1.0) / 6.0;
            return nr == ((int)nr);
        }

        static bool IsHexagonal(long number)
        {
            double nr = (Math.Sqrt((8 * number) + 1) + 1) / 4.0;
            return nr == ((int)nr);
        }
    }
}
