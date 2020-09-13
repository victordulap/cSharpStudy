using System;

namespace Euler31
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalWays = 4;
            int sum = 0;

            for (int _5 = 0; _5 < 1; _5++)
            {
                if ((sum + 5) >= 10)
                {
                    if ((sum + 5) == 10)
                    {
                        totalWays++;
                        sum = 0;
                    }
                    else
                    {
                        //?
                    }
                }
                else { sum += 5; }
                for (int _2 = 0; _2 < 4; _2++)
                {
                    if ((sum + 2) >= 10)
                    {
                        if ((sum + 2) == 10)
                        {
                            totalWays++;
                            sum = 2;
                        }
                    }
                    else { sum += 2; }
                    for (int _1 = 0; _1 < 9; _1++)
                    {
                        if ((sum + 1) >= 10)
                        {
                            if ((sum + 1) == 10)
                            {
                                totalWays++;
                                sum = 1;
                            }
                        }
                        else { sum += 1; }
                    }
                }
            }

            Console.WriteLine("totalWays: " + totalWays);
        }
    }
}
