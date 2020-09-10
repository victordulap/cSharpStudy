using System;
using System.Numerics;

namespace Euler15
{
    class Program
    {
        static BigInteger factorial(int nr)
        {
            BigInteger r = 1; 

            for (int i = 1; i <= nr; i++)
            {
                r *= i;
            }

            return r;
        }
        static void Main(string[] args)
        {
            //Console.WriteLine(factorial(5));

            //var rs = (factorial(20 + 20) / (factorial(20) * factorial(20))); lucreza si asa o_O
            BigInteger rs = (factorial(20 + 20) / (factorial(20) * factorial(20)));
            BigInteger rs1 = (factorial(20) * factorial(20));
            BigInteger rs2 = factorial(20);
            //BigInteger rs1 = factorial(20 + 20);
            //BigInteger f20 = factorial(20);
            //BigInteger rs2 = f20 * f20;
            //BigInteger rs = rs1 / rs2;
            Console.WriteLine(rs);
            Console.WriteLine(rs1);
            Console.WriteLine(rs1.GetType());
            Console.WriteLine(rs2);
            //Console.WriteLine(rs2);
        }
    }
}
