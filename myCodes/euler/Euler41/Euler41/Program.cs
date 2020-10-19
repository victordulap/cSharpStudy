using System;
using System.Diagnostics;

namespace Euler41
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch clock = Stopwatch.StartNew();

            #region 1
            //long max = 0;

            //for (long i = 1; i <= /*2143*/987654321; i++/*i += 11*/)
            //{
            //    string strI = i.ToString();
            //    //if (i % 10 == 0) i++;
            //    if ((strI[0] - 48) > strI.Length)
            //    {
            //        Console.Write("prev: " + i);
            //        i = (int)Math.Pow(10, strI.Length);
            //        for (int j = 2; j <= i.ToString().Length; j++)
            //        {
            //            i += j * (int)Math.Pow(10, i.ToString().Length - j);
            //        }
            //        Console.WriteLine(" next: " + i);
            //        continue;
            //    }

            //    if (!strI.Contains('0') && IsPandigital(strI) && IsPrime(i))
            //    {
            //        max = i;
            //    }
            //}

            //Console.WriteLine(max);
            #endregion

            #region reverse
            //long max = 0;

            //// 135 s /3
            //// 115 s /2
            //// 100 s full
            //for (long i = 987654321; i >= /*2143*/1; i--/*i += 11*/)
            //{
            //    string strI = i.ToString();

            //    if (strI.Contains('0')) continue;

            //    for (int j = 0; j < strI.Length - 1; j++)
            //    {
            //        if (strI[j] == strI[j + 1])
            //        {
            //            //Console.Write("prev: " + i/* + " - " + (int)Math.Pow(10, strI.Length - 2)*/);
            //            // 887654321 len:9 len2:8
            //            i -= (int)Math.Pow(10, strI.Length - (2 + j));
            //            //Console.WriteLine(" next: " + i);
            //        }
            //    }
            //    //if(strI[0] == strI[1])
            //    //{
            //    //    Console.Write("prev: " + i/* + " - " + (int)Math.Pow(10, strI.Length - 2)*/);
            //    //    // 887654321 len:9 len2:8
            //    //    i -= (int)Math.Pow(10, strI.Length - 2);
            //    //    Console.WriteLine(" next: " + i);
            //    //}

            //    if (IsPandigital(strI) && IsPrime(i))
            //    {
            //        max = i;
            //        break;
            //    }
            //}

            //Console.WriteLine(max);
            #endregion

            #region ideaFromEuler 
            long max = 0;

            // Note: Nine numbers cannot be done(1 + 2 + 3 + 4 + 5 + 6 + 7 + 8 + 9 = 45 => always dividable by 3)
            // Note: Eight numbers cannot be done(1 + 2 + 3 + 4 + 5 + 6 + 7 + 8 = 36 => always dividable by 3)

            for (long i = 7654321; i >= 1; i--)
            {
                string strI = i.ToString();

                if (strI.Contains('0')) continue;

                for (int j = 0; j < strI.Length - 1; j++)
                {
                    if (strI[j] == strI[j + 1])
                    {
                        //Console.Write("prev: " + i/* + " - " + (int)Math.Pow(10, strI.Length - 2)*/);
                        // 887654321 len:9 len2:8
                        i -= (int)Math.Pow(10, strI.Length - (2 + j));
                        //Console.WriteLine(" next: " + i);
                    }
                }
                //if(strI[0] == strI[1])
                //{
                //    Console.Write("prev: " + i/* + " - " + (int)Math.Pow(10, strI.Length - 2)*/);
                //    // 887654321 len:9 len2:8
                //    i -= (int)Math.Pow(10, strI.Length - 2);
                //    Console.WriteLine(" next: " + i);
                //}

                if (IsPandigital(strI) && IsPrime(i))
                {
                    max = i;
                    break;
                }
            }

            Console.WriteLine(max);
            #endregion

            clock.Stop();
            Console.WriteLine($"Time: {clock.ElapsedMilliseconds} ms.");
        }

        static bool IsPrime(long nr)
        {
            if (nr <= 1) return false;
            if (nr <= 3) return true;

            for (int i = 2; i * i <= nr; i++)
            {
                if (nr % i == 0) return false;
            }

            return true;
        }

        static bool IsPandigital(string nr)
        {
            int length = nr.Length/*nr.Contains('0') ? nr.Length : nr.Length + 1*/;

            for (int i = 1/*nr.Contains('0') ? 0 : 1*/; i <= length; i++)
            {
                if (CheckIfCharUniqueInStr(nr, (char)(i + 48)) != 1) return false;
            }

            return true;
        }

        static int CheckIfCharUniqueInStr(string str, char ch)
        {
            int nr = 0;

            if (!str.Contains(ch)) return 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ch) nr++;
            }

            return nr;
        }
    }
}
