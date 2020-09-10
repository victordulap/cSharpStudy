using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Euler35
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch clock = Stopwatch.StartNew();

            int count = 0;
            for (int i = 2; i < 1000000; i++)
            {
                if (Prime(i))
                {
                    if (RotationsPrime(i))
                    {
                        count++;
                        Console.WriteLine(i);
                    }
                }
                //Console.WriteLine("i: " + i);
            }

            Console.WriteLine(count);

            clock.Stop();
            Console.WriteLine($"Elapsed time: {clock.ElapsedMilliseconds} ms.");
        }

        static bool Prime(int nr)
        {
            if (nr <= 1) return false;
            if (nr <= 3) return true;

            for (int i = 2; i * i <= nr; i++) // saw on internet that i*i <= nr is faster than i <= Math.Sqrt(nr)
            {
                if (nr % i == 0) return false;
            }

            return true;
        }

        static List<int> Rotations(int nr)
        {
            List<int> rezult = new List<int>();

            string str = nr.ToString();

            if (str.Contains('0')) { rezult.Add(0); return rezult; }

            int len = nr.ToString().Length;

            rezult.Add(nr);


            for (int i = 0; i < len - 1; i++)
            {
                char[] nrToAdd = new char[str.Length];
                string s = rezult[i].ToString();
                for (int j = 0; j < len; j++)
                {
                    int poz = j;
                    if ((poz + (len - 1)) > (len - 1))
                    {
                        poz += len - 1 - len;
                    }
                    else
                    {
                        poz += (len - 1);
                    }

                    nrToAdd[j] = s[poz];
                }

                s = new string(nrToAdd);
                rezult.Add(Convert.ToInt32(s));
            }

            return rezult;
        }

        static bool RotationsPrime(int nr)
        {
            List<int> list = Rotations(nr);

            foreach (int item in list)
            {
                if (!(Prime(item))) return false;
            }

            return true;
        }
    }
}
