using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Euler43
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch clock = Stopwatch.StartNew();

            #region 1600sec
            //long sum = 0;

            //int[] listOfPrimeNrs = new int[] { 2, 3, 5, 7, 11, 13, 17 };

            //for (long i = 1023456789; i < 9876543210; i++)
            //{
            //    string iToString = i.ToString();

            //    //Console.WriteLine($"{iToString} ----------------");

            //    bool addSum = true;
            //    bool toSkip = false;

            //    //clock.Reset();
            //    //clock.Start();
            //    for (int j = 0; j < iToString.Length - 1; j++)
            //    {
            //        if (iToString[j] == iToString[j + 1])
            //        {
            //            i += (int)(Math.Pow(10, iToString.Length - 2 - j)) - 1;
            //            toSkip = true;
            //        }
            //    }
            //    //clock.Stop();
            //    //Console.WriteLine("skip iterations: " + clock.ElapsedTicks + " ticks.");

            //    if (toSkip) continue;

            //    //clock.Reset();
            //    //clock.Start();
            //    if (!IsPandigitalFrom0to9(iToString))
            //    {
            //        continue;
            //    }
            //    //clock.Stop();
            //    //Console.WriteLine("is pandigital: " + clock.ElapsedTicks + " ticks.");




            //    //clock.Reset();
            //    //clock.Start();
            //    for (int j = 0; j < 7; j++)
            //    {
            //        int subString = Convert.ToInt32(iToString.Substring(j + 1, 3));
            //        if (subString % listOfPrimeNrs[j] != 0)
            //        {
            //            addSum = false;
            //            break;
            //        }
            //    }

            //    if (addSum) sum += i;

            //    //clock.Stop();
            //    //Console.WriteLine("division: " + clock.ElapsedTicks + " ticks.");

            //    //Console.ReadKey();
            //}

            //Console.WriteLine(sum);
            #endregion

            #region permutations
            List<long> pandigits = new List<long>();
            char[] chars = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            Permute(chars, 0, chars.Length, pandigits);

            int[] listOfPrimeNrs = new int[] { 2, 3, 5, 7, 11, 13, 17 };

            pandigits.RemoveAll(x => x.ToString().Length == 9);

            long sum = 0;
            foreach (var pandigit in pandigits)
            {
                bool valid = true;

                for (int j = 0; j < 7; j++)
                {
                    if (Convert.ToInt64(pandigit.ToString().Substring(j, 3)) % listOfPrimeNrs[j] != 0)
                    {
                        valid = false;
                        break;
                    }
                }

                if (valid) sum += pandigit;
            }

            Console.WriteLine(sum);
            #endregion

            #region test
            //List<long> permutations = new List<long>();
            //char[] chars = {'1', '2', '3'};
            //Permute(chars, 0, chars.Length, permutations);

            //foreach (var item in permutations)
            //{
            //    Console.WriteLine(permutations);
            //}

            #endregion

            clock.Stop();
            Console.WriteLine($"Time: {clock.ElapsedMilliseconds} ms.");
        }

        #region permutations
        static void Permute(char[] arry, int i, int n, List<long> pandigits)
        {
            int j;
            if (i == n)
            {
                string str = new string(arry);
                pandigits.Add(Convert.ToInt64(str));
            }
            else
            {
                for (j = i; j < n; j++)
                {
                    Swap(ref arry[i], ref arry[j]);
                    Permute(arry, i + 1, n, pandigits);
                    Swap(ref arry[i], ref arry[j]); //backtrack
                }
            }
        }

        static void Swap(ref char a, ref char b)
        {
            char tmp = a;
            a = b;
            b = tmp;
        }
        #endregion

        #region 1
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
        #endregion
    }
}
