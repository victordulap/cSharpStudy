using System;

namespace ThisExemplu
{
    class Program
    {
        public string mesaj = "Ai obtinut o referinta cu ajutorul this :)";

        public Program Referinta()
        {
            return this;
        }
    }

    class Program2
    {
        //public static Program programBaza;

        private static void Main()
        {
            Program program = new Program();
            Program prog2 = new Program();
            //programBaza = program.Referinta();
            prog2 = program.Referinta();
            //Console.WriteLine(programBaza.mesaj);
            Console.WriteLine(prog2.mesaj);
        }
    }
}
