using System;
using System.Security.Cryptography.X509Certificates;

namespace HW6
{
    #region ex1
    //class Ex1
    //{
    //    public int numar;

    //    public Ex1(int _numar)
    //    {
    //        numar = _numar;
    //    }

    //    public static Ex1 operator -(Ex1 obj1, Ex1 obj2)
    //    {
    //        if ((obj1.numar - obj2.numar) > 0)
    //        {
    //            obj1.numar -= obj2.numar;
    //            return obj1;
    //        }
    //        else
    //        {
    //            obj1.numar = 0;
    //            return obj1;
    //        }
    //    }

    //    static void Main(string[] args)
    //    {
    //        Ex1 o1 = new Ex1(10);
    //        Ex1 o2 = new Ex1(5);

    //        Ex1 r1;
    //        r1 = o1 - o2;
    //        Console.WriteLine("o1 - o2 = " + r1.numar);

    //        Ex1 r2;
    //        r2 = o2 - o1;
    //        Console.WriteLine("o2 - o1 = " + r2.numar);
    //    }
    //}
    #endregion

    #region ex2
    //class Ex2
    //{
    //    public int numar;

    //    public Ex2(int _numar)
    //    {
    //        numar = _numar;
    //    }

    //    public static Ex2 operator ++(Ex2 obj1)
    //    {
    //        if (obj1.numar % 2 != 0)
    //        {
    //            obj1.numar += 3;
    //        }
    //        else
    //        {
    //            obj1.numar = 0;
    //        }

    //        return obj1;
    //    }

    //    static void Main(string[] args)
    //    {
    //        Ex2 o1 = new Ex2(10);
    //        Ex2 o2 = new Ex2(5);

    //        Ex2 r1;
    //        r1 = o1++;
    //        Console.WriteLine("o1++ = " + r1.numar);

    //        Ex2 r2;
    //        r2 = ++o2;
    //        Console.WriteLine("o2++ = " + r2.numar);
    //    }
    //}
    #endregion

    #region ex3
    //class Ex3
    //{
    //    public int numar;

    //    public Ex3(int _numar)
    //    {
    //        numar = _numar;
    //    }

    //    public static Ex3 operator /(Ex3 obj1, Ex3 obj2)
    //    {
    //        again:
    //        try
    //        {
    //            obj1.numar /= obj2.numar;
    //        }
    //        catch (DivideByZeroException)
    //        {
    //            obj2.numar = 1;
    //            goto again;
    //        }
    //        return obj1;
    //    }

    //    static void Main(string[] args)
    //    {
    //        Ex3 o1 = new Ex3(123);
    //        Ex3 o2 = new Ex3(0);

    //        Ex3 r1;
    //        r1 = o1 / o2;
    //        Console.WriteLine("o1 / o2 = " + r1.numar);
    //    }
    //}
    #endregion

    #region ex4
    //class Ex4
    //{
    //    public int[] numar;

    //    public Ex4(int[] _numar)
    //    {
    //        numar = _numar;
    //    }

    //    public void Show()
    //    {
    //       Show(this);
    //    }

    //    public void Show(Ex4 o1)
    //    {
    //        foreach (int i in o1.numar)
    //        {
    //            Console.Write(i + " ");
    //        }
    //        Console.WriteLine();
    //    }

    //    public static Ex4 operator *(Ex4 obj1, Ex4 obj2)
    //    {
    //        if (obj1.numar.Length == obj2.numar.Length)
    //        {
    //            if (obj1.numar.Length % 2 == 0)
    //            {
    //                for (int i = 0; i < obj1.numar.Length; i++)
    //                {
    //                    if ((i + 1) % 2 != 0)
    //                    {
    //                        obj1.numar[i] = obj1.numar[i] * obj2.numar[i + 1];
    //                    }
    //                    else
    //                    {
    //                        obj1.numar[i] = obj1.numar[i] * obj2.numar[i - 1];
    //                    }
    //                }
    //            }
    //            else
    //            {
    //                for (int i = 0; i < obj1.numar.Length; i++)
    //                {
    //                    if (((i + 1) % 2 != 0) && (i + 1) == obj1.numar.Length)
    //                    {
    //                        obj1.numar[i] = obj1.numar[i] * obj2.numar[i];
    //                    }
    //                    else if ((i + 1) % 2 != 0)
    //                    {
    //                        obj1.numar[i] = obj1.numar[i] * obj2.numar[i + 1];
    //                    }
    //                    else if ((i + 1) % 2 == 0)
    //                    {
    //                        obj1.numar[i] = obj1.numar[i] * obj2.numar[i - 1];
    //                    }
    //                }
    //            }
    //        }

    //        return obj1;
    //    }

    //    static void Main(string[] args)
    //    {
    //        Ex4 o1 = new Ex4(new int[] { 2, 3, 4, 5, 6 });
    //        o1.Show();

    //        Ex4 o2 = new Ex4(new int[] { 6, 5, 4, 3, 2 });
    //        o2.Show();

    //        o1 = o1 * o2;

    //        o1.Show();
    //    }
    //}
    #endregion

    #region ex5
    //class Ex5
    //{
    //    public int numarOrdine;
    //    public int valoare;

    //    public Ex5(int _numarOrdine, int _valoare)
    //    {
    //        numarOrdine = _numarOrdine;
    //        valoare = _valoare;
    //    }

    //    public static bool operator ==(Ex5 obj1, Ex5 obj2)
    //    {
    //        if((obj1.numarOrdine == obj2.numarOrdine) && (obj1.valoare == obj2.valoare))
    //        {
    //            return true;
    //        }
    //        else
    //        {
    //            return false;
    //        }
    //    }
    //    public static bool operator !=(Ex5 obj1, Ex5 obj2)
    //    {
    //        if ((obj1.numarOrdine == obj2.numarOrdine) && (obj1.valoare == obj2.valoare))
    //        {
    //            return false;
    //        }
    //        else
    //        {
    //            return true;
    //        }
    //    }

    //    static void Main(string[] args)
    //    {
    //        Ex5 o1 = new Ex5(1, 2);
    //        Ex5 o2 = new Ex5(1, 2);

    //        Console.WriteLine("o1 == o2? : " + (o1 == o2));

    //        Ex5 o3 = new Ex5(2, 2);
    //        Ex5 o4 = new Ex5(1, 2);

    //        Console.WriteLine("o3 == o4? : " + (o3 == o4));
    //    }
    //}
    #endregion

    #region ex6
    //class Ex6
    //{
    //    public int valoare1;
    //    public int valoare2;

    //    public Ex6(int _valoare1, int _valoare2)
    //    {
    //        valoare1 = _valoare1;
    //        valoare2 = _valoare2;
    //    }

    //    public static bool operator true(Ex6 obj1)
    //    {
    //        if (obj1.valoare1 == obj1.valoare2)
    //        {
    //            return true;
    //        }
    //        else
    //        {
    //            return false;
    //        }
    //    }
    //    public static bool operator false(Ex6 obj1)
    //    {
    //        if (obj1.valoare1 == obj1.valoare2)
    //        {
    //            return true;
    //        }
    //        else
    //        {
    //            return false;
    //        }
    //    }

    //    static void Main(string[] args)
    //    {
    //        Ex6 o1 = new Ex6(2, 2);
    //        Ex6 o2 = new Ex6(1, 2);

    //        if (o1) { Console.WriteLine("true (o1): " + true); }
    //        else { Console.WriteLine("true (o1): " + false); }

    //        if (o2) { Console.WriteLine("true (o2): " + true); }
    //        else { Console.WriteLine("true (o2): " + false); }
    //    }
    //}
    #endregion

    #region ex7
    //class Ex7
    //{
    //    public int valoare1;
    //    public int valoare2;
    //    public int valoare3;

    //    public Ex7(int _valoare1, int _valoare2, int _valoare3)
    //    {
    //        valoare1 = _valoare1;
    //        valoare2 = _valoare2;
    //        valoare3 = _valoare3;
    //    }

    //    public static explicit operator double(Ex7 obj)
    //    {
    //        return Math.Sqrt(Math.Pow((obj.valoare1 + obj.valoare2 + obj.valoare3), 3));
    //    }

    //    static void Main(string[] args)
    //    {
    //        Ex7 o1 = new Ex7(2, 3, 4);

    //        double rez = (double)o1;

    //        Console.WriteLine(rez);
    //    }
    //}
    #endregion
}
