using System;
using System.Threading;
using System.Threading.Tasks;

#region ex1
//namespace ex1
//{
//    class Suprafata
//    {
//        private int lungime;

//        public int Lungime
//        {
//            get { return lungime; }
//            set { lungime = value; }
//        }

//        private int latime;

//        public int Latime
//        {
//            get { return latime; }
//            set { latime = value; }
//        }

//        public double Aria()
//        {
//            return lungime * latime;
//        }

//        //public static void DetaliiSuprafata(Suprafata obj)
//        //{
//        //    Console.WriteLine("Lungime: {0}, Latime: {1}, Aria: {2}", obj.lungime, obj.latime, obj.Aria());
//        //}

//        protected void DetaliiSuprafata()
//        {
//            Console.WriteLine("Lungime: {0}, Latime: {1}, Aria: {2}", lungime, latime, Aria());
//        }
//    }

//    class Comanda : Suprafata
//    {
//        private int pretPerMetru;

//        public int PretPerMetru
//        {
//            get { return pretPerMetru; }
//            set { pretPerMetru = value; }
//        }

//        public Comanda(int _lungime, int _latime, int _pretPerMetru)
//        {
//            Lungime = _lungime;
//            Latime = _latime;
//            pretPerMetru = _pretPerMetru;
//        }

//        public void DetaliiFinale()
//        {
//            DetaliiSuprafata();
//            Console.WriteLine("Pret Pentru 1 m^2: " + pretPerMetru);
//        }
//    }

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Comanda obj1 = new Comanda(5, 2, 100);
//            obj1.DetaliiFinale();
//        }
//    }
//}
#endregion

#region ex2
namespace ex2
{
    class Calcul
    {
        private int x;

        public int X
        {
            get { return x; }
            set { x = value; }
        }

        private int y;

        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        private int z;

        public int Z
        {
            get { return z; }
            set { z = value; }
        }

        public virtual float Rezultat()
        {
            return (float)Math.Sqrt(x + y + z);
        }

        //public Calcul() { }
        public Calcul(int _x, int _y, int _z)
        {
            x = _x;
            y = _y;
            z = _z;
        }
    }

    class CalculSecundar : Calcul
    {
        private int q;

        public int Q
        {
            get { return q; }
            set { q = value; }
        }

        public override float Rezultat()
        {
            return (float)base.Rezultat() + (float)Math.Pow(q, 3);
        }

        public CalculSecundar(int _q, int _x, int _y, int _z) : base(_x, _y, _z)
        {
            q = _q;
            //new Calcul(_x, _y, _z); nu lucreaza
            X = _x;
            Y = _y;
            Z = _z;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            CalculSecundar obj1 = new CalculSecundar(2, 2, 2, 5);
            Console.WriteLine(obj1.Rezultat()); // 11
            //Console.WriteLine(obj1.X);

            Calcul obj2 = new Calcul(1, 2, 1);
            Console.WriteLine(obj2.Rezultat());
        }
    }
}
#endregion

#region ex3
//namespace ex3
//{
//    abstract class CorpuriGeometrice
//    {
//        public abstract int Volum();
//    }

//    class Cub : CorpuriGeometrice
//    {
//        private int latura;

//        public int Latura
//        {
//            get { return latura; }
//            set { latura = value; }
//        }
//        public Cub(int _latura)
//        {
//            latura = _latura;
//        }

//        public override int Volum()
//        {
//            return (int)Math.Pow(latura, 3);
//        }
//    }

//    class Paralelipiped : CorpuriGeometrice
//    {
//        private int lungime;

//        public int Lungime
//        {
//            get { return lungime; }
//            set { lungime = value; }
//        }

//        private int latime;

//        public int Latime
//        {
//            get { return latime; }
//            set { latime = value; }
//        }

//        private int inaltime;

//        public int Inaltime
//        {
//            get { return inaltime; }
//            set { inaltime = value; }
//        }

//        public Paralelipiped(int _lungime, int _latime, int _inaltime)
//        {
//            lungime = _lungime;
//            latime = _latime;
//            inaltime = _inaltime;
//        }

//        public override int Volum()
//        {
//            return (inaltime * lungime * latime);
//        }
//    }

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Cub cub1 = new Cub(5);
//            Console.WriteLine(cub1.Volum());

//            Paralelipiped par1 = new Paralelipiped(5, 2, 3);
//            Console.WriteLine(par1.Volum());
//        }
//    }
//}
#endregion

#region ex4
//namespace ex4
//{
//    abstract class Calcul
//    {
//        public abstract object Rezultat();
//    }

//    class Adunare : Calcul
//    {
//        private int x1;

//        public int X1
//        {
//            get { return x1; }
//            set { x1 = value; }
//        }

//        private int x2;

//        public int X2
//        {
//            get { return x2; }
//            set { x2 = value; }
//        }

//        public Adunare(int _x1, int _x2)
//        {
//            x1 = _x1;
//            x2 = _x2;
//        }

//        public override object Rezultat()
//        {
//            return x1 + x2;
//        }
//    }

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Adunare obj1 = new Adunare(1, 2);
//            Console.WriteLine(obj1.Rezultat());

//            //object x = obj1.Rezultat();
//            //int x = (int)obj1.Rezultat();
//            //Console.WriteLine(x /*+ " / " + typeof(x)*/);
//        }
//    }
//}
#endregion

#region ex5
//namespace ex5
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            var t1 = Task.Run(() => NrRand50());
//            t1.Wait();

//            var t2 = Task.Run(() => NrRand10());
//            t2.Wait();
//        }

//        public static async Task NrRand50()
//        {
//            Random r = new Random();
//            for (int i = 0; i < 50; i++)
//            {
//                Console.Beep(1000, 1);
//                //Console.Write(1 + " ");
//                Console.Write(r.Next(50) + " ");
//                Thread.Sleep(100);
//            }
//        }

//        public static async Task NrRand10()
//        {
//            Random r = new Random();
//            for (int i = 0; i < 10; i++)
//            {
//                Console.Beep(5000, 50);
//                //Console.Write(2 + " ");
//                Console.Write(r.Next(50) + " ");
//                Thread.Sleep(500);
//            }
//        }
//    }
//}
#endregion