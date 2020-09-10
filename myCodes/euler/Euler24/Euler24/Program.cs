using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Euler24
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch clock = Stopwatch.StartNew();

            #region 0123456789 22 min
            //int variants = 0;
            //for (long i = 123456789; i <= 9876543210; i++)
            //{
            //    //Stopwatch clock2 = Stopwatch.StartNew();

            //    string str = i.ToString();
            //    if (str.Length != 10)
            //    {
            //        for (int j = 0; j < 10 - str.Length; j++)
            //        {
            //            str = "0" + str;
            //        }
            //    }

            //    int _0 = 0, _1 = 0, _2 = 0, _3 = 0, _4 = 0, _5 = 0, _6 = 0, _7 = 0, _8 = 0, _9 = 0;
            //    for (int j = 0; j < str.Length; j++)
            //    {
            //        if (str[j] == '0') _0++;
            //        else if (str[j] == '1') _1++;
            //        else if (str[j] == '2') _2++;
            //        else if (str[j] == '3') _3++;
            //        else if (str[j] == '4') _4++;
            //        else if (str[j] == '5') _5++;
            //        else if (str[j] == '6') _6++;
            //        else if (str[j] == '7') _7++;
            //        else if (str[j] == '8') _8++;
            //        else if (str[j] == '9') _9++;

            //        if (_0 > 1 || _1 > 1 || _2 > 1 || _3 > 1 || _4 > 1 || _5 > 1 || _6 > 1 || _7 > 1 || _8 > 1 || _9 > 1) continue;
            //    }


            //    if (_0 == 1 && _1 == 1 && _2 == 1 && _3 == 1 && _4 == 1 && _5 == 1 && _6 == 1 && _7 == 1 && _8 == 1 && _9 == 1)
            //    {
            //        variants++;
            //        Console.WriteLine("{0}. {1}", variants, str);
            //        ////clock2.Stop();
            //        ////Console.WriteLine($"{variants}. {str} ({clock2.ElapsedTicks} ms)");
            //        if (variants == 1000000) { Console.WriteLine("Milionth: " + str); break; }
            //    }
            //    ////clock2.Restart();

            //}
            #endregion

            #region 0123456789 v2 443168 ms (7 minute 23 sec)
            int variants = 0;
            for (long i = 123456789; i <= 9876543210; i++)
            {
                //Stopwatch clock2 = Stopwatch.StartNew();

                string str = i.ToString();
                if (str.Length != 10)
                {
                    for (int j = 0; j < 10 - str.Length; j++)
                    {
                        str = "0" + str;
                    }
                }

                if (str[0] == str[1] || str[0] == str[2] ||
                    str[0] == str[3] || str[0] == str[4] ||
                    str[0] == str[5] || str[0] == str[6] ||
                    str[0] == str[7] || str[0] == str[8] ||
                    str[0] == str[9])
                    continue;
                else if (str[1] == str[2] ||
                         str[1] == str[3] || str[1] == str[4] ||
                         str[1] == str[5] || str[1] == str[6] ||
                         str[1] == str[7] || str[1] == str[8] ||
                         str[1] == str[9])
                    continue;
                else if (str[2] == str[3] || str[2] == str[4] ||
                         str[2] == str[5] || str[2] == str[6] ||
                         str[2] == str[7] || str[2] == str[8] ||
                         str[2] == str[9])
                    continue;
                else if (str[3] == str[4] ||
                         str[3] == str[5] || str[3] == str[6] ||
                         str[3] == str[7] || str[3] == str[8] ||
                         str[3] == str[9])
                    continue;
                else if (str[4] == str[5] || str[4] == str[6] ||
                         str[4] == str[7] || str[4] == str[8] ||
                         str[4] == str[9])
                    continue;
                else if (str[5] == str[6] ||
                         str[5] == str[7] || str[5] == str[8] ||
                         str[5] == str[9])
                    continue;
                else if (str[6] == str[7] || str[6] == str[8] ||
                         str[6] == str[9])
                    continue;
                else if (str[7] == str[8] || str[7] == str[9])
                    continue;
                else if (str[8] == str[9])
                    continue;

                variants++;
                //Console.WriteLine("{0}. {1}", variants, str);
                if (variants == 1000000) { Console.WriteLine("Milionth: " + str); break; }
            }
            #endregion

            #region 0123456789 v3 (hybrid) (slow) ?ms
            //int variants = 0;
            //for (long i = 123456789; i <= 9876543210; i++)
            //{
            //    //Stopwatch clock2 = Stopwatch.StartNew();

            //    string str = i.ToString();
            //    if (str.Length != 10)
            //    {
            //        for (int j = 0; j < 10 - str.Length; j++)
            //        {
            //            str = "0" + str;
            //        }
            //    }

            //    if (str[0] == str[1] || str[0] == str[2] ||
            //        str[0] == str[3] || str[1] == str[2] ||
            //        str[1] == str[3] || str[2] == str[3])
            //        continue;

            //    int _0 = 0, _1 = 0, _2 = 0, _3 = 0, _4 = 0, _5 = 0, _6 = 0, _7 = 0, _8 = 0, _9 = 0;
            //    for (int j = 0; j < str.Length; j++)
            //    {
            //        if (str[j] == '0') _0++;
            //        else if (str[j] == '1') _1++;
            //        else if (str[j] == '2') _2++;
            //        else if (str[j] == '3') _3++;
            //        else if (str[j] == '4') _4++;
            //        else if (str[j] == '5') _5++;
            //        else if (str[j] == '6') _6++;
            //        else if (str[j] == '7') _7++;
            //        else if (str[j] == '8') _8++;
            //        else if (str[j] == '9') _9++;

            //        if (_0 > 1 || _1 > 1 || _2 > 1 || _3 > 1 || _4 > 1 || _5 > 1 || _6 > 1 || _7 > 1 || _8 > 1 || _9 > 1) continue;
            //    }

            //    if (_0 == 1 && _1 == 1 && _2 == 1 && _3 == 1 && _4 == 1 && _5 == 1 && _6 == 1 && _7 == 1 && _8 == 1 && _9 == 1)
            //    {
            //        variants++;
            //        //Console.WriteLine("{0}. {1}", variants, str);
            //        ////clock2.Stop();
            //        ////Console.WriteLine($"{variants}. {str} ({clock2.ElapsedTicks} ms)");
            //        if (variants == 1000000) { Console.WriteLine("Milionth: " + str); break; }
            //    }
            //}
            #endregion

            #region 0123456789 v4 (slow) 1093420 ms.
            //int variants = 0;
            //for (long i = 123456789; i <= 9876543210; i++)
            //{
            //    string str = i.ToString();
            //    if (str.Length != 10)
            //    {
            //        for (int j = 0; j < 10 - str.Length; j++)
            //        {
            //            str = "0" + str;
            //        }
            //    }

            //    if (str.Count(x => x == '0') != 1) continue;
            //    else if (str.Count(x => x == '1') != 1) continue;
            //    else if (str.Count(x => x == '2') != 1) continue;
            //    else if (str.Count(x => x == '3') != 1) continue;
            //    else if (str.Count(x => x == '4') != 1) continue;
            //    else if (str.Count(x => x == '5') != 1) continue;
            //    else if (str.Count(x => x == '6') != 1) continue;
            //    else if (str.Count(x => x == '7') != 1) continue;
            //    else if (str.Count(x => x == '8') != 1) continue;
            //    else if (str.Count(x => x == '9') != 1) continue;

            //    //for (int j = 0; j < 10; j++)
            //    //{
            //    //    if (str.Count(x => x == j + 60) != 1) continue;
            //    //}



            //    variants++;
            //    //Console.WriteLine("{0}. {1}", variants, str);
            //    if (variants == 1000000) { Console.WriteLine("Milionth: " + str); break; }

            //}
            #endregion

            #region 0 1 2
            //int variants = 0;
            //for (int i = 12; i <= 210; i++)
            //{
            //    string str = i.ToString();
            //    if (str.Length != 3)
            //    {
            //        for (int j = 0; j < 3 - str.Length; j++)
            //        {
            //            str = "0" + str;
            //        }
            //    }

            //    if (str[0] == str[1] || str[0] == str[2]) continue;
            //    else if (str[1] == str[0] || str[1] == str[2]) continue;
            //    else if (str[2] == str[0] || str[2] == str[1]) continue;

            //    if (str.Contains('3') || str.Contains('4') || str.Contains('5') || str.Contains('6') || str.Contains('7') || str.Contains('8') || str.Contains('9'))
            //        continue;

            //    Console.WriteLine(str);
            //    variants++;
            //    //if (variants == 2) { Console.WriteLine("Milionth: " + str); break; }
            //}
            #endregion

            #region 0124567
            //int variants = 0;
            //for (long i = 1234567; i <= 76543210; i++)
            //{
            //    //Stopwatch clock2 = Stopwatch.StartNew();

            //    string str = i.ToString();
            //    if (str.Length != 8)
            //    {
            //        for (int j = 0; j < 8 - str.Length; j++)
            //        {
            //            str = "0" + str;
            //        }
            //    }

            //    if (str[0] == str[1] || str[0] == str[2] ||
            //        str[0] == str[3] || str[0] == str[4] ||
            //        str[0] == str[5] || str[0] == str[6]) continue;
            //    else if (str[1] == str[0] || str[1] == str[2] ||
            //             str[1] == str[3] || str[1] == str[4] ||
            //             str[1] == str[5] || str[1] == str[6]) continue;
            //    else if (str[2] == str[0] || str[2] == str[1] ||
            //             str[2] == str[3] || str[2] == str[4] ||
            //             str[2] == str[5] || str[2] == str[6]) continue;
            //    else if (str[3] == str[0] || str[3] == str[1] ||
            //             str[3] == str[2] || str[3] == str[4] ||
            //             str[3] == str[5] || str[3] == str[6]) continue;
            //    else if (str[4] == str[0] || str[4] == str[1] ||
            //             str[4] == str[2] || str[4] == str[3] ||
            //             str[4] == str[5] || str[4] == str[6]) continue;
            //    else if (str[5] == str[0] || str[5] == str[1] ||
            //             str[5] == str[2] || str[5] == str[3] ||
            //             str[5] == str[4] || str[5] == str[6]) continue;
            //    else if (str[6] == str[0] || str[6] == str[1] ||
            //             str[6] == str[2] || str[6] == str[3] ||
            //             str[6] == str[4] || str[6] == str[5]) continue;

            //    //int _0 = 0, _1 = 0, _2 = 0, _3 = 0, _4 = 0, _5 = 0, _6 = 0, _7 = 0;
            //    //for (int j = 0; j < str.Length; j++)
            //    //{
            //    //    if (str[j] == '0') _0++;
            //    //    else if (str[j] == '1') _1++;
            //    //    else if (str[j] == '2') _2++;
            //    //    else if (str[j] == '3') _3++;
            //    //    else if (str[j] == '4') _4++;
            //    //    else if (str[j] == '5') _5++;
            //    //    else if (str[j] == '6') _6++;
            //    //    else if (str[j] == '7') _7++;


            //    //    if (_0 > 1 || _1 > 1 || _2 > 1 || _3 > 1 || _4 > 1 || _5 > 1 || _6 > 1 || _7 > 1) continue;
            //    //}


            //    //if (_0 == 1 && _1 == 1 && _2 == 1 && _3 == 1 && _4 == 1 && _5 == 1 && _6 == 1 && _7 == 1)
            //    //{
            //        variants++;
            //        Console.WriteLine("{0}. {1}", variants, str);
            //        ////clock2.Stop();
            //        ////Console.WriteLine($"{variants}. {str} ({clock2.ElapsedTicks} ms)");
            //        //if (variants == 1000000) { Console.WriteLine("Milionth: " + str); break; }
            //    //}
            //    ////clock2.Restart();
            //}
            #endregion

            clock.Stop();
            Console.WriteLine("Time elapsed: {0} ms.", clock.ElapsedMilliseconds);
        }
    }
}
