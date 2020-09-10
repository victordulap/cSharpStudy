using System;
using System.Reflection.Metadata.Ecma335;
using System.Threading;
using System.Threading.Tasks;

namespace HW7
{
    #region ex 1
    //struct Elev
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

    //    private float notaMedie;
    //    public float NotaMedie
    //    {
    //        get { return notaMedie; }
    //        set { notaMedie = value; }
    //    }

    //    public static async Task ShowElevInfo(Elev obj)
    //    {
    //        await Task.Run(() =>
    //        {
    //            for (int i = 0; i < obj.Nume.Length; i++)
    //            {
    //                Console.Write(obj.Nume[i]);
    //                Thread.Sleep(100);
    //            }

    //            Console.WriteLine();

    //            for (int i = 0; i < obj.Prenume.Length; i++)
    //            {
    //                Console.Write(obj.Prenume[i]);
    //                Thread.Sleep(100);
    //            }

    //            Console.WriteLine();

    //            string notmed = obj.NotaMedie.ToString();
    //            for (int i = 0; i < notmed.Length; i++)
    //            {
    //                Console.Write(notmed[i]);
    //                Thread.Sleep(100);
    //            }

    //            Console.WriteLine();
    //        });
    //    }
    //}

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Random rand = new Random();

    //        Elev[] e = new Elev[3];
    //        for (int i = 0; i < e.Length; i++)
    //        {
    //            e[i] = new Elev();
    //            e[i].Nume = "Elev" + (i + 1).ToString();
    //            e[i].Prenume = "Test" + (i + 1).ToString();
    //            e[i].NotaMedie = rand.Next(6, 11) - (rand.Next(1, 10) * 0.1f);
    //        }

    //        ShowAllElev(e);

    //        Console.ReadKey();
    //    }

    //    public static async Task ShowAllElev(Elev[] obj)
    //    {
    //        for (int i = 0; i < obj.Length; i++)
    //        {
    //            await Elev.ShowElevInfo(obj[i]);
    //            //Elev.ShowElevInfo(obj[i]); // fara await se pornesc toate 3 deodata
    //            Console.WriteLine();
    //        }
    //    }
    //}
    #endregion

    #region ex 2 
    //class Container
    //{
    //    private int[] val;
    //    public int len { private set; get; }

    //    public Container(int _lenght)
    //    {
    //        len = _lenght;
    //        val = new int[_lenght];
    //    }

    //    public int this[int _index]
    //    {
    //        get
    //        {
    //            return val[_index];
    //        }
    //        set
    //        {
    //            val[_index] = value;
    //        }
    //    }

    //    public void ShowInfo()
    //    {
    //        ShowInfo(this);
    //    }
    //    public static void ShowInfo(Container obj)
    //    {
    //        for (int i = 0; i < obj.len; i++)
    //        {
    //            //Console.Write(obj.val[i] + " ");
    //            Console.Write(obj[i] + " ");
    //        }
    //        Console.WriteLine();
    //    }
    //}

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Random rand = new Random();
    //        Container obj = new Container(10);

    //        for (int i = 0; i < obj.len; i++)
    //        {
    //            obj[i] = rand.Next(1, 10);
    //        }

    //        obj.ShowInfo();

    //        Console.WriteLine("random number from (" + nameof(obj) + "): " + obj[rand.Next(0, obj.len)]);
    //        Console.WriteLine("random number from (" + nameof(obj) + "): " + obj[rand.Next(0, obj.len)]);
    //        Console.WriteLine("random number from (" + nameof(obj) + "): " + obj[rand.Next(0, obj.len)]);
    //        Console.WriteLine("random number from (" + nameof(obj) + "): " + obj[rand.Next(0, obj.len)]);
    //        Console.WriteLine("random number from (" + nameof(obj) + "): " + obj[rand.Next(0, obj.len)]);
    //    }
    //}
    #endregion

    #region ex 3
    class Numere
    {
        private float[] val;
        public int Lenght { get; private set; }

        public Numere(int _Lenght)
        {
            Lenght = _Lenght;
            val = new float[_Lenght];
        }

        public float this[int _index]
        {
            get
            {
                return val[_index];
            }
            set
            {
                val[_index] = value;
            }
        }

        public float this[float nr]
        {
            get
            {
                for (int i = 0; i < this.Lenght; i++)
                {
                    if (val[i] == nr)
                    {
                        return i;
                    }
                }

                return -1;
            }
        }

        public void ShowInfo()
        {
            ShowInfo(this);
        }
        public static void ShowInfo(Numere obj)
        {
            for (int i = 0; i < obj.Lenght; i++)
            {
                //Console.Write(obj.val[i] + " ");
                Console.Write(obj[i] + " ");
            }
            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            Numere obj = new Numere(10);

            for (int i = 0; i < obj.Lenght; i++)
            {
                obj[i] = rand.Next(11, 100) - (rand.Next(1, 50) * 0.1f);
            }

            obj[5] = 9.99f;

            obj.ShowInfo();

            if(obj[9.99f] != -1)
            Console.WriteLine("index of 9.99 is: " + obj[9.99f] + " (starting from 0 (zero)).");
        }
    }
    #endregion
}
