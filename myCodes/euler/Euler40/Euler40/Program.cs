using System;
using System.Diagnostics;
using System.Text;

namespace Euler40
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();

            #region 180 sec
            //string str = "";

            //int value = 1;

            //int i = 1;
            //int multiplier = 1;
            //while (true)
            //{
            //    str += i.ToString();

            //    if (str.Length > multiplier)
            //    {

            //        value *= (str[multiplier - 1] - 48);
            //        Console.WriteLine(value + $" ({str[multiplier - 1]}) * {multiplier}");

            //        multiplier *= 10;
            //        if (multiplier > 1000000) break;


            //    }

            //    i++;
            //}
            //Console.WriteLine(value);
            #endregion

            #region result best
            //string builder is faster than string
            StringBuilder str = new StringBuilder();

            int value = 1;

            int i = 1;
            while (str.Length < 1000000)
            {
                //str += i;
                str.Append(i);
                i++;
            }

            for (int multiplier = 1; multiplier < 7; multiplier++)
            {
                value *= (str[(int)Math.Pow(10, multiplier) - 1] - 48);
            }

            Console.WriteLine(value);
            #endregion 

            #region also good
            //StringBuilder str1 = new StringBuilder();

            //int value1 = 1;

            //int i1 = 1;
            //int multiplier1 = 1;
            //while (true)
            //{
            //    str1.Append(i1);

            //    if (str1.Length > multiplier1)
            //    {

            //        value1 *= (str1[multiplier1 - 1] - 48);
            //        Console.WriteLine(value1 + $" ({str1[multiplier1 - 1]}) * {multiplier1}");

            //        multiplier1 *= 10;

            //        if (multiplier1 > 1000000) break; // if commented, out of ram memory :) (starts using 2 gb at 10^9)
            //    }

            //    i1++;
            //}
            //Console.WriteLine(value1);
            #endregion

            #region try to reduce memory consumption
            //StringBuilder str = new StringBuilder();

            //int value = 1;

            //int i = 1;
            //int multiplier = 1;
            //int resetedLenght = 0;
            //while (true)
            //{
            //    str.Append(i);

            //    if ((str.Length + resetedLenght) > multiplier)
            //    {

            //        value *= (str[multiplier - 1 - resetedLenght] - 48);
            //        Console.WriteLine(value + $" ({str[multiplier - 1 - resetedLenght]}) * {multiplier}");

            //        multiplier *= 10;

            //        resetedLenght += str.Length;
            //        str.Clear();
            //        str = new StringBuilder();
            //        GC.Collect();

            //        if (multiplier > 1000000000) break; // if commented, out of ram memory :) (starts using 2 gb at 10^9)
            //    }
            //    i++;
            //}
            //Console.WriteLine(value);
            #endregion

            Console.ReadKey();

            stopwatch.Stop();
            Console.WriteLine($"Time: {stopwatch.ElapsedMilliseconds} ms.");
        }
    }
}
