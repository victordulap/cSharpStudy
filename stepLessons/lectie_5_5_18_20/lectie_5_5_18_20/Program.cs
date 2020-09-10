using System;
//using Operatii;
using static Operatii.Oper; // daca vrem sa includem o clasa trebuie sa scriem static inainte de asta

namespace lectie_5_5_18_20
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1, b = 2;

            Console.WriteLine(Plus(a, b));
            Console.WriteLine(Minus(a, b));
            Console.WriteLine(Inmultire(a, b));
            Console.WriteLine(Impartire(a, b));
        }
    }
}
