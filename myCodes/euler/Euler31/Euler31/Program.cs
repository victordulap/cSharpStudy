using System;

namespace Euler31
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalWays = 4;
            int sum = 0;
            //for (int _100 = 0; _100 < 1; _100++)
            //{
            //    sum += 100;
            //    if (sum == 200)
            //    {
            //        totalWays++;
            //        sum = 0;
            //    }

            //    for (int _50 = 0; _50 < 3; _50++)
            //    {
            //        sum += 50;
            //        if (sum == 200)
            //        {
            //            totalWays++;
            //            sum = 0;
            //        } 

            //        for (int _20 = 0; _20 < 9; _20++)
            //        {
            //            sum += 20;
            //            if (sum == 200)
            //            {
            //                totalWays++;
            //                sum = 0;
            //            }

            //            for (int _10 = 0; _10 < 19; _10++)
            //            {
            //                sum += 10;
            //                if (sum == 200)
            //                {
            //                    totalWays++;
            //                    sum = 0;
            //                }

            //                for (int _5 = 0; _5 < 39; _5++)
            //                {

            //                    sum += 5;
            //                    if (sum == 200)
            //                    {
            //                        totalWays++;
            //                        sum = 0;
            //                    }

            //                    for (int _2 = 0; _2 < 99; _2++)
            //                    {

            //                        sum += 2;
            //                        if (sum == 200)
            //                        {
            //                            totalWays++;
            //                            sum = 0;
            //                        }

            //                        for (int _1 = 0; _1 < 199; _1++)
            //                        {
            //                            sum += 1;
            //                            if (sum == 200)
            //                            {
            //                                totalWays++;
            //                                sum = 0;
            //                            }
            //                        }
            //                    }
            //                }
            //            }
            //        }
            //    }
            //}

            //for (int _5 = 0; _5 < 1; _5++)
            //{

            //    sum += 5;
            //    if (sum == 10)
            //    {
            //        totalWays++;
            //        sum = 0;
            //    }

            //    for (int _2 = 0; _2 < 4; _2++)
            //    {

            //        sum += 2;
            //        if (sum == 10)
            //        {
            //            totalWays++;
            //            sum = 0;
            //        }

            //        for (int _1 = 0; _1 < 9; _1++)
            //        {
            //            sum += 1;
            //            if (sum == 10)
            //            {
            //                totalWays++;
            //                sum = 0;
            //            }
            //        }
            //    }
            //}

            int max1 = 10, _1 = 0;
            while (_1 != max1)
            {
                if (sum + 1 < 10)
                {
                    sum += 1;
                }

                _1++;
            }

            Console.WriteLine("totalWays: " + totalWays);
        }
    }
}
