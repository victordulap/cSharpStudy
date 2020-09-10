using System;
using static System.Console;

namespace Lectie9
{
    #region exemplu 1
    //interface IDispozitiv
    //{
    //    string Tip { get; set; }
    //    void Pornire();
    //    void Oprire();
    //    void Restart();
    //    void Statut();
    //}

    //class Calculator : IDispozitiv
    //{
    //    public string Tip { get; set; }
    //    private bool pornit;

    //    public void Pornire()
    //    {
    //        ForegroundColor = ConsoleColor.Green;
    //        WriteLine("\nPornire dispozitiv...");
    //        Tip = this.GetType() + "";
    //        pornit = true;
    //    }
    //    public void Oprire()
    //    {
    //        ForegroundColor = ConsoleColor.Red;
    //        WriteLine("\nOprire dispozitiv...");
    //        pornit = false;
    //    }
    //    public void Restart()
    //    {
    //        ForegroundColor = ConsoleColor.Yellow;
    //        WriteLine("\n{0} a fost restartat.", Tip);
    //    }
    //    public void Statut()
    //    {
    //        WriteLine("{0} este pornit:{1}", Tip, pornit);
    //    }

    //    private static void Main()
    //    {
    //        Calculator calc = new Calculator();
    //        calc.Pornire(); calc.Statut();
    //        calc.Oprire(); calc.Statut();
    //        calc.Restart();
    //        ReadKey();
    //    }

    //}
    #endregion

    #region ex1
    //interface IAnimal
    //{
    //    string Tip { get; set; }
    //    void FaSunet();
    //}

    //class Motan : IAnimal
    //{
    //    public string Tip { get; set; }

    //    public void FaSunet()
    //    {
    //        Beep(2000, 600);
    //        Beep(2000, 600);
    //        Beep(2000, 600);
    //    }

    //    public Motan(string _Tip)
    //    {
    //        Tip = _Tip;
    //    }
    //}

    //class Caine : IAnimal
    //{
    //    public string Tip { get; set; }

    //    public void FaSunet()
    //    {
    //        Beep(500, 600);
    //        Beep(500, 600);
    //        Beep(500, 600);
    //    }

    //    public Caine(string _Tip)
    //    {
    //        Tip = _Tip;
    //    }
    //}

    //class Soarece : IAnimal
    //{
    //    public string Tip { get; set; }

    //    public void FaSunet()
    //    {
    //        Beep(5000, 300);
    //        Beep(5000, 300);
    //        Beep(5000, 300);
    //    }

    //    public Soarece(string _Tip)
    //    {
    //        Tip = _Tip;
    //    }
    //}

    //class Program
    //{
    //    private static void Main()
    //    {
    //        WriteLine("Motan");
    //        Motan motan = new Motan("Carnivor");
    //        motan.FaSunet();

    //        WriteLine("Caine");
    //        Caine caine = new Caine("Carnivor");
    //        caine.FaSunet();

    //        WriteLine("Soarece");
    //        Soarece soarece = new Soarece("Ierbivor");
    //        soarece.FaSunet();
    //    }
    //}
    #endregion

    //pt acasa
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
    interface I1
    {
        public int P1 { get; set; }
        void F1();
    }
    interface I2
    {
        public int P2 { get; set; }
        void F2();
    }
    interface I3
    {
        public int P3 { get; set; }
        void F3();
    }

    //class Clasa : 

    class Program
    {
        private static void Main()
        {
            
        }
    }
    #endregion
}
