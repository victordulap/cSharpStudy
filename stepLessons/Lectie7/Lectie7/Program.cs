using System;
using System.Windows.Markup;
using static System.Console;

//pentru async
using System.Threading;
using System.Threading.Tasks;

namespace Lectie7
{
    #region exemplu 1
    //class Proprietate
    //{
    //    private int x = 10;
    //    public int X
    //    {
    //        get { return x; }
    //        set { x = value; }
    //    }
    //}

    //class Executie
    //{
    //    static void Main()
    //    {
    //        Proprietate prop = new Proprietate();
    //        WriteLine(prop.X);
    //        prop.X = 5;
    //        WriteLine(prop.X);
    //    }
    //}
    #endregion

    #region ex1
    //class Persoana
    //{
    //    private string nume;
    //    public string Nume
    //    {
    //        get { return nume; }
    //        set { nume = value; }
    //    }

    //    private string prenume;
    //    public string Prenume
    //    {
    //        get { return prenume; }
    //        set { prenume = value; }
    //    }

    //    private int cod = 10;
    //    public int Cod
    //    {
    //        get { return cod; }
    //        set { cod = value; }
    //    }

    //}

    //class Executie
    //{
    //    static void Main()
    //    {
    //        Persoana p1 = new Persoana();
    //        p1.Nume = "Pers1";
    //        p1.Prenume = "Test1";
    //        p1.Cod = 111;
    //        ForegroundColor = ConsoleColor.DarkBlue;
    //        WriteLine("p1: {0} {1} ({2})", p1.Nume, p1.Prenume, p1.Cod);

    //        Persoana p2 = new Persoana();
    //        p2.Nume = "Pers2";
    //        p2.Prenume = "Test2";
    //        p2.Cod = 222;
    //        ForegroundColor = ConsoleColor.Magenta;
    //        WriteLine("p2: {0} {1} ({2})", p2.Nume, p2.Prenume, p2.Cod);

    //        Persoana p3 = new Persoana();
    //        p3.Nume = "Pers3";
    //        p3.Prenume = "Test3";
    //        p3.Cod = 333;
    //        ForegroundColor = ConsoleColor.DarkYellow;
    //        WriteLine("p3: {0} {1} ({2})", p3.Nume, p3.Prenume, p3.Cod);

    //        ForegroundColor = ConsoleColor.White;
    //    }
    //}
    #endregion

    #region ex2
    //class Persoana
    //{
    //    public string Nume{ get; set; }

    //    public string Prenume { get; set; }

    //    public int Cod { get; set; }
    //}

    //class Executie
    //{
    //    static void Main()
    //    {
    //        Persoana p1 = new Persoana();
    //        p1.Nume = "Pers1";
    //        p1.Prenume = "Test1";
    //        p1.Cod = 111;
    //        ForegroundColor = ConsoleColor.DarkBlue;
    //        WriteLine("p1: {0} {1} ({2})", p1.Nume, p1.Prenume, p1.Cod);

    //        Persoana p2 = new Persoana();
    //        p2.Nume = "Pers2";
    //        p2.Prenume = "Test2";
    //        p2.Cod = 222;
    //        ForegroundColor = ConsoleColor.Magenta;
    //        WriteLine("p2: {0} {1} ({2})", p2.Nume, p2.Prenume, p2.Cod);

    //        Persoana p3 = new Persoana();
    //        p3.Nume = "Pers3";
    //        p3.Prenume = "Test3";
    //        p3.Cod = 333;
    //        ForegroundColor = ConsoleColor.DarkYellow;
    //        WriteLine("p3: {0} {1} ({2})", p3.Nume, p3.Prenume, p3.Cod);

    //        ForegroundColor = ConsoleColor.White;
    //    }
    //}

    //-------------------------------------------------------------

    //class Persoana
    //{
    //    public string Nume { get; set; }

    //    public string Prenume { get; set; }

    //    public int Cod { get; set; }
    //}

    //class Executie
    //{
    //    static void Main()
    //    {
    //        Persoana[] p = new Persoana[3];

    //        for(int i = 0; i < p.Length; i++)
    //        {
    //            p[i] = new Persoana();
    //        }

    //        p[0].Nume = "Pers1";
    //        p[0].Prenume = "Test1";
    //        p[0].Cod = 111;

    //        p[1].Nume = "Pers2";
    //        p[1].Prenume = "Test2";
    //        p[1].Cod = 222;

    //        p[2].Nume = "Pers3";
    //        p[2].Prenume = "Test3";
    //        p[2].Cod = 333;

    //        ForegroundColor = ConsoleColor.Magenta;

    //        for (int i = 0; i < p.Length; i++)
    //        {
    //            WriteLine("p[{3}]: {0} {1} ({2})", p[i].Nume, p[i].Prenume, p[i].Cod, i);
    //        }

    //        ForegroundColor = ConsoleColor.White;
    //    }
    //}
    #endregion

    #region exemplu indexator
    //class Indexator
    //{
    //    private string[] valori = new string[3];

    //    public string this[int _index]
    //    {
    //        get
    //        {
    //            return valori[_index];
    //        }
    //        set
    //        {
    //            valori[_index] = value;
    //        }
    //    }
    //}

    //class Executie
    //{
    //    public static void Main()
    //    {
    //        Indexator[] index = new Indexator[3];

    //        for(int i = 0; i < index.Length; i++)
    //        {
    //            index[i] = new Indexator();
    //        }

    //        index[0][0] = "cuvint1";
    //        index[0][1] = "cuvint2";
    //        index[0][2] = "cuvint3";

    //        WriteLine("Valoare 1: {0}", index[0][0]);
    //        WriteLine("Valoare 2: {0}", index[0][1]);
    //        WriteLine("Valoare 3: {0}", index[0][2]);
    //    }
    //}
    #endregion

    #region ex1
    //class Tranzactii
    //{
    //    private static int vals = 0;
    //    public int Vals
    //    {
    //        get { return vals; }
    //        private set { vals = value; }
    //    }


    //    private int[] tranz = new int[3];

    //    public int this[int _index]
    //    {
    //        get
    //        {
    //            return tranz[_index];
    //        }
    //        set
    //        {
    //            tranz[_index] = value;
    //        }
    //    }

    //    public Tranzactii()
    //    {
    //        vals++;
    //    }
    //}

    //class Executie
    //{
    //    public static void Main()
    //    {
    //        Tranzactii[] index = new Tranzactii[3];

    //        for (int i = 0; i < index.Length; i++)
    //        {
    //            index[i] = new Tranzactii();

    //            index[i][0] = 1000 * (i + i * i + 100);
    //            index[i][1] = 2000 * (i + i * i + 100);
    //            index[i][2] = 3000 * (i + i * i + 100);
    //        }

    //        int max = 0;
    //        for (int i = 0; i < index.Length; i++)
    //        {
    //            for (int j = 0; j < index[i].Vals; j++)
    //            {
    //                WriteLine("Valoare : {0}", index[i][j]);

    //                if (max < index[i][j]) max = index[i][j];
    //            }
    //            WriteLine();
    //        }

    //        WriteLine("Max = " + max);

    //    }

    //}
    #endregion

    #region async

    //class Program
    //{
    //    static void Main()
    //    {
    //        Method1();
    //        Method2();
    //        ReadKey();
    //    }

    //    public static async Task Method1()
    //    {
    //        await Task.Run(() =>
    //        {
    //            for (int i = 0; i < 20; i++)
    //            {
    //                Write("1");
    //                Thread.Sleep(100);
    //            }
    //        });
    //    }

    //    public static async Task Method2()
    //    {
    //        await Task.Run(() =>
    //        {
    //            for (int i = 0; i < 20; i++) Write("2");
    //        });
    //    }
    //}

    class Program
    {
        static void Main()
        {
            MetodaGeneral();
            ReadKey();
        }

        public static async Task MetodaGeneral()
        {
            await Method3();
            await Method2();
            await Method1();
            await Start();
        }

        public static async Task Method3()
        {
            await Task.Run(() =>
            {
                WriteLine("3");
                Beep();
                Thread.Sleep(1000);
            });
        }

        public static async Task Method2()
        {
            await Task.Run(() =>
            {
                WriteLine("2");
                Beep();
                Thread.Sleep(1000);
            });
        }

        public static async Task Method1()
        {
            await Task.Run(() =>
            {
                WriteLine("1");
                Beep();
                Thread.Sleep(1000);
            });
        }

        public static async Task Start()
        {
            await Task.Run(() =>
            {
                WriteLine("Start!");
                Beep(100, 10000);
            });
        }
    }


    #endregion
}
