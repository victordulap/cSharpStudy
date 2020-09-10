using System;
using System.Diagnostics;
using System.IO;
using static System.Console;

namespace Lectia12
{
    #region ex1
    //class Class1
    //{
    //    int[] x;
    //    Stopwatch timeSpan;

    //    public Class1()
    //    {
    //        timeSpan = Stopwatch.StartNew();
    //        x = new int[1000];
    //        Console.WriteLine("Constructor Class1");
    //    }

    //    ~Class1()
    //    {
    //        Console.WriteLine("Destructor Class1 object lasted: " + timeSpan.Elapsed);
    //    }
    //}

    //class Class2
    //{
    //    Stopwatch timeSpan;

    //    public Class2()
    //    {
    //        timeSpan = Stopwatch.StartNew();
    //        Console.WriteLine("Constructor Class2");
    //    }

    //    ~Class2()
    //    {
    //        Console.WriteLine("Destructor Class2 object lasted: " + timeSpan.Elapsed);
    //    }
    //}

    //class Class3
    //{
    //    Stopwatch timeSpan;

    //    public Class3()
    //    {
    //        timeSpan = Stopwatch.StartNew();
    //        Console.WriteLine("Constructor Class3");
    //    }

    //    ~Class3()
    //    {
    //        Console.WriteLine("Destructor Class3 object lasted: " + timeSpan.Elapsed);
    //    }
    //}

    //public class Demo
    //{
    //    public static void Main()
    //    {
    //        ReadKey();

    //        Details();
    //        Details();

    //        ReadKey();

    //        GC.Collect();

    //        ReadKey();
    //    }

    //    public static void Details()
    //    {
    //        Class1 obj1 = new Class1();
    //        Class2 obj2 = new Class2();
    //        Class3 obj3 = new Class3();
    //    }
    //}

    #endregion

    #region exemplu dispose
    //class FinalizeDemo : IDisposable
    //{
    //    private bool disposed; // by deafault ii false

    //    //Constructor si destructor
    //    public FinalizeDemo() { WriteLine("Constructor"); }
    //    ~FinalizeDemo() { WriteLine("Destructor"); }

    //    //Implementarea metodei Dispose
    //    public void Dispose()
    //    {
    //        Dispose(true);
    //        GC.SuppressFinalize(this);  //Blocam executia destructorului pentru ca am utilizat metoda Dispose
    //        disposed = true;
    //    }

    //    private void Dispose(bool disposing)
    //    {
    //        if (!disposed)
    //        {
    //            if (disposing)
    //            {
    //                //Executati eliberarea resurselor
    //                WriteLine("Eliberarea resurselor in dispose");
    //            }
    //            disposed = true;
    //        } 
    //    }

    //    //Executie 
    //    static void Main()
    //    {
    //        FinalizeDemo demo = new FinalizeDemo();
    //        IDisposable dispose;
    //        dispose = demo;             //Obtinem referinta spre interfata IDisposable a obiectului dat
    //        dispose.Dispose();          //Apelam metoda Dispose din interfata
    //    }
    //}

    #endregion

    #region ex1
    //class Class1 : IDisposable
    //{
    //    private bool disposed;
    //    //public delegate void MyDel();
    //    //public event MyDel MyEvent;

    //    public Class1() { Console.WriteLine("Constructor"); }
    //    ~Class1() { Console.WriteLine("Destructor"); Dispose(false); }

    //    public void Dispose()
    //    {
    //        Dispose(true);
    //        GC.SuppressFinalize(this);
    //        disposed = true;
    //    }

    //    private void Dispose(bool disposable)
    //    {
    //        if (!disposed)
    //        {
    //            if (disposable)
    //            {
    //                Console.WriteLine("Tipa am salvat in fisier / Dispose(true)");
    //            }
    //            disposed = true;
    //        }
    //    }
    //}

    //class Program
    //{
    //    public static void Main()
    //    {
    //        Class1 class1 = new Class1();
    //        class1.Dispose();
    //        class1.Dispose();
    //        class1.Dispose();
    //    }
    //}
    #endregion

    // files

    #region ex1
    //class StreamReaderClass
    //{
    //    static void Main(string[] args)
    //    {
    //        string path = "D:\\" + Console.ReadLine();
    //        FileStream fs = new FileStream(path, FileMode.Create);
    //        fs.Close();
    //        Write("Fisierul a fost creat si are adresa: {0}", path);
    //    }
    //}

    #endregion

    #region exemplu
    //class StreamReaderClass
    //{
    //    static void Main(string[] args)
    //    {
    //        string path = "D:\\msdia80.dll";

    //        StreamReader sr = File.OpenText(path);
    //        string s = "";

    //        while ((s = sr.ReadLine()) != null)
    //            WriteLine(s);
    //    }
    //}

    #endregion

    #region exemplu
    //class StreamWriterClass
    //{
    //    static void Main()
    //    {
    //        string path = "D:\\Example.txt";

    //        //using (StreamWriter sr = File.AppendText(path))
    //        //{
    //        //    sr.WriteLine("\nStream Writer");
    //        //    sr.Close();
    //        //}

    //        using (StreamWriter sr = File.CreateText(path))
    //        {
    //            sr.WriteLine("\nStream Writer");
    //            sr.Close();
    //        }

    //        WriteLine(File.ReadAllText(path));
    //    }
    //}


    #endregion

    // folders

    #region ex1
    class CreateFolder
    {
        static void Main()
        {
            string path = "D:\\test_newFolder";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
                WriteLine("Fisier creat cu succes");

                path += "\\folder2";
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                    WriteLine("Fisier creat cu succes");

                    path += "\\folder3";
                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                        WriteLine("Fisier creat cu succes");
                    }
                }
            }
            else
                WriteLine("Fisierul deja exista");
        }
    }

    #endregion
}
