using System;

namespace app
{
    class Program
    {

        static void ex1()
        {
            Console.WriteLine("ex1:");
            Console.WriteLine("What's your name?");
            string name = Console.ReadLine();
            string hello = "Hello " + name;
            Console.WriteLine(hello);
        }
        static void ex2()
        {
            Console.WriteLine("\nex2:");
            int x1, x2;
            Console.Write("x1 = ");
            x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("x2 = ");
            x2 = Convert.ToInt32(Console.ReadLine());

            if(x1%x2==0)
            {
                Console.WriteLine(x2 + " este divizor pentru " + x1);
            }
            else { Console.WriteLine(x2 + " nu este divizor pentru " + x1); }
        }
        static void ex3()
        {
            Console.WriteLine("\nex3:");

            var random = new Random();
            int x = random.Next(0, 2);
            bool z;

            switch(x)
            {
                case 0: { z = false; Console.WriteLine(z); break; }
                case 1: { z = true; Console.WriteLine(z); break; }
            }
        }

        static void ex4()
        {
            Console.WriteLine("\nex4:");

            var random = new Random();
            int x = random.Next(0, 2);


            switch (x)
            {
                case 0: { Console.WriteLine("Arati rau azi!"); break; }
                case 1: { Console.WriteLine("Damn u sexy af!"); break; }
            }
        }
        static void ex5()
        {
            Console.WriteLine("\nex5:");

            string str = Console.ReadLine();

            if (str == "Vasea") { Console.WriteLine("Tu esti Vasile..."); }
        }
        static void ex6()
        {
            Console.WriteLine("\nex6:");

            for (int i = 0; i < 50; i++)
            {
                if (i % 2 == 0)
                Console.WriteLine(i);
            }
        }
        static void ex7()
        {
            Console.WriteLine("\nex7:");

            //int[] x = new int[3];
            //int[] y = new int[3];

            int[] x = { 1, 2, 3 };
            int[] y = { 3, 4, 5 };

            for(int i=0; i<x.Length; i++)
            {
                Console.Write((x[i] * y[i]) + " ");
            }
        }

        static void Main(string[] args)
        {
            ex1();
            ex2();
            ex3();
            ex4();
            ex5();
            ex6();
            ex7();
        }
    }
}

