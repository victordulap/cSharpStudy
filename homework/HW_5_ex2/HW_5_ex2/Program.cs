using System;
using Editare;

namespace Afisare
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] str = new string[] { "cuvant", "XxX", "word" };
            foreach (string s in str)
            {
                Console.Write(s + " ");
            }

            Class1.Metoda(ref str);

            Console.WriteLine();
            foreach (string s in str)
            {
                Console.Write(s + " ");
            }
        }
    }
}
