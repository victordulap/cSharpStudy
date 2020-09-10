using System;

namespace Singleton
{
    public class Exemplu
    {
        public static Exemplu instance = null;
        private Exemplu() { }
        public static Exemplu GetInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Exemplu();
                }
                return instance;
            }
        }

        //Variabila locala
        public int numar = 0;
    }

    public class ImplementareExemplu
    {
        private Exemplu referinta = Exemplu.GetInstance;
        private Exemplu referinta2 = Exemplu.GetInstance;

        private static void Main()
        {
            ImplementareExemplu impl = new ImplementareExemplu();
            impl.IncrementNumar(1);
            impl.IncrementNumar(2);
            impl.IncrementNumar(3);
        }

        private void IncrementNumar(int parametru)
        {
            referinta.numar += parametru;
            referinta2.numar += parametru * 2;
            Console.WriteLine("Referinta 1:" + referinta.numar);
            Console.WriteLine("Referinta 2:" + referinta2.numar);
        }
    }
}