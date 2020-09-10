using System;
using System.Threading;
using static System.Console;

namespace IntroducereMostenire
{
    #region exemplu 1
    //class MarcaAuto
    //{
    //    protected string marcaNume;

    //    public void Claxon()
    //    {
    //        Beep(400, 1000);
    //        Thread.Sleep(200);
    //        Beep(400, 1000);
    //    }
    //}
    //class ModelAuto : MarcaAuto
    //{
    //    private string modelNume;
    //    public string Model
    //    {
    //        get { return modelNume; }
    //    }
    //    public string Marca
    //    {
    //        get { return marcaNume; }
    //    }

    //    public ModelAuto(string _marca, string _model)
    //    {
    //        marcaNume = _marca;
    //        modelNume = _model;
    //    }
    //}

    //class Program
    //{
    //    static void Main()
    //    {
    //        ModelAuto myCar = new ModelAuto("Audi", "A6");
    //        WriteLine(myCar.Marca + " " + myCar.Model);
    //        myCar.Claxon();
    //    }
    //}
    #endregion

    #region ex1
    //class User
    //{
    //    protected int id;

    //    public int Id
    //    {
    //        get { return id; }
    //    }

    //    protected string password;

    //    public string Password
    //    {
    //        get { return password; }
    //    }

    //    public void DateUser()
    //    {
    //        WriteLine("ID-ul: {0} are parola: {1}", id, password);
    //    }
    //}

    //class UtilizatorInregistrat : User
    //{
    //    private string username;

    //    public string Username
    //    {
    //        get { return username; }
    //    }

    //    public UtilizatorInregistrat(int _id, string _username, string _password)
    //    {
    //        id = _id;
    //        username = _username;
    //        password = _password;
    //    }

    //    public void Logare()
    //    {
    //        Console.WriteLine("Utilizatorul " + username + " logat cu succes");
    //        DateUser();
    //    }

    //}

    //class Program
    //{
    //    static void Main()
    //    {
    //        UtilizatorInregistrat obj = new UtilizatorInregistrat(1337, "_user_", "_pass_");

    //        obj.Logare();
    //    }
    //}
    #endregion

    #region exemplu 2
    //public class Utilizator
    //{
    //    public string nume = "Vasile Qwerty";
    //    public string locatie = "Cojusna";
    //    public int varsta = 15;

    //    public virtual void Informatii()
    //    {
    //        WriteLine("Nume: {0}", nume);
    //        WriteLine("Locatie: {0}", locatie);
    //    }
    //}

    //public class Detalii : Utilizator
    //{
    //    public override void Informatii()
    //    {
    //        base.Informatii();
    //        WriteLine("Virsta: {0}", varsta);
    //    }
    //}

    //class Program
    //{
    //    static void Main()
    //    {
    //        Detalii detalii1 = new Detalii();
    //        detalii1.Informatii();
    //    }
    //}
    #endregion

    #region ex 1
    //class Imobil
    //{
    //    protected int suprafata;

    //    public int Suprafata
    //    {
    //        get { return suprafata; }
    //    }

    //    protected int pret;

    //    public int Pret
    //    {
    //        get { return pret; }
    //        set { pret = value; }
    //    }

    //    protected int nrCamere;

    //    public int NrCamere
    //    {
    //        get { return nrCamere; }
    //        set { nrCamere = value; }
    //    }

    //    public virtual void DateImobil()
    //    {
    //        Console.WriteLine("Imobilul dat are suprafata: {0}, {1} camere și prețul {2}", suprafata, nrCamere, pret);
    //    }
    //}

    //class Apartament : Imobil
    //{
    //    private string adresa;

    //    public string Adresa
    //    {
    //        get { return adresa; }
    //        set { adresa = value; }
    //    }

    //    private string vanzator;

    //    public string Vanzator
    //    {
    //        get { return vanzator; }
    //        set { vanzator = value; }
    //    }

    //    private string nrTelefon;

    //    public string NrTelefon
    //    {
    //        get { return nrTelefon; }
    //        set { nrTelefon = value; }
    //    }

    //    public override void DateImobil()
    //    {
    //        base.DateImobil();
    //        Console.WriteLine("Apartamentul este pe: {0}, {1} vanzator, tel: {2}", adresa, vanzator, nrTelefon);
    //    }

    //    public Apartament(int _suprafata, int _pret, int _nrCamere, string _adresa, string _vanzator, string _nrTelefon)
    //    {
    //        suprafata = _suprafata;
    //        pret = _pret;
    //        nrCamere = _nrCamere;
    //        adresa = _adresa;
    //        vanzator = _vanzator;
    //        nrTelefon = _nrTelefon;
    //    }
    //}

    //class Program
    //{
    //    static void Main()
    //    {
    //        Apartament obj = new Apartament(100, 123123, 3, "str. qwerty 999", "abraham", "+37300000001");
    //        obj.DateImobil();
    //    }
    //}
    #endregion


    namespace BoxingUnboxing
    {
        //class Boxing
        //{
        //    static public void Main()
        //    {
        //        int num = 2020;
        //        object obj = num;

        //        WriteLine("Valorea numarului este:{0} si tipul este:{1}", num, num.GetType());
        //        WriteLine("Valorea objectului este:{0} si tipul este:{1}", obj, obj.GetType());
        //        WriteLine("Valorea sumei este:{0}", (int)obj + num);
        //    }
        //}
    }

    #region request 1
    //namespace AsyncRequest
    //{
    //    using System;
    //    using System.Net;
    //    using System.IO;
    //    using System.Text;

    //    class Request
    //    {
    //        public static StreamReader serverResponse;

    //        static void Main()
    //        {
    //            string urlAddress = "http://google.com";
    //            SendRequest(urlAddress);
    //            PrintData(serverResponse);
    //        }

    //        public static void SendRequest(string _url)
    //        {
    //            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(_url);
    //            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

    //            Stream receiveStream = response.GetResponseStream();
    //            StreamReader readStream = null;
    //            readStream = new StreamReader(receiveStream, Encoding.GetEncoding(response.CharacterSet));
    //            serverResponse = readStream;
    //        }

    //        public static void PrintData(StreamReader _data)
    //        {
    //            string raspuns = _data.ReadToEnd();
    //            Write(raspuns);
    //        }
    //    }
    //}
    #endregion

    #region request 2
    namespace AsyncRequest
    {
        using System.Net;
        using System.IO;
        using System.Text;
        using System.Threading.Tasks;

        class Request
        {
            public static StreamReader serverResponse;
            public static string urlAddress = "http://interflix.me";

            static void Main()
            {
                MetodaGeneral();
                ReadKey();
            }

            public static async Task MetodaGeneral()
            {
                await SendRequest(urlAddress);
                await PrintData(serverResponse);
            }

            public static async Task SendRequest(string _url)
            {
                await Task.Run(() =>
                {
                    HttpWebRequest request = (HttpWebRequest)WebRequest.Create(_url);
                    HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                    Stream receiveStream = response.GetResponseStream();
                    StreamReader readStream = null;
                    readStream = new StreamReader(receiveStream, Encoding.GetEncoding(response.CharacterSet));
                    serverResponse = readStream;
                });
            }

            public static async Task PrintData(StreamReader _data)
            {
                await Task.Run(() =>
                {
                    string raspuns = _data.ReadToEnd();
                    Write(raspuns);
                });
            }
        }
    }
    #endregion

}

