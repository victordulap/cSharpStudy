using System;
using System.Security.Cryptography.X509Certificates;

namespace lectia_5_13_2020_ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Cuvant1 Cuv2 Word3";

            CheckString(str);
        }

        public static void CheckString(string str)
        {
            string[] cuv = str.Split(' ');
            int k = 0;
            X:
            try
            {
                
                for (int i = 0; i < cuv.Length; i++)
                {
                    Console.Write(cuv[i] + ", ");
                    Console.WriteLine(cuv[i][4]);
                    k++;
                }
            }
            catch(/*ArgumentOutOfRangeException*/IndexOutOfRangeException)
            {
                //Console.WriteLine("Cuvantul este prea scurt!");
                cuv[k] += "XXXXX";
                k = 0;
                Console.WriteLine("RESET!");
                goto X;
            }
        }
    }
}
