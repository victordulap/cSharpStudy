using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Euler33
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch clock = Stopwatch.StartNew();

            int sus = 1;
            int jos = 1;
            for (int i = 11; i < 100; i++)
            {
                for (int j = i; j < 100; j++)
                {
                    string stri = i.ToString(), strj = j.ToString();

                    if ((stri.Contains('0') || strj.Contains('0')) || (stri[0] == stri[1]) || (strj[0] == strj[1]) || i == j) continue;

                    for (int x = 0; x < stri.Length; x++)
                    {
                        if (strj.Contains(stri[x]))
                        {
                            strj = strj.Replace(stri[x].ToString(), "");
                            stri = stri.Replace(stri[x].ToString(), "");

                            int i2 = Convert.ToInt32(stri), j2 = Convert.ToInt32(strj);

                            if (Convert.ToDouble((double)i / j) == ((double)i2 / j2))
                            {

                                //SimplifyFraction(ref i2, ref j2);
                                Console.WriteLine($"{i} / {j} == {i2} / {j2}");
                                sus *= i2;
                                jos *= j2;
                            }
                        }
                    }
                }
            }

            SimplifyFraction(ref sus, ref jos);
            Console.WriteLine($"rezult = ({sus} / {jos})");

            clock.Stop();
            Console.WriteLine($"Time elapsed: {clock.ElapsedMilliseconds} ms.");
        }

        ///<summary>
        ///Simplifies a / b <br></br>
        ///a and b passed as reference
        ///</summary>
        static void SimplifyFraction(ref int a, ref int b)
        {
            List<int> DivsOfa = DivisorsList(a);
            List<int> DivsOfb = DivisorsList(b);

            DivsOfa.Reverse();
            DivsOfb.Reverse();

            for (int i = 0; i < DivsOfa.Count; i++)
            {
                if (DivsOfb.Contains(DivsOfa[i]))
                {
                    a /= DivsOfa[i];
                    b /= DivsOfa[i];

                    return;
                }
            }

            //Console.WriteLine($"Divs of a: ");
            //foreach (var item in DivsOfa)
            //{
            //    Console.Write(item + " ");
            //}

            //Console.WriteLine($"\nDivs of b: ");
            //foreach (var item in DivsOfb)
            //{
            //    Console.Write(item + " ");
            //}
        }

        static List<int> DivisorsList(int nr)
        {
            List<int> rez = new List<int>();

            for (int i = 1; i <= nr; i++)
            {
                if (nr % i == 0) rez.Add(i);
            }

            return rez;
        }
    }
}
