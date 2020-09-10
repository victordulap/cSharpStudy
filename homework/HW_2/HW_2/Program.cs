using Microsoft.VisualBasic.FileIO;
using System;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

public class Program
{
    private enum Meteo
    {
        Senin,
        InNourat,
        Posomorat,
        Ceata,
        Ploaie,
        Ninsoare
    }

    public static void ex1()
    {
        Console.WriteLine(" --- --- EX.1 --- ---");
        Meteo met = Meteo.Senin;
        int metLen = Enum.GetNames(typeof(Meteo)).Length;

        //rand
        var rand = new Random();
        int xxx;
        do
        {
            xxx = rand.Next(0, metLen);

            met = (Meteo)xxx;

            Console.WriteLine(met);

            Console.WriteLine("Press anykey to continue or ESC to exit");
        }
        while (Console.ReadKey().KeyChar != 27);
    }


    public static void ex2()
    {
        Console.WriteLine("\n --- --- E"); // trebuie sa pun asta ca sa se afiseze randu 44 normal, idk
        Console.WriteLine("\n --- --- EX.2 --- ---"); // nu stiu dc imi afiseaza "X.2 --- ---" in loc de " --- --- EX.2 --- ---" daca se executa ex1 inainte de asta... cred ca de la while (Console.ReadKey().KeyChar != 27); dar nu vreau sa schimb
        var car = new[]
        {
            new { denumire = "Lada 7", pret = 696969, nr_usi = 4, speed = 1337, year = 1999 },
            new { denumire = "Caruta", pret = 75, nr_usi = 1, speed = 5, year = 1960 }
        };
        for (int i = 0; i < car.Length; i++)
        {
            ex2show(car[i].denumire, car[i].pret, car[i].nr_usi, car[i].speed, car[i].year);
        }
        
    }

    public static void ex2show(string denumire, int pret, int nr_usi, int speed, int year)
    {
        Console.WriteLine("Car: " + denumire + " (" + year + ")" + ", price: " + pret + "$, doors: " + nr_usi + ", max. speed: " + speed + " km/h");
    }

    public struct PC
    {
        public string Denumire;
        public int CPU;
        public int RAM;
        public int VideoMem;
        public int Pret;

        public PC(string Denumire, int CPU, int RAM, int VideoMem)
        {
            this.Denumire = Denumire;
            this.CPU = CPU;
            this.RAM = RAM;
            this.VideoMem = VideoMem;
            this.Pret = (CPU + RAM + VideoMem) * 7;
        }
    }

    public static void ex3()
    {
        Console.WriteLine("\n --- --- EX.3 --- ---");
        //PC comp = new PC("Mac", 8, 16, 4);
        PC[] comp = new PC[5];

        var rand = new Random();
        int cpu, ram, vram;
        for (int i = 0; i < comp.Length; i++)
        {
            cpu = rand.Next(1, 65);
            ram = rand.Next(1, 65);
            vram = rand.Next(1, 65);

            comp[i] = new PC("PC", cpu, ram, vram);

            Console.WriteLine("Denumire: " + comp[i].Denumire + ", CPU: " + comp[i].CPU + ", RAM: " + comp[i].RAM + ", VRAM: " + comp[i].VideoMem + ", PRICE: " + comp[i].Pret + "$");
        }

        // sortarea mii era cam lene sa o fac manual
    }

    public static void ex4()
    {
        Console.WriteLine("\n --- --- EX.4 --- ---");
        string cuv, temp;
        int i = 0;
        Random rnd = new Random();
        char c = Convert.ToChar(rnd.Next(97,123));

        //Console.WriteLine("\n YOU WON! the letter was: " + c);

        do
        {
            Console.Write("attemp: " + (i+1) + "/15, enter cuvant: ");
            cuv = Console.ReadLine();
            i++;
            temp = cuv.ToLower();
            if (i == 15) { Console.WriteLine("\n YOU LOST! the letter was: " + c); return; }
        }
        while ( temp[0] != c /* || i != 15 nu lucreaza, dc? nustiu */) ;

        //if (i < 15)
        //{
            Console.WriteLine("\n YOU WON! the letter was: " + c);
        //}
        //else
        //{
        //    Console.WriteLine("\n YOU LOST! the letter was: " + c);
        //}
    }

    public static void ex5()
    {
        Console.WriteLine("\n --- --- EX.5 --- ---");

        int n;
        Console.Write("enter n: "); n = Convert.ToInt32(Console.ReadLine());
        
        int[] arr1 = new int[n];
        int[] arr2 = new int[n];

        Random rnd = new Random();


        for (int i = 0; i < arr1.Length; i++)
            arr1[i] = rnd.Next(0, 11);
        for (int i = 0; i < arr2.Length; i++)
            arr2[i] = rnd.Next(0, 11);

        for (int i = 0; i < arr1.Length; i++)
            Console.Write(" " + arr1[i]);

        Console.Write("\n");

        for (int i = 0; i < arr2.Length; i++)
            Console.Write(" " + arr2[i]);
        //foreach(int x in arr)
        //{
        //    Console.Write(" " + x);
        //}

        int X = rnd.Next(0, 11);

        if (arr1.Contains(X))
        {
            Console.WriteLine("\narray1 " + nameof(arr1) + " contains " + X);
        }
        
        else
        {
            Console.WriteLine("\narray1 " + nameof(arr1) + " does not contain " + X);
        }
        if (arr2.Contains(X))
        {
            Console.WriteLine("\narray2 " + nameof(arr2) + " contains " + X);
        }

        else
        {
            Console.WriteLine("\narray2 " + nameof(arr2) + " does not contain " + X);
        }


        Console.WriteLine("\narray1 " + nameof(arr1) + "\'s average is: " + arr1.Average());
        Console.WriteLine("\narray2 " + nameof(arr2) + "\'s average is: " + arr2.Average());

        Console.WriteLine("array1 " + nameof(arr1) + "\'s maximum is: " + arr1.Max() + ", but the minimum is: " + arr1.Min());
        Console.WriteLine("array2 " + nameof(arr2) + "\'s maximum is: " + arr2.Max() + ", but the minimum is: " + arr2.Min());
    
        if(arr2.Contains(arr1.Max()))
        {
            Console.WriteLine("array " + nameof(arr2) + " constains "+ nameof(arr1) + "\'s maximum ("+arr1.Max()+")" );
        }
        else
        {
            Console.WriteLine("array " + nameof(arr2) + " does not constain " + nameof(arr1) + "\'s maximum (" + arr1.Max() + ")");
        }

        if(arr1.Max() == arr2.Max())
        {
            int[] arr3 = new int[arr1.Length + arr2.Length];
            arr1.CopyTo(arr3, 0);
            arr2.CopyTo(arr3, arr1.Length);

            Console.WriteLine("array 3:");
            for (int i = 0; i < arr3.Length; i++)
                Console.Write(" " + arr3[i]);
        }
    }

    public static void ex6()
    {
        Console.WriteLine("\n --- --- EX.5 --- ---");

        string str1 = "Jora Vasea";
        string str2 = "Vasea Jora";

        Random rnd = new Random();

        while(true)
        {
            int rnd1 = rnd.Next(0, str1.Length-4);
            int rnd2 = rnd.Next(0, str2.Length-4);

            Console.WriteLine("str1 = " + str1.Substring(rnd1, 5) + ", str2 = " + str2.Substring(rnd2, 5));

            if (string.Equals(str1.Substring(rnd1, 5), str2.Substring(rnd2, 5)) /*str1[rnd1] == str2[rnd2]*/)
            {
                Console.WriteLine("Cuvintul Vasea are pozitia de start " + rnd1 + " in str1 si " + rnd2 + " in str2");
                break;
            }
            else
            {
                Console.WriteLine("Cuvintul egal nu a fost inca gasit.");
                Console.ReadKey();
            }
        }

        //daca cinsitit nu am prea inteles conditia la ex. acesta dar cumva am facut ceva
    }

    public static void ex7()
    {
        Random rand = new Random();

        int n = 10;
        var loc = new int[n][];
        //int[][] loc = new int[n][];

        //loc[0] = new int[rand.Next(1, 11)];
        //loc[1] = new int[rand.Next(1, 11)];
        //loc[2] = new int[rand.Next(1, 11)];
        //loc[3] = new int[rand.Next(1, 11)];
        //loc[4] = new int[rand.Next(1, 11)];
        //loc[5] = new int[rand.Next(1, 11)];
        //loc[6] = new int[rand.Next(1, 11)];
        //loc[7] = new int[rand.Next(1, 11)];
        //loc[8] = new int[rand.Next(1, 11)];
        //loc[9] = new int[rand.Next(1, 11)];

        for (int i = 0; i < loc.Length; i++)
        {
            loc[i] = new int[rand.Next(1, 11)];
            for (int j = 0; j < loc[i].Length; j++)
            {
                loc[i][j] = rand.Next(0,2);
            }
        }

        for (int i = 0; i < loc.Length; i++)
        {
            for (int j = 0; j < loc[i].Length; j++)
            {
                Console.Write(loc[i][j] + " ");
            }
            Console.Write("\n");
        }

        int profit = 0;
        int seats = 0;
        int ocup = 0;
        foreach(int item in loc.SelectMany(i => i)) // nu stiu ce inseamna SelectMany(i => i), daca o sa puteti sa-mi lamuriti la next lectie
        {
            if (item == 1) { profit += 100; ocup++; }
            else { profit -= 50; }
            seats++;
        }

        Console.WriteLine("profit: " + profit);
        Console.WriteLine("seats: " + seats + ", ocupated: " + ocup + ", free: " + (seats - ocup));

        // aici foarte mult am incercat sa bag prin for in jagged array; am ajuns la concluzia ca trebuie sa
        // bag atributia de memorie si asign la values tot intr-un for
    }

    public static void ex8()
    {
        string text = "Sandu: Plahotniuc l-a facut pe Dodon presedinte. Degraba il va urma Relatiile dintre politicienii din R.Moldova devin tot mai tensionate pe zi ce trece. Lidera PAS, Maia Sandu, l-a acuzat pe seful statului de mai multe pacate.";
        string[] cuvintePozitive = { "bine", "premiu", "ajutor" };
        string[] cuvinteNegative = { "pandemie", "deces", "crima", "Dodon", "Plahotniuc" };

        int nrCuvintePozitive = 0;
        int nrCuvinteNegative = 0;

        string[] cuvinte = text.Split(' ');

        //Console.WriteLine("text: " + text);
        //Console.Write("cuvinte: ");
        foreach (string cuv in cuvinte)
        {
            //Console.WriteLine(cuv);
            if(cuvintePozitive.Contains(cuv))
            {
                nrCuvintePozitive++;
            }
            else if(cuvinteNegative.Contains(cuv))
            {
                nrCuvinteNegative++;
            }
        }

        Console.WriteLine("text.Split(' ').Length = "+ text.Split(' ').Length);

        float sentimentulPozitiv = nrCuvintePozitive / text.Split(' ').Length;
        float sentimentulNegativ = nrCuvinteNegative / text.Split(' ').Length;

        if (sentimentulPozitiv > sentimentulNegativ) { Console.WriteLine("\n\tStirea este pozitiva"); }
        else { Console.WriteLine("\n\tStirea este negativa"); }
    }

    public static void Main()
    {
        // ex 1
        ex1();

        //ex 2
        ex2();

        //ex 3
        ex3();

        //ex 4
        ex4();

        //ex 5
        ex5();

        //ex 6
        ex6();

        //ex 7
        ex7();

        //ex 8
        ex8();
    }
}

