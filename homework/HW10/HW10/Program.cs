using System;
using System.Linq;

namespace HW10
{
    //struct
    #region ex1
    //struct Numere
    //{
    //    public int[] x;

    //    public Numere(int _len)
    //    {
    //        x = new int[_len];
    //    }
    //}
    //class Program
    //{
    //    static void Main()
    //    {
    //        Random rand = new Random();

    //        Numere numere = new Numere(30);

    //        int[] max = new int[3] { 0, 0, 0 };

    //        for (int i = 0; i < numere.x.Length; i++)
    //        {
    //            if (i < 10)
    //            {
    //                numere.x[i] = rand.Next(10, 50);
    //                Console.ForegroundColor = ConsoleColor.Yellow;
    //                if (max[0] < numere.x[i]) max[0] = numere.x[i]; // nu am stium cum prin linq aici
    //            }
    //            else if (i >= 10 && i < 20)
    //            {
    //                numere.x[i] = rand.Next(100, 150);
    //                Console.ForegroundColor = ConsoleColor.Magenta;
    //                if (max[1] < numere.x[i]) max[1] = numere.x[i]; // nu am stium cum prin linq aici
    //            }
    //            else
    //            {
    //                numere.x[i] = rand.Next(1, 100);
    //                Console.ForegroundColor = ConsoleColor.Green;
    //                if (max[2] < numere.x[i]) max[2] = numere.x[i]; // nu am stium cum prin linq aici
    //            }

    //            Console.Write(numere.x[i] + " ");
    //        }

    //        Console.ForegroundColor = ConsoleColor.Red;

    //        Console.WriteLine("\nMAX(0 - 10) = " + max[0]); // nu am stium cum prin linq aici
    //        Console.WriteLine("MAX(11 - 20) = " + max[1]);  // nu am stium cum prin linq aici
    //        Console.WriteLine("MAX(21 - 30) = " + max[2]);  // nu am stium cum prin linq aici
    //        Console.WriteLine("MAX = " + numere.x.Max());

    //        Console.ForegroundColor = ConsoleColor.White;

    //    }
    //}
    #endregion

    //enum
    #region ex1
    //struct Angajat
    //{
    //    public string Nume { get; set; }

    //    public int Salariu { get; set; }

    //    public StatutAngajat Statut;

    //    public enum StatutAngajat
    //    {
    //        Activ,
    //        Concediat,
    //        Vacanta,
    //        Carantina
    //    }

    //    public Angajat(string _Nume, int _Salariu, StatutAngajat _Statut)
    //    {
    //        Nume = _Nume;
    //        Statut = _Statut;
    //        Salariu = _Salariu;
    //    }
    //}
    //class Program
    //{
    //    static void Main()
    //    {
    //        Angajat[] angajat = new Angajat[4];

    //        for (int i = 0; i < angajat.Length; i++)
    //        {
    //            angajat[i] = new Angajat("Test" + i.ToString(), (i + 1) * 1234 + 123, (Angajat.StatutAngajat)i);
    //        }

    //        for (int i = 0; i < angajat.Length; i++)
    //        {
    //            Console.WriteLine("Angajat: {0}, stare: {1}", angajat[i].Nume, angajat[i].Statut);
    //            if (angajat[i].Statut == Angajat.StatutAngajat.Activ)
    //            {
    //                Console.WriteLine("Angajatul {0} va primi salariul de {1} lei pe data de {2}", angajat[i].Nume, angajat[i].Salariu, DateTime.Now);
    //            }
    //            else if (angajat[i].Statut == Angajat.StatutAngajat.Concediat)
    //            {
    //                Console.WriteLine("Angajatul {0} a fost concediat si nu va primi salariul", angajat[i].Nume);
    //            }
    //            else if (angajat[i].Statut == Angajat.StatutAngajat.Carantina)
    //            {
    //                Console.WriteLine("Angajatul {0} este in somaj tehnic si va primi doar {1} lei", angajat[i].Nume, (angajat[i].Salariu * 0.8));
    //            }
    //        }
    //    }
    //}
    #endregion

    #region ex2
    //enum Obiecte
    //{
    //    Televizor = 3000,
    //    Masina = 1000000,
    //    Pat = 30000,
    //    Masa = 20000,
    //    Dulap = 40000,
    //    Farfurie = 250,
    //    Telefon = 200,
    //    PC = 5000,
    //    Pahar = 150
    //};
    //class Program
    //{
    //    public static void Main()
    //    {
    //        string[] str = Enum.GetNames(typeof(Obiecte));
    //        int[] x = (int[])Enum.GetValues(typeof(Obiecte));

    //        foreach (string s in str)
    //        {
    //            Console.WriteLine(s);
    //        }
    //        foreach (int i in x)
    //        {
    //            Console.WriteLine(i);
    //        }

    //        int stop;
    //        do
    //        {
    //            stop = Convert.ToInt32(Console.ReadLine());
    //            Arata(stop);
    //        } while (stop != 1337);
    //    }

    //    static void Arata(int i)
    //    {
    //        Console.WriteLine("Obiectul: {0} are masa de {1} grame", (Obiecte)i, i);
    //    }
    //}
    #endregion

    //nullable
    #region ex1
    //class Input
    //{
    //    //public Nullable<int> Integer { get; set; } | int? = Nullable<int>
    //    public int? Integer { get; set; }

    //    public Input(int? _Integer)
    //    {
    //        Integer = _Integer;
    //    }
    //}
    //class Program
    //{
    //    public static void Main()
    //    {
    //        Input[] input = new Input[10];

    //        for (int i = 0; i < input.Length; i++)
    //        {
    //            if (i % 2 == 0)  input[i] = new Input(null); 
    //            else input[i] = new Input(i);
    //        }

    //        for (int i = 0; i < input.Length; i++)
    //        {
    //            if(!input[i].Integer.HasValue) { Console.WriteLine(i + ". " + "Operatia nu este posibila"); }
    //            else { input[i].Integer *= 3; Console.WriteLine(i + ". " + input[i].Integer + " "); }
    //        }
    //    }
    //}
    #endregion

    //delegate
    #region ex1
    //class Program
    //{
    //    public delegate string MyDelegate(string str);
    //    public static void Main()
    //    {
    //        MyDelegate del1 = Extern1.Method1;
    //        MyDelegate del2 = Extern2.Method2;

    //        Console.WriteLine(del1("cuvant1 _cuvant2 __cuvant3") + " / " + del2("1cuvant _2cuvant __3cuvant"));
    //    }
    //}

    //class Extern1
    //{
    //    public static string Method1(string str)
    //    {
    //        string[] strarr = str.Split(" ");
    //        str = "";
    //        for (int i = 0; i < strarr.Length; i++)
    //        {
    //            str += strarr[i].Substring(0, 3);
    //        }
    //        return str;
    //    }
    //}
    //class Extern2
    //{
    //    public static string Method2(string str)
    //    {
    //        string[] strarr = str.Split(" ");
    //        str = "";
    //        for (int i = 0; i < strarr.Length; i++)
    //        {
    //            str += strarr[i].Substring(0, 3);
    //        }
    //        return str;
    //    }
    //}
    #endregion

    #region ex2
    //class Program
    //{
    //    public static Random rand = new Random();
    //    public delegate void MyDelegate();
    //    public static void Main()
    //    {
    //        MyDelegate[] del = new MyDelegate[4];

    //        del[1] = Met1;
    //        del[2] = Met2;
    //        del[3] = Met3;

    //        del[0] = del[1] + del[2] + del[3];

    //        char s;
    //        do
    //        {
    //            del[0]();
    //            Console.WriteLine("Press any key to continue or ESC to exit...");
    //            s = Console.ReadKey().KeyChar;
    //        } while (s != 27);
    //    }

    //    public static void Met1()
    //    {
    //        int x = rand.Next(100);

    //        Console.WriteLine(x + "^2 = " + Math.Pow(x, 2));
    //    }

    //    public static void Met2()
    //    {
    //        char[] chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();

    //        Console.WriteLine(chars[rand.Next(chars.Length)]);
    //    }

    //    public static void Met3()
    //    {
    //        Console.Beep(rand.Next(100, 10000), rand.Next(500, 2000));
    //    }
    //}
    #endregion
}
