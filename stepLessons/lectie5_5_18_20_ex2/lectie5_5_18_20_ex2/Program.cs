using System;
using System.Runtime.CompilerServices;
using VerificareLogica;

namespace DateAngajat
{
    class DateAng
    {
        public int salariuCurent;
        public int salariuNou;

        public DateAng(int _salariuCurent, int _salariuNou)
        {
            salariuCurent = _salariuCurent;
            salariuNou = _salariuNou;
        }

        public void SchimbareSalariu(int _salariuNou)
        {
            salariuCurent = _salariuNou;
        }

        static void Main(string[] args)
        {
            DateAng ang1 = new DateAng(9999, 0);
            ang1.SchimbareSalariu
        }
    }
}
