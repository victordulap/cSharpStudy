using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Lectia14
{
    namespace LINQ
    {
        //    class Program
        //    {
        //        static void Main()
        //        {
        //            string[] cuvinte = { "salut", "Ion", "Mississippi", "oxigen", "cuvinte" };
        //            var cuvinteLungi = from cuvint in cuvinte where cuvint.Length >= 6 select cuvint;

        //            foreach (var cuvint in cuvinteLungi)
        //                Console.WriteLine(cuvint);

        //            Console.WriteLine(cuvinteLungi.GetType());
        //        }
        //    }
    }

    namespace LINQ_ex1
    {
        //    class Program
        //    {
        //        static void Main()
        //        {
        //            Random rand = new Random();

        //            int[] Masiv = new int[10];
        //            //foreach (int i in Masiv)
        //            //{
        //            //    Masiv[i] = rand.Next(10);
        //            //}
        //            for(int i = 0; i < Masiv.Length; i++)
        //            {
        //                Masiv[i] = rand.Next(10);
        //            }

        //            var MasivDiv3 = from div3 in Masiv where (div3 % 3) == 0 select div3;

        //            foreach (var item in MasivDiv3)
        //                Console.WriteLine(item);
        //        }
        //    }
    }

    namespace LINQ_ex1CuLambda // mai usor si mai bine
    {
        //class Program
        //{
        //    static void Main()
        //    {
        //        Random rand = new Random();

        //        int[] Masiv = new int[10];

        //        for (int i = 0; i < Masiv.Length; i++)
        //        {
        //            Masiv[i] = rand.Next(10);
        //        }

        //        //var MasivDiv3 = from div3 in Masiv where (div3 % 3) == 0 select div3;
        //        var MasivDiv3 = Masiv.Where(x => x % 3 == 0);

        //        foreach (var item in MasivDiv3)
        //            Console.WriteLine(item);
        //    }
        //}
    }

    namespace LINQSelect
    {
        //public class Employee
        //{
        //    public int ID { get; set; }
        //    public string Prenume { get; set; }
        //    public string Nume { get; set; }
        //    public int Salariu { get; set; }
        //    public static List<Employee> GetEmployees()
        //    {
        //        List<Employee> employees = new List<Employee>
        //        {
        //            new Employee {ID = 101, Prenume = "Ion",   Nume = "Nicolaescu", Salariu = 5000 },
        //            new Employee {ID = 102, Prenume = "Maria", Nume = "Croitor", Salariu = 6000 },
        //            new Employee {ID = 103, Prenume = "Radu",  Nume = "Moraru", Salariu = 10000 },
        //            new Employee {ID = 104, Prenume = "Daniel",Nume = "Urechean", Salariu = 25000 },
        //            new Employee {ID = 105, Prenume = "Vasile",Nume = "Varzar", Salariu = 7000 },
        //            new Employee {ID = 106, Prenume = "Petru", Nume = "Soimar", Salariu = 8000 }
        //        };
        //        return employees;
        //    }
        //}

        //class Program
        //{
        //    static void Main()
        //    {
        //        // Cu lista

        //        //List<Employee> basicQuery =
        //        //(from emp in Employee.GetEmployees() where emp.Salariu >= 7000 && emp.Salariu <= 12000 && emp.Nume[0] == 'V' select emp).ToList();

        //        //List<Employee> basicQuery = Employee.GetEmployees().Where(x => x.Salariu >= 7000 && x.Salariu <= 12000 && x.Nume[0] == 'V').ToList();

        //        //foreach (Employee emp in basicQuery)
        //        //    Console.WriteLine($"ID: {emp.ID} Nume: {emp.Prenume} {emp.Nume}  Salariu: {emp.Salariu} lei.");

        //        // Cu Masiv in loc de List-e :

        //        Employee[] obj = Employee.GetEmployees().ToArray();
        //        obj = obj.Where(x => x.Salariu >= 7000 && x.Salariu <= 12000 && x.Nume[0] == 'V').ToArray();

        //        foreach (Employee emp in obj)
        //            Console.WriteLine($"ID: {emp.ID} Nume: {emp.Prenume} {emp.Nume}  Salariu: {emp.Salariu} lei.");
        //    }
        //}
    }

    namespace LINQOfType
    {
        class Program
        {
            static void Main()
            {
                List<object> variabile = new List<object>() { "cuvint", "string", 50075, "masina", 'a', 63, "James", true };
                //List<int> numere = variabile.OfType<int>().ToList();
                //foreach (int numar in numere)
                //  Console.WriteLine(numar);

                List<string> strings = variabile.OfType<string>().ToList();
                strings = strings.Where(x => x.Length >= 5).ToList();

                foreach (var item in strings)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }


}
