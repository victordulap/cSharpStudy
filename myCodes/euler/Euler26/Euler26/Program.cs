using System;
using System.Collections.Generic;
using System.Numerics;

namespace Euler26
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxRecurring = 0;
            string maxRecurringNumber = "";
            for (int i = 2; i <= 10; i++)
            {
                string str = ((decimal)1 / i).ToString();
                str = str.Remove(0, 2);
                str = str.Remove(str.Length - 1, 1);

                if (str.Length > 10)
                {
                    
                    bool moreToRemove = true;
                    int j = 1;
                    string recurringPart = "";
                    string oldStrEnd = "";
                    while(moreToRemove)
                    {
                        string strEnd = str.Substring(str.Length - j, j);
                        string strRest = str.Remove(str.Length - j, j);

                        if (strRest.Contains(strEnd))
                        {
                            j++;
                            recurringPart = strEnd;
                            oldStrEnd = recurringPart;
                            if (recurringPart.Equals(oldStrEnd))
                            {
                                moreToRemove = false;
                            }
                        }
                    }

                    if (/*maxRecurring < j*/true)
                    {
                        maxRecurring = j;
                        maxRecurringNumber = str;
                    }
                    Console.WriteLine(i + " | " + maxRecurringNumber + " | " + maxRecurring);

                    //str = "123end";

                    //Console.WriteLine(i + " | " + str);
                    //Console.WriteLine("\tstrEnd = " + strEnd);
                    //Console.WriteLine("\tstrRest = " + strRest);
                }
            }

            Console.WriteLine(maxRecurringNumber + " | " + maxRecurring);
        }

        static void Reccuring(string nr)
        {

        }
    }
}
