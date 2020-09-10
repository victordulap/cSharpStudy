using System;
using System.Numerics;

namespace Euler26
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 2; i <= 100; i++)
            {
                string str = (1000000000000000000 / Convert.ToDecimal(i)).ToString();
                if (str.Contains('.'))
                    str = str.Remove(str.IndexOf('.'), 1);
                Console.WriteLine(i + ". " + str);
            }
        }

        static bool Reccuring(string nr)
        {
            return true;
        }
    }
}
