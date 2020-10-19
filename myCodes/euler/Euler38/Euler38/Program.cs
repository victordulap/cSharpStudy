using System;
using System.Diagnostics;

namespace Euler38
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch clock = Stopwatch.StartNew();

            #region examplesGiven

            #region 1
            //// 1. pandigital 
            //Console.WriteLine("192384576: " + IsPandigital(192384576.ToString()));
            #endregion

            #region 2
            /* 2. verify the given condition
             * 
             * Take the number 192 and multiply it by each of 1, 2, and 3:
             *  192 × 1 = 192
             *  192 × 2 = 384
             *  192 × 3 = 576   
             */

            //// initialize, assign
            //int number = 192;
            //string concatinatedString = "";

            //// multiply
            //for (int i = 1; i <= 3; i++)
            //{
            //    concatinatedString = concatinatedString + (number * i).ToString();
            //}

            //// verify
            //Console.WriteLine($"{concatinatedString}: " + IsPandigitalFrom1to9(concatinatedString));
            #endregion

            #region 3 
            /* 3. verify the given condition
             * The same can be achieved by starting with 9 and multiplying by 1, 2, 3, 4, and 5,
             * giving the pandigital, 918273645, which is the concatenated product of 9 and (1,2,3,4,5).
             */

            //// initialize, assign
            //int number = 9;
            //string concatinatedString = "";

            //// multiply
            //for (int i = 1; i <= 5; i++)
            //{
            //    concatinatedString = concatinatedString + (number * i).ToString();
            //}

            //// verify
            //Console.WriteLine($"{concatinatedString}: " + IsPandigitalFrom1to9(concatinatedString));
            #endregion

            #endregion

            #region condition
            int max = 0;
            int number = 1;

            while (number < 10000)
            {
                string concatinatedString = "";

                // multiply
                bool concatinatedRight = false;
                for (int i = 1, n = i + 1; i <= n; i++)
                {
                    concatinatedString = concatinatedString + (number * i).ToString();

                    if (concatinatedString.Length == 9) { concatinatedRight = true; break; }
                    else if (concatinatedString.Length > 9) break;

                    n++;
                }


                // verify
                if (concatinatedRight)
                {
                    if (IsPandigitalFrom1to9(concatinatedString))
                    {
                            Console.WriteLine("max: " + max + " / " + number);
                        if (max < Convert.ToInt32(concatinatedString))
                        {
                            max = Convert.ToInt32(concatinatedString);
                        }
                    }
                }

                number++;
            }
            #endregion

            clock.Stop();
            Console.WriteLine($"Time: {clock.ElapsedMilliseconds} ms.");
        }

        static bool IsPandigitalFrom1to9(string nr)
        {
            if (nr.Contains('0')) return false;
            if (nr.Length != 9) return false;

            for (int i = 1; i <= 9; i++)
            {
                if (getCount(nr, (char)(i + 48)) != 1) return false;
            }

            return true;
        }

        static int getCount(string str, char character)
        {
            if (!str.Contains(character)) return 0;

            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == character) count++;
            }

            return count;
        }
    }
}
