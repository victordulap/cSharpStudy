using System;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

class Program
{
    #region ex1
    public class Employee
    {
        private int salariu;
        public int Salariu => salariu;

        private static int salMin = 100;
        public int SalMin => salMin;

        public Employee(int _salariu)
        {
            salariu = _salariu;
        }

        public void MiscorareSalariu(int minus)
        {
            int rez = Salariu;
            try
            {
                rez -= minus;
                if(rez < SalMin)
                {
                    throw new Exception("Salariu prea mic!");
                }
                else
                {
                    Console.WriteLine("Salariul modificat cu succes din {0} in {1}", Salariu, (Salariu - minus));
                    salariu -= minus;
                }
            }
            catch
            {
                Console.WriteLine("Salariul nu poate fi mai mic decat salariul minim!");
            }
        }

        public void MarireSalariu(int plus)
        {
            salariu += plus;
            Console.WriteLine("Salariul va fi marit! Salariul final: {0}", Salariu);
        }
    }
    #endregion

    #region ex2
    public static void ProcesareString(string[] str)
    {
        
        try
        {
            string temp = str.First();
            
            for (int i = 0; i < str.Length; i++)
            {
                try
                {
                    Console.WriteLine(str[i][4]);
                }
                catch(NullReferenceException)
                {
                    Console.WriteLine("ERROR:: Cuvantul este null (0xff0f)");
                }
                catch(IndexOutOfRangeException)
                {
                    //b. În caz că un cuvânt are mai puțin de 5 litere substituiți-l cu unul de lungime potrivită și continuați.
                    str[i] = "WORD_WITH_5_LETTERS";
                    Console.WriteLine("ERROR:: Cuvantul este prea scurt (0x5f1a)");
                    ProcesareString(str);
                }
                catch
                {
                    Console.WriteLine("ERROR:: Windows Blue Screen (0x0000)");
                }
            }
        }
        catch(NullReferenceException)
        {
            //⦁	În caz că tabloul este null - înlocuiți-l cu unul corespunzător.
            str = new string[] { "The__", "String", "Has_Been", "Auto_", "Replaced :)" };
            Console.WriteLine("ERROR:: String-ul este null (0x1132)");
            ProcesareString(str);
        }
        catch (InvalidOperationException)
        {
            str = new string[] { "The String Has Been Auto Replaced :)" };
            Console.WriteLine("ERROR:: Nu exitsta nici un element (0xabcd)");
            ProcesareString(str);
        }

    }
    #endregion

    #region ex3
    public static void ChinueInt(int _)
    {
        if (_ == 0) { throw new DivideByZeroException("Nu spoate sa ai variabila egala cu 0"); }
        else if (_ % 2 == 0) { throw new DivideByZeroException("Nu spoate sa ai variabila para"); }
    }
    #endregion

    #region ex4
    //ex. 4 mi sa parut fix ca si ex. 3, de asta nu lam facut 
    #endregion

    #region ex5
    public static string TestException(Exception e)
    {
        Exception exception = new Exception(e.Message);

        return exception.Message;
    }
    #endregion

    static void Main(string[] args)
    {
        ////ex 1
        //Employee angajat = new Employee(9999);
        //angajat.MiscorareSalariu(9999);

        //Console.WriteLine("Salariu: " + angajat.Salariu);

        //ex 2
        //string[] str = { "cuvant1", "word2", "cuv3", null }; //{ };//null;//new string[] ;
        ////Console.WriteLine(str.Length);
        //ProcesareString(str);

        //ex 3
        //int x = 0;
        //try
        //{
        //    ChinueInt(x);
        //}
        //catch(Exception e)
        //{
        //    Console.WriteLine(e.Message);
        //}

        //ex 4
        //ex. 4 mi sa parut fix ca si ex. 3, de asta nu lam facut 

        //ex 5
        //Exception e = new Exception();
        //e = new NullReferenceException();
        //Console.WriteLine(e.Message);
        Console.WriteLine(TestException(new NullReferenceException()) + " / " + nameof(NullReferenceException));
        Console.WriteLine(TestException(new InvalidOperationException()) + " / " + nameof(InvalidOperationException));
        Console.WriteLine(TestException(new ArgumentException()) + " / " + nameof(ArgumentException));
        Console.WriteLine(TestException(new ArgumentNullException()) + " / " + nameof(ArgumentNullException));
        Console.WriteLine(TestException(new ArgumentOutOfRangeException()) + " / " + nameof(ArgumentOutOfRangeException));
        Console.WriteLine(TestException(new AccessViolationException()) + " / " + nameof(AccessViolationException));
        Console.WriteLine(TestException(new ExternalException()) + " / " + nameof(ExternalException));
    }
}

