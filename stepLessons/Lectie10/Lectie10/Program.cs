using System;
using static System.Console;

namespace Lectie10
{
    #region ex1
    //class Program
    //{
    //    private static void Main()
    //    {
    //        Random rand = new Random();

    //        string[] nume = new string[] { "Vasile", "Victor", "Andrei", "Daniela", "Maria", "Kyle" };
    //        string[] prenume = new string[] { "Dulap", "Popa", "Cebotari", "Las", "White", "Smith" };

    //        Angajat[] ang = new Angajat[10];

    //        for (int i = 0; i < 10; i++)
    //        {
    //            //ang[i] = new Angajat(5123, "Vasile", "Vasilievici", 3500);
    //            ang[i] = new Angajat((i + 1) * (i + 123), nume[rand.Next(nume.Length)], prenume[rand.Next(prenume.Length)], 1000 + (i + 1) * (i + 123));
    //            WriteLine("Angajatul {0}, {1} {2} are salariul {3} lei.", ang[i].id, ang[i].nume, ang[i].prenume, ang[i].salariu);
    //        }

    //    }
    //}
    //struct Angajat
    //{
    //    public int id;
    //    public string nume;
    //    public string prenume;
    //    public int salariu;

    //    public Angajat(int _id, string _nume, string _prenume, int _salariu)
    //    {
    //        id = _id;
    //        nume = _nume;
    //        prenume = _prenume;
    //        salariu = _salariu;
    //    }

    //}
    #endregion

    #region enum
    //class Exemplu
    //{
    //    private enum Zile
    //    {
    //        Luni,
    //        Marti,
    //        Miercuri,
    //        Joi,
    //        Vineri,
    //        Simbata,
    //        Duminica
    //    }

    //    private static void Main()
    //    {
    //        Zile ziCurenta = Zile.Luni;

    //        if (ziCurenta == Zile.Luni)
    //            WriteLine("Incepe saptamina...");

    //        else if (ziCurenta == Zile.Simbata || ziCurenta == Zile.Duminica) WriteLine("Weekend!");
    //    }
    //}
    #endregion

    #region ex1
    /*class Masina
    {
        public string Denumire { get; set; }
        public int Pret { get; set; }

        public enum Stare
        {
            Noua,
            Uzata,
            Veche,
            Defectata
        }

        public Stare StareMasina;

        public Masina(string _Denumire, int _Pret, Stare _StareMasina)
        {
            Denumire = _Denumire;
            Pret = _Pret;
            StareMasina = _StareMasina;
        }
    }

    class Exemplu
    {
        private static void Main()
        {
            Masina[] obj = new Masina[4];
            for (int i = 0; i < obj.Length; i++)
            {
                obj[i] = new Masina("Ferrari" + i.ToString(), 1234567, (Masina.Stare)i);

                switch (obj[i].StareMasina)
                {
                    case Masina.Stare.Defectata: { obj[i].Pret = obj[i].Pret / 100 * 10; break; }
                    case Masina.Stare.Veche: { obj[i].Pret = obj[i].Pret / 100 * 30; break; }
                    case Masina.Stare.Uzata: { obj[i].Pret = obj[i].Pret / 100 * 50; break; }
                    case Masina.Stare.Noua: { obj[i].Pret = obj[i].Pret; break; }
                }

                WriteLine("Masina: {0}, {1}$, {2}", obj[i].Denumire, obj[i].Pret, obj[i].StareMasina.ToString());
            }
        }
    }*/
    #endregion

    #region ex1
    //class GetNames
    //{
    //    enum Obiecte
    //    {
    //        Televizor = 3000,
    //        Masina = 1000000,
    //        Pat = 30000,
    //        Masa = 20000,
    //        Dulap = 40000,
    //        Farfurie = 250,
    //        Telefon = 200,
    //        PC = 5000,
    //        Pahar = 150
    //    };

    //    public static void Main()
    //    {
    //        //WriteLine("Avem culorile:");
    //        //foreach (string s in Enum.GetNames(typeof(Culori)))
    //        //    WriteLine(s);
    //        string[] str = Enum.GetNames(typeof(Obiecte));
    //        int[] x = (int[])Enum.GetValues(typeof(Obiecte));

    //        foreach (string s in str)
    //        {
    //            WriteLine(s);
    //        }
    //        foreach (int i in x)
    //        {
    //            WriteLine(i);
    //        }

    //        int stop;
    //        do
    //        {
    //            stop = Convert.ToInt32(ReadLine());
    //            Arata(stop);
    //        } while (stop != 1337);
    //    }

    //    static void Arata(int i)
    //    {
    //        WriteLine("Obiectul: {0} are masa de {1} grame", (Obiecte)i, i);
    //    }
    //}

    #endregion


    //partea 2

    #region ex1

    //class Program
    //{
    //    public delegate int MyDelegate(int Integer);

    //    static void Main()
    //    {
    //        MyDelegate del1 = C1.Metoda1;

    //        MyDelegate del2 = C2.Metoda2;

    //        WriteLine(del1(1) + del2(2));
    //        //WriteLine(del1(1) + C2.Metoda2(2));
    //    }
    //}

    //class C1
    //{
    //    public static int Metoda1(int Integer)
    //    {
    //        return Integer;
    //    }
    //}
    //class C2
    //{
    //    public static int Metoda2(int Integer)
    //    {
    //        return Integer;
    //    }
    //}

    #endregion

    #region ex1
    //class Program
    //{
    //    public delegate string MyDelegate(string Str);

    //    static void Main()
    //    {
    //        //WriteLine(Method1("abacaead"));
    //        MyDelegate del1 = Method1;
    //        MyDelegate del2 = Method2;
    //        MyDelegate del3 = Method3;
    //        //MyDelegate del = del3(del2(del1("abcdea")));
    //        //del3(del2(del1("abcdea")));
    //        //Method3(Method2(Method1("abcdea")));
    //    }

    //    private static string Method1(string str)
    //    {
    //        return str.Replace("a", "");
    //    }
    //    private static string Method2(string str)
    //    {
    //        return str.ToUpper();
    //    }
    //    private static string Method3(string str)
    //    {
    //        return str + "xyz";
    //    }
    //}
    #endregion

    #region ex1
    public delegate void MyDelegate(string str);
    class Angajat //: Nimic
    {
        private MyDelegate[] del = new MyDelegate[] { Promovare.Promovat, Concediere.Concediat, Nimic.Exista };

        public string Nume { get; set; }

        public void InteractiuneAngajat(MyDelegate _del)
        {
            _del(Nume);
        }
    }

    class Promovare
    {
        public static void Promovat(string nume)
        {
            WriteLine("{0} a fost promovat", nume);
        }
    }

    class Concediere //: Promovare
    {
        public static void Concediat(string nume)
        {
            WriteLine("{0} a fost concediat", nume);
        }
    }

    class Nimic //: Concediere
    {
        public static void Exista(string nume)
        {
            WriteLine("{0} exista", nume);
        }
    }

    class Program
    {
        public static void Main()
        {
            MyDelegate del;

            Angajat angajat = new Angajat();
            angajat.Nume = "Victor";

            Random rand = new Random();
            int x = rand.Next(100);
            if (x > 75) { del = Promovare.Promovat; }
            else if (x < 50) { del = Concediere.Concediat; }
            else { del = Nimic.Exista; }

            angajat.InteractiuneAngajat(del);
        }
        #endregion
    }
}
