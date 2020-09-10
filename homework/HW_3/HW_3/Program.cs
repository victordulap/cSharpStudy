using System;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

class Program
{
    //ex 1 declarations:
    public static void Plus(ref int nr)
    {
        Random rand = new Random();
        nr += rand.Next(1, 100);
    }
    public static void Minus(ref int nr)
    {
        Random rand = new Random();
        nr -= rand.Next(1, 100);
    }
    public static void Multiply(ref int nr)
    {
        Random rand = new Random();
        nr *= rand.Next(1, 100);
    }
    public static void Divide(ref int nr)
    {
        Random rand = new Random();
        nr /= rand.Next(1, 100);
    }

    //ex 2 declarations:
    public class Ex2
    {
        /*private*/
        public static int TotalObj/*totalObj*/ = 0;
        //public int TotalObj { get; private set; } = totalObj;

        //a
        private int a;
        public int A
        {
            get { return a; }
            set { a = value; }
        }

        private int b;
        public int B
        {
            get { return b; }
            set { b = value; }
        }

        private int c;
        public int C
        {
            get { return c; }
            set { c = value; }
        }

        public Ex2(int _A, int _B, int _C)
        {
            A = _A;
            B = _B;
            C = _C;
            TotalObj++;
        }
    }

    //ex 3 declarations:
    public static string Concat(string str1, string str2)
    {
        string str;

        str = str1 + str2;

        return str;
    }

    public static string RandStr(int len)
    {
        Random rand = new Random();

        string str = "";

        const string chars = "abcdefghijklmnopqrstvwxyz ABCDEFGHIJKLMNOPQRSTUVWXYZ 0123456789";

        for (int i = 0; i < len; i++)
        str += chars[rand.Next(0, chars.Length)];

        return str;
    }

    //ex 4 declatarions:
    public class Ex4
    {
        int number;
        string str;
        float real;

        public Ex4()
        {
            number = 0;
            str = "0";
            real = 0f;

            Console.WriteLine("Executed Constructor 1.");
        }
        public Ex4(int defaultValue)
        {
            this.number = defaultValue;
            this.str = defaultValue.ToString();
            this.real = defaultValue;

            Console.WriteLine("Executed Constructor 2.");
        }
        public Ex4(int _number, string _str, float _real)
        {
            number = _number;
            str = _str;
            real = _real;

            Console.WriteLine("Executed Constructor 3.");
        }

        public void ShowInfo(Ex4 Obj)
        {
            Console.WriteLine("Info of obj: number = {0}, str = {1}, real = {2}", Obj.number, Obj.str, Obj.real);
        }

        public void ShowInfo()
        {
            ShowInfo(this);
        }
    }

    private static void Main()
    {
        //ex 1:
        //Random rand = new Random();
        //int X = 10;

        //Plus(ref X);
        //Console.WriteLine("+: X = {0}", X);

        //Minus(ref X);
        //Console.WriteLine("-: X = {0}", X);

        //Multiply(ref X);
        //Console.WriteLine("*: X = {0}", X);

        //Divide(ref X);
        //Console.WriteLine("/: X = {0}", X);

        //----------------------------------------------------------------------------------------------------------------------------------

        //ex 2:
        //Ex2 Obj1 = new Ex2(1, 2, 3);
        //Console.WriteLine(nameof(Obj1) + ": a = {0}, b = {1}, c = {2}", Obj1.A, Obj1.B, Obj1.C + "; Total objects of " + nameof(Ex2) + ": " + Ex2.TotalObj);

        //Ex2 Obj2 = new Ex2(4, 5, 6);
        //Console.WriteLine(nameof(Obj2) + ": a = {0}, b = {1}, c = {2}", Obj2.A, Obj2.B, Obj2.C + "; Total objects of " + nameof(Ex2) + ": " + Ex2.TotalObj);

        //----------------------------------------------------------------------------------------------------------------------------------

        //ex 3:
        //Console.Write("enter str1: ");
        //string str1 = RandStr(69);//Console.ReadLine();

        //Console.Write("enter str2: ");
        //string str2 = RandStr(69);//Console.ReadLine();

        //string str3 = Concat(str1, str2);
        //Console.WriteLine("str1 + str2 = {0}", str3);

        //----------------------------------------------------------------------------------------------------------------------------------

        //ex 4:
        //Ex4 Obj1 = new Ex4();
        //Obj1.ShowInfo();

        //Ex4 Obj2 = new Ex4(1337);
        //Obj2.ShowInfo();

        //Ex4 Obj3 = new Ex4(1, "2", 3.4f);
        //Obj3.ShowInfo();

        //ex 5:
        Ex5 Obj1 = new Ex5("TEST");
        Console.WriteLine(Obj1.mesaj);
        //Obj1.mesaj = "s"; nu putem pentru ca setteru ii private
    }
}

//ex 5 declarations:
public class Ex5
{ 
     public string mesaj { get; private set; }
     //private string mesaj { public get; set; } da asa nu lucreaza pentru ca nu putem face din private -> public

    public Ex5(string str)
    {
        mesaj = str;
    }
}


