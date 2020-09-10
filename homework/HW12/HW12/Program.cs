using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using static System.Console;

namespace HW12
{
    #region ex1
    //class Program
    //{
    //    static void Main()
    //    {
    //        string path = "D:\\testtextfile\\test1.txt";

    //        using (StreamReader sr = File.OpenText(path))
    //        {
    //            string s = "";

    //            //while ((s = sr.ReadLine()) != null)
    //            //WriteLine(s);

    //            s = sr.ReadLine();//.ToString();
    //            WriteLine(s);
    //        }

    //    }
    //}
    #endregion

    #region ex2
    //class Program
    //{
    //    static void Main()
    //    {
    //        string path = "D:\\testtextfile\\test1.txt";

    //        using (StreamReader sr = File.OpenText(path))
    //        {
    //            string s = "";

    //            while ((s = sr.ReadLine()) != null)
    //            {
    //                for (int i = 0; i < s.Length; i++)
    //                {
    //                    if (s[i] == 'a' || s[i] == 'e' ||
    //                       s[i] == 'i' || s[i] == 'o' || s[i] == 'u')
    //                    {
    //                        Console.Write(s[i]);
    //                    }
    //                }
    //                Console.WriteLine();
    //            }
    //        }
    //    }
    //}
    #endregion

    #region ex3
    //struct InformatiiUtilizator
    //{
    //    public int ID { get; set; }
    //    public string Login { get; set; }
    //    public string Password { get; set; }
    //    public int NrComentarii { get; set; }

    //    public InformatiiUtilizator(int _ID, string _Login, string _Password, int _NrComentarii)
    //    {
    //        ID = _ID;
    //        Login = _Login;
    //        Password = _Password;
    //        NrComentarii = _NrComentarii;
    //    }
    //}

    //class Program
    //{
    //    static void Main()
    //    {
    //        string path = "D:\\testtextfile\\InformatiiUtilizator.txt";


    //        InformatiiUtilizator[] user = new InformatiiUtilizator[10];

    //        Console.WriteLine("Generating...");

    //        for (int i = 0; i < user.Length; i++)
    //        {
    //            user[i] = new InformatiiUtilizator(i, "admin" + i.ToString(), "admin" + i.ToString(), (i + i) * i);
    //            Console.WriteLine("id: {0} / login: {1} password: {2} / nr comments: {3}", user[i].ID, user[i].Login, user[i].Password, user[i].NrComentarii);
    //        }

    //        Console.WriteLine("Saving in file...");

    //        using (StreamWriter sr = File.CreateText(path))
    //        {
    //            for (int i = 0; i < user.Length; i++)
    //            {
    //                sr.WriteLine(user[i].ID);
    //                sr.WriteLine(user[i].Login);
    //                sr.WriteLine(user[i].Password);
    //                sr.WriteLine(user[i].NrComentarii);
    //            }
    //        }

    //        Console.WriteLine("Loading from file...");

    //        InformatiiUtilizator[] userFromFile = new InformatiiUtilizator[10];

    //        using (StreamReader sr = File.OpenText(path))
    //        {
    //            string s = "";

    //            for (int i = 0; i < user.Length; i++)
    //            {
    //                s = sr.ReadLine();
    //                userFromFile[i].ID = Convert.ToInt32(s);
    //                s = sr.ReadLine();
    //                userFromFile[i].Login = s;
    //                s = sr.ReadLine();
    //                userFromFile[i].Password = s;
    //                s = sr.ReadLine();
    //                userFromFile[i].NrComentarii = Convert.ToInt32(s);
    //            }
    //        }

    //        Console.WriteLine("Showing from file...");

    //        for (int i = 0; i < user.Length; i++)
    //        {
    //            user[i] = new InformatiiUtilizator(i, "admin" + i.ToString(), "admin" + i.ToString(), (i + i) * i);
    //            Console.WriteLine("id: {0} / login: {1} password: {2} / nr comments: {3}", user[i].ID, user[i].Login, user[i].Password, user[i].NrComentarii);
    //        }

    //    }
    //}
    #endregion

    #region ex4
    //class EnumerateFolders
    //{
    //    static void Main()
    //    {
    //        string docpath = "D:\\";
    //        List<string> dirs = new List<string>(Directory.EnumerateDirectories(docpath));

    //        foreach (var dir in dirs)
    //            WriteLine($"{dir.Substring(dir.LastIndexOf(Path.DirectorySeparatorChar) + 1)}");

    //        string smax = "";
    //        int max = -1;

    //        foreach (var dir in dirs)
    //        {
    //            try
    //            {
    //                List<string> d = new List<string>(Directory.EnumerateDirectories(dir + "\\"));
    //                if (max < d.Count) { max = d.Count; smax = dir; }
    //                WriteLine($"{d.Count} fisiere gasite in fisierul" + dir);
    //            }
    //            catch (Exception) { };
    //        }

    //        //WriteLine("\ncele mai multe fisiere sunt in fisierul: {0}, contine {1}", smax, max);
    //        WriteLine($"\ncele mai multe fisiere sunt in fisierul: {smax}, contine {max}");
    //    }
    //}

    #endregion

    #region ex5
    //class Program
    //{
    //    public static void Main()
    //    {

    //        string docPath = "D:\\";
    //        List<string> dirs = new List<string>();// (Directory.EnumerateDirectories(docPath));

    //        dirs = Directory.EnumerateDirectories(docPath).ToList();

    //        foreach (var dir in dirs)
    //        {
    //            DirectoryInfo fi = new DirectoryInfo(dir);
    //            if (fi.LastAccessTime.Year == 2019) //(fi.LastAccessTime.Year == 2020)
    //            {
    //                WriteLine(dir);
    //            }
    //        }
    //    }
    //}
    #endregion

    #region ex6
    //class Program
    //{
    //    public static void Main()
    //    {

    //        string docPath = "D:\\";
    //        List<string> dirs = new List<string>(Directory.EnumerateDirectories(docPath));

    //        foreach (var dir in dirs)
    //        {
    //            DirectoryInfo fi = new DirectoryInfo(dir);
    //            if (fi.LastAccessTime.Year == 2019)
    //            {
    //                WriteLine(dir);
    //            }
    //        }
    //    }
    //}
    #endregion
}
