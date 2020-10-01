using System;
using System.Diagnostics;
using System.Text;

namespace Euler36
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch clock = Stopwatch.StartNew();

            //int n;
            //while (true)
            //{
            //    Console.Write("enter n: ");
            //    n = Convert.ToInt32(Console.ReadLine());

            //    Console.WriteLine("base2: " + Convert.ToString(n, 2));
            //    Console.WriteLine("base8: " + Convert.ToString(n, 8));
            //    Console.WriteLine("base10: " + Convert.ToString(n, 10));
            //    Console.WriteLine("base16: " + Convert.ToString(n, 16));
            //}

            //while (true)
            //{
            //    Console.Write("enter n: ");
            //    int n = Convert.ToInt32(Console.ReadLine());

            //    Console.WriteLine(Palindrome(n));
            //}

            int sum = 0;

            for (int i = 0; i < 1000000; i++)
            {
                if (Palindrome(i) && Palindrome(Convert.ToString(i, 2)))
                {
                    sum += i;
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine("sum = " + sum);

            clock.Stop();
            Console.WriteLine($"Time: {clock.ElapsedMilliseconds} ms.");
        }

        static bool Palindrome(int nrToCheck)
        {
            string str = nrToCheck.ToString();

            StringBuilder sb1 = new StringBuilder(/*str.Length / 2*/);
            StringBuilder sb2 = new StringBuilder(/*str.Length / 2*/);
            for (int i = 0; i < str.Length / 2; i++)
            {
                sb1.Append(str[i]);
                sb2.Append(str[str.Length - i - 1]);
            }

            String str1 = new String(sb1.ToString());
            String str2 = new String(sb2.ToString());

            //Console.WriteLine("str1: " + str1);
            //Console.WriteLine("str2: " + str2);

            if (str1.Equals(str2))
                return true;
            else
                return false;
        }

        static bool Palindrome(string nrToCheck)
        {
            StringBuilder sb1 = new StringBuilder();
            StringBuilder sb2 = new StringBuilder();
            for (int i = 0; i < nrToCheck.Length / 2; i++)
            {
                sb1.Append(nrToCheck[i]);
                sb2.Append(nrToCheck[nrToCheck.Length - i - 1]);
            }

            String str1 = new String(sb1.ToString());
            String str2 = new String(sb2.ToString());

            if (str1.Equals(str2))
                return true;
            else
                return false;
        }
    }
}
