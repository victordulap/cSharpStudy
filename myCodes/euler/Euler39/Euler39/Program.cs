using System;
using System.Diagnostics;

namespace Euler39
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch clock = Stopwatch.StartNew();

            int maxPerimeter = 0;
            int maxPerimeterSolutions = 0;


            for (int perimeter = 3; perimeter <= 1000; perimeter++)
            {
                int currentPerimeterSolutions = FindSolutions(perimeter);
                if (currentPerimeterSolutions > maxPerimeterSolutions)
                {
                    maxPerimeterSolutions = currentPerimeterSolutions;
                    maxPerimeter = perimeter;
                }
            }

            Console.WriteLine(maxPerimeter + ", solutions: " + maxPerimeterSolutions);

            clock.Stop();
            Console.WriteLine($"Time {clock.ElapsedMilliseconds} ms.");
        }

        static int FindSolutions(int perimeter)
        {
            int solutions = 0;

            for (int a = 1; a < perimeter; a++)
            {
                for (int b = 1; b < a; b++)
                {
                    double c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));

                    if ((a + b + c) == perimeter)
                    {
                        //Console.WriteLine($"a: {a}, b: {b}, c: {c}");
                        solutions++;
                    }
                }
            }

            return solutions;
        }
    }
}
