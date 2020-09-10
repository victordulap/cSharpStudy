using System;
//using System.Collections.Generic;
//using System.Text;  se poate de sters ca ele apar doadate cand creem fille nou

namespace Operatii
{
    class Oper
    {
        public static int Plus(int a, int b)
        {
            return a + b;
        }
        public static int Minus(int a, int b)
        {
            return a - b;
        }
        public static int Inmultire(int a, int b)
        {
            return a * b;
        }
        public static double Impartire(int a, int b)
        {
            return a / Convert.ToDouble(b);
        }
    }
}
