using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Reflection.Metadata;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Lectia15
{
    namespace LINQToXML
    {
        //class Program
        //{
        //    static void Main()
        //    {
        //        XElement XMLelement = XElement.Load("D:\\XML\\exFinal.xml");
        //        List<XElement> employees = XMLelement.Elements().ToList();

        //        foreach (var employee in employees)
        //            Console.WriteLine(employee);

        //        Console.WriteLine(employees.Count());
        //    }
        //}
    }

    namespace LINQToXMLSingle
    {
        //    class Program
        //    {
        //        static void Main()
        //        {
        //            XElement xelement = XElement.Load("D:\\XML\\exFinal.xml");
        //            List<XElement> Tranzacts = xelement.Elements().ToList();

        //            Tranzacts = Tranzacts.FindAll(x => Convert.ToDecimal(x.Element("SumaTranzactiei").Value) > 2000);
        //            Tranzacts = Tranzacts.FindAll(x => Convert.ToDateTime(x.Element("DataTranzactiei").Value).Year >= 2019);

        //            Console.WriteLine("SumaTranzactiei: ");

        //            foreach (var Tranzact in Tranzacts)
        //                Console.WriteLine(Tranzact);
        //                //Console.WriteLine(Tranzact.Element("SumaTranzactiei").Value);
        //        }
        //    }   
    }

    namespace LINQToXMLAtribut
    {
        //class Program
        //{
        //    static void Main()
        //    {
        //        XElement xelement = XElement.Load("D:\\XML\\exFinal.xml");

        //        var enumerare = from element in xelement.Elements("Tranzactie")
        //                        where (string)element.Attribute("tipTranzactie") == "PersoanaFizica"
        //                        select element;

        //        Console.WriteLine("Produs cu atribut Tranzactie == PersoanaFizica:\n");
        //        foreach (XElement element in enumerare)
        //            Console.WriteLine(element);

        //         List<XElement> lista = enumerare.ToList();

        //        //lista.Sum(x => x.Elements("Tranzactie").Where(x => (string)x.Attribute("tipTranzactie") == "PersoanaFizica"));
        //    }
        //}
    }

    namespace Serializare
    {
        //[Serializable]
        //class Program1
        //{
        //    public int ID;
        //    public string Name;
        //static void Main()
        //{
        //    //Cream obiectul si ii dam valori
        //    Program1 obj = new Program1();
        //    obj.ID = 1573;
        //    obj.Name = "Serializare";

        //    IFormatter formatter = new BinaryFormatter();
        //    Stream stream = new FileStream("Exemplu.txt", FileMode.Create, FileAccess.Write);

        //    formatter.Serialize(stream, obj);
        //    stream.Close();
        //}
        //}
    }

    namespace Deserializare
    {
        //class Program
        //{
        //    static void Main()
        //    {
        //        IFormatter formatter = new BinaryFormatter();
        //        Stream stream = new FileStream("Exemplu.txt", FileMode.Open, FileAccess.Read);
        //        Serializare.Program1 objnew = (Serializare.Program1)formatter.Deserialize(stream);
        //        stream.Close();

        //        Console.WriteLine("ID:" + objnew.ID);
        //        Console.WriteLine("Name:" + objnew.Name);
        //    }
        //}
    }

    namespace SerializareEx
    {
        //[Serializable]
        //class Program1
        //{
        //    public DateTime[] date;
        //    static void Main()
        //    {
        //        //Cream obiectul si ii dam valori
        //        Program1 obj = new Program1();
        //        obj.date = new DateTime[5];
        //        obj.date[0] = new DateTime(1999, 1, 2);
        //        obj.date[1] = new DateTime(2012, 5, 12);
        //        obj.date[2] = new DateTime(1995, 2, 21);
        //        obj.date[3] = new DateTime(1979, 6, 5);
        //        obj.date[4] = new DateTime(2001, 11, 7);

        //        IFormatter formatter = new BinaryFormatter();
        //        Stream stream = new FileStream("Exemplu.txt", FileMode.Create, FileAccess.Write);

        //        formatter.Serialize(stream, obj);
        //        stream.Close();
        //    }
        //}
    }

    namespace DeserializareEx
    {
        //    class Program
        //    {
        //        static void Main()
        //        {
        //            IFormatter formatter = new BinaryFormatter();
        //            Stream stream = new FileStream("Exemplu.txt", FileMode.Open, FileAccess.Read);
        //            SerializareEx.Program1 objnew = (SerializareEx.Program1)formatter.Deserialize(stream);
        //            stream.Close();

        //            List<DateTime> Dates = objnew.date.ToList();

        //            Dates.Sort();
        //            Dates.Reverse();

        //            foreach(var data in Dates)
        //                Console.WriteLine("Date:" + data.Date);

        //            Console.WriteLine(Dates.Max());
        //        }   
        //    }
        //}
    }

    namespace Rezolvare_Problema1
    {
        //[Serializable]
        //class Eveniment
        //{
        //    public DateTime eventDate;
        //    public string eventDescription;

        //    static Random gen = new Random();
        //    public static string[] evName = { "Pastele", "Anul Nou", "Craciun", "Primul Sunet", "Ultimul Sunet" };

        //    static DateTime RandomDay()
        //    {
        //        DateTime start = new DateTime(DateTime.Today.Year, 1, 1);
        //        int range = (DateTime.Today - start).Days;
        //        return start.AddDays(gen.Next(range));
        //    }

        //    public Eveniment()
        //    {
        //        eventDate = RandomDay();
        //        eventDescription = evName[gen.Next(0, evName.Length)];
        //    }

        //    static void Main(string[] args)
        //    {
        //        Eveniment[] eventList = new Eveniment[5];



        //        for (int i = 0; i < eventList.Length; i++)
        //        {
        //            eventList[i] = new Eveniment();
        //        }

        //        List<Eveniment> newList = eventList.ToList();
        //    }
    }

    namespace Rezolvare_Problema2
    {
        //[Serializable]
        //class User
        //{
        //    public string Login { get; set; }
        //    public string Password { get; set; }
        //    public DateTime LastLogin { get; set; }
        //    /*[NonSerialized]*/ public string hostName;
        //    /*[NonSerialized]*/ public string userIP;

        //    static void Main(string[] args)
        //    {
        //        User user = new User();

        //        user.Login = "admin";
        //        user.Password = "admin";
        //        user.LastLogin = DateTime.Now;
        //        user.hostName = Dns.GetHostName();
        //        //user.userIP = Dns.GetHostByName(user.hostName).AddressList[0].ToString(); //ipv6
        //        IPAddress[] ipv4Addresses = 
        //            Array.FindAll(Dns.GetHostEntry(string.Empty).AddressList, a => a.AddressFamily == AddressFamily.InterNetwork);
        //        user.userIP = ipv4Addresses[0].ToString();

        //        IFormatter formatter = new BinaryFormatter();
        //        Stream stream = new FileStream("Exemplu.txt", FileMode.Create, FileAccess.Write);

        //        formatter.Serialize(stream, user);
        //        stream.Close();

        //        //--------------------------------------------------------------

        //        Stream streamOut = new FileStream("Exemplu.txt", FileMode.Open, FileAccess.Read);
        //        User userNew = (User)formatter.Deserialize(streamOut);
        //        streamOut.Close();

        //        Console.WriteLine("User: {0}, {1}, {2}, {3}, {4}", userNew.Login, userNew.Password, userNew.LastLogin, userNew.hostName, userNew.userIP) ;
        //    }
        //}
    }

    namespace SerializareXML
    {
        //[Serializable]
        //public class Cat
        //{
        //    public string Name { get; set; }
        //    public int Age { get; set; }

        //    public Cat() { }

        //    public Cat(string name, int age)
        //    {
        //        Name = name;
        //        Age = age;
        //    }
        //}
        //class Program
        //{
        //    static void Main(string[] args)
        //    {
        //        //Crearea obiectului
        //        Cat person = new Cat("Tom", 7);
        //        Console.WriteLine("Obiect creat");

        //        //Serializare
        //        XmlSerializer formatter = new XmlSerializer(typeof(Cat));
        //        using (FileStream fs = new FileStream("D:\\XML\\cat.xml", FileMode.OpenOrCreate))
        //            formatter.Serialize(fs, person);

        //        //Deserializare
        //        using (FileStream fs = new FileStream("D:\\XML\\cat.xml", FileMode.OpenOrCreate))
        //        {
        //            Cat newPerson = (Cat)formatter.Deserialize(fs);
        //            Console.WriteLine("Obiect deserializat");
        //            Console.WriteLine($"Name: {newPerson.Name}\nAge: {newPerson.Age}");
        //        }
        //    }
        //}
    }

    namespace SeriazareArray
    {
        [Serializable]
        public class Tara
        {
            public string Nume { get; set; }
            public string Limba { get; set; }
            public int Populatie { get; set; }

            public Tara() {}

            public Tara(string _Nume, string _Limba, int _Populatie)
            {
                Nume = _Nume;
                Limba = _Limba;
                Populatie = _Populatie;
            }
        }

        class Program
        {
            static Random random = new Random();
            public static void Main()
            {
                string[] DenumiriTari = new string[]
                {
                    "Moldova", "Romania", "Russia", "Ucraina",
                    "Anglia", "Spania", "Portugalia", "Mexica",
                    "Polonia", "Belorusia", "India", "Italia"
                };

                string[] Limbe = new string[]
                {
                    "Romana", "Rusa", "Ucraineana", "Engleza",
                    "Spaniola", "Poloneza", "Chineza", "Japoneza",
                    "Indiana", "Italiana"
                };

                Tara[] Country = new Tara[10];

                //for (int i = 0; i < Country.Length; i++)
                //{
                //    Country[i] =
                //        new Tara(DenumiriTari[random.Next(DenumiriTari.Length)], Limbe[random.Next(Limbe.Length)], random.Next(15000000));
                //}

                //foreach (var item in Country)
                //{
                //    Console.WriteLine($"Name: {item.Nume}, Limba: {item.Limba}, Populatie: {item.Populatie}");
                //}
                //Serializare
                XmlSerializer formatter = new XmlSerializer(typeof(Tara[]));

                //using (FileStream fs = new FileStream("D:\\XML\\Tari.xml", FileMode.OpenOrCreate))
                //    formatter.Serialize(fs, Country);

                //Console.ForegroundColor = ConsoleColor.Magenta;
                //Console.WriteLine("Serializing done!");
                //Console.ResetColor();
                //---------------------------------------------------------------------------------

                //Deserializare

                //using (FileStream fs = new FileStream("D:\\XML\\Tari.xml", FileMode.OpenOrCreate))
                //{
                //    Tara[] newCountry = (Tara[])formatter.Deserialize(fs);

                //    foreach (var item in newCountry)
                //    {
                //        Console.WriteLine($"Name: {item.Nume}, Limba: {item.Limba}, Populatie: {item.Populatie}");
                //    }
                //}

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Deserializing done!");
                Console.ResetColor();

                XElement XMLelement = XElement.Load("D:\\XML\\Tari.xml");
                List<XElement> Countrys = XMLelement.Elements().ToList();

                // Populatie > 5000000
                List<XElement> Countrys2 = Countrys.FindAll(x => Convert.ToInt32(x.Element("Populatie").Value) >= 5000000);

                foreach (var country in Countrys2)
                    Console.WriteLine(country);

                Console.WriteLine("\nCount: " + Countrys2.Count);

                //moldova
                Countrys = Countrys.FindAll(x => x.Element("Nume").Value == "Moldova");
                foreach (var country in Countrys)
                    Console.WriteLine(country);

                Console.WriteLine("\nCount: " + Countrys.Count);
            }
        }
    }

}
