using System;

namespace ref_keyword
{
    class GFG
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 12;



            Console.WriteLine("Valoarea initiala a este {0}", a);
            Console.WriteLine("Valoarea initiala b este {0}", b);
            Console.WriteLine();



            adauga(a);
            Console.WriteLine("Valoarea dupa adaugare {0}", a);



            scade(ref b);
            Console.WriteLine("Value dupa scadere, cu ref: {0}", b);
        }



        public static void adauga(int a)
        {
            a += 10;
        }



        public static void scade(ref int b)
        {
            b -= 5;
        }
    }
}