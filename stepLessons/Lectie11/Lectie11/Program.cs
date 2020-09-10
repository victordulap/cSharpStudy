using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading;
using static System.Console;

namespace Lectie11
{
    #region ex1
    //public delegate void MyDel(int _int);

    //public class ContBancar
    //{
    //    public event MyDel Eveniment;
    //    public int BalantaContului { get; set; }

    //    public void InteractiuneCuMijloace(int _money)
    //    {
    //        BalantaContului += _money;
    //    }
    //}

    //class Tranzactie
    //{
    //    public static void Main()
    //    {
    //        ContBancar client = new ContBancar();
    //        client.Eveniment += ExecutaTranzactie;
    //    }

    //    public static void ExecutaTranzactie(int _money)
    //    {
    //        BalantaContului += _money;
    //    }
    //}
    #endregion

    #region ex2
    //public delegate void MyDel(double _value, string _str);

    //public class Program
    //{
    //    public static void Metoda(double _value, string _str, MyDel del)
    //    {
    //        _value = (int)Math.Pow(_value, 3) / 2;
    //        _str += _str;

    //        del(_value, _str);
    //    }

    //    public static void Main()
    //    {
    //        Metoda(2, "abc", delegate (double _value, string _str)
    //        {
    //            WriteLine("value = {0}, str = {1}", _value, _str);
    //        });
    //    }
    //}
    #endregion

    #region ex1
    //class Program
    //{
    //    static void Main()
    //    {
    //        //Declaram o lista de numere int
    //        List<int> numbers1 = new List<int>() { -2, -1 };//, 0, 1, 2, 3, 4, 5 };
    //        List<int> numbers2 = new List<int>();// { 6, 7, 8, 9, 10 };

    //        List<int> numbers = new List<int>();
    //        //numbers.AddRange(numbers1);
    //        //numbers.AddRange(numbers2);
    //        numbers = numbers1.Concat(numbers2).ToList();

    //        Write("Lista numbers1: ");
    //        foreach (var value in numbers1) Write("{0} ", value);
    //        WriteLine();

    //        Write("Lista numbers2: ");
    //        foreach (var value in numbers2) Write("{0} ", value);
    //        WriteLine();

    //        Write("Lista numbers: ");
    //        foreach (var value in numbers) Write("{0} ", value);
    //        WriteLine();

    //        //var MaxImpar = numbers.FindAll(x => x % 2 != 0);
    //        //Write("MaxImpar: " + MaxImpar.Max());
    //        //WriteLine();

    //        int MaxImpar = numbers.FindAll(x => x % 2 != 0).Max();
    //        Write("MaxImpar: " + MaxImpar);
    //        WriteLine();

    //        int MinZeroPlus;
    //        try
    //        {
    //            MinZeroPlus = numbers.FindAll(x => x > 0).Min();
    //        }
    //        catch
    //        {
    //            MinZeroPlus = -1337;
    //        }
    //        Write("MaxZeroPlus: " + MinZeroPlus);
    //        WriteLine();
    //    }
    //}

    #endregion

    //event
    #region ex1


    //class Publisher
    //{
    //    public delegate void MyDel();
    //    public event MyDel MyEvent;
    //    public void StartMethod()
    //    {
    //        MyEvent?.Invoke();
    //        //MyEvent?.Invoke();  =  if(MyEvent != null) MyEvent();
    //    }
    //}

    //class Subscriber
    //{
    //    public string Str { get; set; }
    //    public Subscriber(string _Str)
    //    {
    //        Str = _Str;

    //        Publisher Event = new Publisher();
    //        Event.MyEvent += ShowStr;
    //        Event.StartMethod();
    //        Event.MyEvent -= ShowStr;
    //        //Event.StartMethod();
    //    }

    //    public void ShowStr()
    //    {
    //        Console.WriteLine(Str);
    //    }
    //}

    //class Program
    //{
    //    public static void Main()
    //    {
    //        Subscriber subscriber = new Subscriber("qwerty");
    //    }
    //}
    #endregion

    #region ex1
    //class Asteptare
    //{
    //    public delegate void MyDel();
    //    public event MyDel MyEvent;

    //    public void Method()
    //    {
    //        Console.WriteLine("Operation1");
    //        Thread.Sleep(1000);
    //        Console.Beep(500, 500);
    //        Console.WriteLine("Operation2");

    //        Console.WriteLine();
    //        Console.WriteLine("//---------------------------------------");
    //        Console.WriteLine();

    //        MyEvent?.Invoke();
    //    }
    //}

    //class Program
    //{
    //    public static void Main()
    //    {
    //        Asteptare asteptare = new Asteptare();
    //        asteptare.MyEvent += () => { Console.WriteLine("Event executed!"); };
    //        asteptare.Method();
    //    }
    //}
    #endregion

    //generica

    #region ex1
    //namespace ClasaGenerica
    //{
    //    public class TestClass<T>
    //    {
    //        T[] obj = new T[5];
    //        int count = 0;
    //        public void Add(T item)
    //        {
    //            if (count + 1 < 6)
    //            {
    //                obj[count] = item;
    //            }
    //            count++;
    //        }
    //        public T this[int index]
    //        {
    //            get { return obj[index]; }
    //            set { obj[index] = value; }
    //        }

    //        public object Maximum()
    //        {
    //            return obj.Max();
    //        }
    //    }
    //    class Program
    //    {
    //        static void Main(string[] args)
    //        {
    //            TestClass<object> intObj = new TestClass<object>();
    //            intObj.Add(1);
    //            intObj.Add(4.2f);
    //            intObj.Add(5.1f);
    //            intObj.Add(0);
    //            intObj.Add(2);
    //            //intObj.Add("asdasd");

    //            for (int i = 0; i < 5; i++)
    //                Console.WriteLine(intObj[i]);

    //            Console.WriteLine(intObj.Maximum());

    //            Console.ReadKey();
    //        }
    //    }
    //}

    #endregion

    //metode generice
    #region ex1
    //class Program
    //{
    //    static void Inlocuire<T>(T a, T b, T c)
    //    {
    //        if (a.GetType().Equals(typeof(string)))
    //        {
    //            Console.WriteLine();
    //        }
    //        else
    //        {
    //            int _a = (int)a.ToString();
    //            Console.WriteLine("{0}^2 = {1}", _a, _a * _a);
    //            Console.WriteLine();
    //            Console.WriteLine();

    //        }

    //    }
    //    static void Main(string[] args)
    //    {

    //    }
    //}

    #endregion

    //liste
    #region ex1
    class Program
    {
        static void Main()
        {
            List<char> MyList = new List<char>();

            char[] c = new char[] { 'c', 'b', 'a', 'd', 'Z' };

            MyList.AddRange(c);
            Console.WriteLine("MyList contains \'Z\'? : " + MyList.Contains('Z'));
            MyList.RemoveAll(x => x == 'a');

            MyList.Sort();

            Console.WriteLine();


            foreach (var item in MyList)
            {
                Console.WriteLine(item);
            }
        }
    }
    #endregion
}
