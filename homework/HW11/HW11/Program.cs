using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace HW11
{
    #region ex1
    //public class TestClass<T, U>
    //{
    //    public string str { get; set; }

    //    public void Add(T item)
    //    {
    //            str += item.ToString();
    //    }
    //    public void Add(U item)
    //    {
    //            str += item.ToString();
    //    }

    //    public TestClass()
    //    {
    //        str = "XXX";
    //        // am vrut sa ma uit daca la constructor trebuie de indicat <>
    //        // rez: nu trebuie
    //    }
    //}
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        TestClass<char, string> obj = new TestClass<char, string>();
    //        obj.Add('a');
    //        obj.Add("_str_");
    //        obj.Add('b');
    //        obj.Add("_255_");
    //        obj.Add('s');

    //        Console.WriteLine(obj.str);
    //    }
    //}
    #endregion

    #region ex2
    //class Program
    //{
    //    static void Main()
    //    {
    //        Dictionary<char, int> obj = new Dictionary<char, int>();

    //        char[] chars = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
    //        Random rand = new Random();


    //        for (int i = 0; i < 10; i++)
    //        {
    //            X:
    //            try
    //            {
    //                obj.Add(chars[rand.Next(chars.Length)], rand.Next(25));
    //            }
    //            catch (Exception e)
    //            {
    //                goto X;
    //            }
    //        }

    //        if (obj.ContainsKey('z'))
    //        {
    //            foreach (var item in obj.Keys)
    //            {
    //                Console.Write(item + " ");
    //            }
    //        }
    //        else
    //        {
    //            foreach (var item in obj.Values)
    //            {
    //                Console.Write(item + " ");
    //            }
    //        }
    //    }
    //}
    #endregion

    #region ex3
    //class Program
    //{
    //    public static void Main(string[] args)
    //    {
    //        ArrayList arList = new ArrayList();

    //        arList.Add(1);
    //        arList.Add("Two");
    //        arList.Add(true);
    //        arList.Add(100.45);
    //        arList.Add(DateTime.Now);
    //        arList.Add(5);

    //        foreach (var data in arList)
    //        {
    //            Console.WriteLine(data.ToString());
    //            //Console.WriteLine(data.GetType());
    //            if(data.GetType() == typeof(int))
    //            {
    //                Console.ForegroundColor = ConsoleColor.Red;
    //                Console.WriteLine("int ^");
    //                Console.ResetColor();
    //            }
    //        }
    //    }
    //}

    #endregion

    #region ex4
    // ati incurcat si ati pus ex4 in document care este egal la ex2
    #endregion
}
