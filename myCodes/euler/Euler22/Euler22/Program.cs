using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace Euler22
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Names = new List<string>();

            string Storage = System.IO.File.ReadAllText(@"D:\C_Sharp\Euler22\names.txt");
            Storage = Storage.Replace("\"", "");

            Names = Storage.Split(",").ToList();

            Names.Sort();

            foreach (var item in Names)
                Console.Write(item + " ");

            BigInteger sumFinal = 0;

            //Console.WriteLine("\n" + Names[937]); // COLIN



            int worth = 0;

            for (int i = 0; i < Names.Count; i++)
            {
                worth = 0;
                for (int j = 0; j < Names[i].Length; j++)
                {
                    worth += (int)Names[i][j] - 64;
                }
                sumFinal = sumFinal + (worth * (i + 1));
            }

            //COLIN TEST
            //for (int j = 0; j < Names[937].Length; j++)
            //{
            //    worth += (int)Names[937][j] - 64;
            //}
            //sumFinal = sumFinal + (worth * (937 + 1));

            //Console.WriteLine("\n" + worth);
            Console.WriteLine(sumFinal);
        }
    }
}
