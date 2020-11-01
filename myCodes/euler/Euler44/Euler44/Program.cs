using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Euler44
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch clock = Stopwatch.StartNew();

            #region 1
            //// generate pentagonal numbers
            //List<int> P = new List<int>();
            //int i = 1, n = 100;
            //GeneratePentagonals(i, n, P);

            //bool resultFound = false;
            //int D = 0;
            //for (int j = 0; !resultFound; j++)
            //{
            //    for (int k = 0; k < j; k++)
            //    {
            //        if (IsPentagonal(P[j] - P[k], P) && IsPentagonal(P[j] + P[k], P))
            //        {
            //            D = P[j] - P[k];
            //            resultFound = true;
            //            break;
            //        }
            //    }
            //    //if (j == (n - 1))
            //    //{
            //    //    i += 100;
            //    //    n += 100;
            //    //    GeneratePentagonals(i, n, P);
            //    //}
            //}

            ////int Pj = P[2167 -1];
            ////int Pk = P[1020 -1];

            ////if (IsPentagonal(Pj - Pk, P) && IsPentagonal(Pj - Pk, P))
            ////{
            ////    D = Pj - Pk;
            ////    resultFound = true;
            ////}

            ////Console.WriteLine(Pj);
            ////Console.WriteLine(Pk);
            //Console.WriteLine(D);
            #endregion

            #region reverseFunction
            bool resultFound = false;
            int D = -1;
            int PjFinal = 0;
            int jFinal = 0;
            int PkFinal = 0;
            int kFinal = 0;

            for (int j = 2; !resultFound; j++)
            {
                for (int k = 1; k < j; k++)
                {
                    int Pj = j * (3 * j - 1) / 2;
                    int Pk = k * (3 * k - 1) / 2;

                    if (IsPentagonal(Pj - Pk) && IsPentagonal(Pj + Pk))
                    {
                        resultFound = true;
                        D = Pj - Pk;
                        PjFinal = Pj;
                        PkFinal = Pk;
                        jFinal = j;
                        kFinal = k;
                        break;
                    }
                }
            }

            Console.WriteLine(PjFinal + " j: " + jFinal);
            Console.WriteLine(PkFinal + " k: " + kFinal);
            Console.WriteLine(D);
            #endregion

            clock.Stop();
            Console.WriteLine("Elapsed milliseconds: " + clock.ElapsedMilliseconds);
        }
        #region 1
        //static void GeneratePentagonals(int startI, int n, List<int> pentagonals)
        //{
        //    for (int i = startI; i < n; i++)
        //    {
        //        pentagonals.Add((int)(i * (3 * i - 1) / 2));
        //    }
        //}

        //static bool IsPentagonal(int nr, List<int> pentagonals)
        //{
        //    //foreach (var pentagonal in pentagonals)
        //    //{
        //    //    if (nr == pentagonal) return true;
        //    //}

        //    if (pentagonals.Contains(nr)) return true;

        //    return false;
        //}
        #endregion

        //inverse function
        public static bool IsPentagonal(int number)
        {
            double penTest = (Math.Sqrt(1 + 24 * number) + 1.0) / 6.0;
            return penTest == ((int)penTest);
        }
    }
}
