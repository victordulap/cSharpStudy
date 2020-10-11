using System;
using System.Collections.Generic;
using System.Numerics;

namespace Euler26
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 2; i <= 10; i++)
            {
                string str = ((decimal)1 / i).ToString();
                str = str.Remove(0, 2);

                Console.WriteLine(i + " | " + str);
            }
        }

        static void Reccuring(string nr)
        {

        }
    }
}
