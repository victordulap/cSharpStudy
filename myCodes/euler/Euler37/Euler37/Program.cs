using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Euler37
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch clock = Stopwatch.StartNew();

            int count = 0; // max 11
            int sum = 0;

            int i = 8;
            while (true)
            {

                if (i.ToString().Contains('0'))
                {
                    i++;
                    continue;
                }

                if (Prime(i))
                {
                    int fakeILeftToRight = i;
                    int fakeIRightToLeft = i;

                    while (true)
                    {
                        if (((fakeILeftToRight.ToString().Length - 1) == 0) || ((fakeIRightToLeft.ToString().Length - 1) == 0))
                        {
                            if (Prime(fakeILeftToRight) && Prime(fakeIRightToLeft))
                            {
                                count++;
                                sum += i;

                                Console.WriteLine(i);
                            }

                            break;
                        }
                        else
                        {
                            fakeILeftToRight = TruncateLeftToRight(fakeILeftToRight);
                            fakeIRightToLeft = TruncateRightToLeft(fakeIRightToLeft);


                            if (!(Prime(fakeILeftToRight) && Prime(fakeIRightToLeft)))
                            {
                                break;
                            }
                        }
                    }
                }

                if (count == 11) break;

                i++;
            }

            Console.WriteLine("sum = " + sum);

            clock.Stop();
            Console.WriteLine($"Time {clock.ElapsedMilliseconds} ms.");
        }

        static bool Prime(int nr)
        {
            if (nr <= 1) return false;
            else if (nr <= 3) return true;

            for (int i = 2; i * i <= nr; i++)
            {
                if (nr % i == 0)
                    return false;
            }

            return true;
        }

        static int TruncateLeftToRight(int nr)
        {
            List<char> nrs = new List<char>(nr.ToString());
            if ((nrs.Count) > 1)
                nrs.RemoveAt(0);

            string str = new string(nrs.ToArray());

            nr = Convert.ToInt32(str.ToString());

            return nr;
        }
        static int TruncateRightToLeft(int nr)
        {
            List<char> nrs = new List<char>(nr.ToString());
            if ((nrs.Count) > 1)
                nrs.RemoveAt(nrs.Count - 1);


            string str = new string(nrs.ToArray());

            nr = Convert.ToInt32(str.ToString());

            return nr;
        }
    }
}
