using System;
using static System.Console;

namespace Lectie9
{
    #region ex1
    //interface IMamifier
    //{
    //    int AvaibleFood { get; set; }
    //    void SearchFood();
    //}

    //interface IPasare
    //{
    //    int DistanceWalked { get; set; }
    //    void Walk();
    //}

    //class Pinguin : IMamifier, IPasare
    //{
    //    // Mamifier
    //    public int AvaibleFood { get; set; }
    //    public void SearchFood()
    //    {
    //        WriteLine("Searching for food...");
    //        AvaibleFood += 5;
    //    }

    //    // Pasare
    //    public int DistanceWalked { get; set; }
    //    public void Walk()
    //    {
    //        WriteLine("I am making some distance :)");
    //        DistanceWalked += 10;
    //    }
    //}

    //class Program
    //{
    //    private static void Main()
    //    {
    //        Pinguin pinguin = new Pinguin();

    //        pinguin.DistanceWalked = 0;
    //        pinguin.AvaibleFood = 0;

    //        InfoPinguin(pinguin);

    //        pinguin.SearchFood();
    //        pinguin.Walk();

    //        InfoPinguin(pinguin);
    //    }

    //    private static void InfoPinguin(Pinguin obj)
    //    {
    //        WriteLine("How much food do i have: {0}, Distance walked by me: {1}", obj.AvaibleFood, obj.DistanceWalked);
    //    }
    //}
    #endregion

    #region ex2
    //interface IMamifier
    //{
    //    int AvaibleFood { get; set; }
    //    void SearchFood();
    //}

    //interface IPasare
    //{
    //    int DistanceWalked { get; set; }
    //    void Walk();
    //}

    //class Pinguin : IMamifier, IPasare
    //{
    //    // Mamifier
    //    public int AvaibleFood { get; set; }
    //    public void SearchFood()
    //    {
    //        WriteLine("Searching for food...");
    //        AvaibleFood += 5;
    //    }

    //    // Pasare
    //    public int DistanceWalked { get; set; }
    //    public void Walk()
    //    {
    //        WriteLine("I am making some distance :)");
    //        DistanceWalked += 10;
    //    }
    //}

    //class Program
    //{
    //    private static void Main()
    //    {
    //        Pinguin pinguin = new Pinguin();

    //        pinguin.DistanceWalked = 0;
    //        pinguin.AvaibleFood = 0;

    //        IMamifier refMamifier;
    //        refMamifier = pinguin;

    //        IPasare refPasare;
    //        refPasare = pinguin;

    //        InfoPinguin(refMamifier, refPasare);

    //        refMamifier.SearchFood();
    //        refPasare.Walk();

    //        InfoPinguin(refMamifier, refPasare);
    //    }

    //    private static void InfoPinguin(IMamifier refMamifier, IPasare refPasare)
    //    {
    //        WriteLine("How much food do i have: {0}, Distance walked by me: {1}", refMamifier.AvaibleFood, refPasare.DistanceWalked);
    //    }
    //}
    #endregion

    #region ex3
    //interface I1
    //{
    //    public int P1 { get; set; }
    //    void F1();
    //}
    //interface I2
    //{
    //    public int P2 { get; set; }
    //    void F2();
    //}
    //interface I3
    //{
    //    public int P3 { get; set; }
    //    void F3();
    //}

    //class Clasa : I1, I2 
    //{
    //    public int P1 { get; set; }
    //    public void F1()
    //    {
    //        WriteLine("F1();");
    //    }

    //    public int P2 { get; set; }
    //    public void F2()
    //    {
    //        WriteLine("F2();");
    //    }
    //} 

    //class Program
    //{
    //    private static void Main()
    //    {
    //        Clasa obj = new Clasa();
    //        if(obj is I1) { WriteLine("obj.F1();"); }
    //        if(obj is I2) { WriteLine("obj.F2();"); }
    //        if(obj is I3) { WriteLine("obj.F3();"); }
    //    }
    //}
    #endregion

    #region ex4
    interface ILista
    {
        string[] Str { get; set; }

        string this[int index] { get; set; }
    }

    class Clasa : ILista
    {
        private string[] str;
        public string[] Str
        {
            get { return str; }
            set { str = value; }
        }

        public Clasa(int len)
        {
            str = new string[len];
        }

        public string this[int index]
        {
            get
            {
                if (index < 2 || index > str.Length + 1) { return str[str.Length - 1]; }
                else { return str[index - 2]; }
            }
            set
            {
                str[index] = value;
            }
        }
    }

    class Program
    {
        private static void Main()
        {
            Clasa obj = new Clasa(10);
            for (int i = 0; i < obj.Str.Length; i++)
            {
                obj[i] = i.ToString();
            }
            for (int i = -1; i <= obj.Str.Length + 2; i++)
            {
                WriteLine(i + ". " + obj[i]);
            }
        }
    }
    #endregion
}
