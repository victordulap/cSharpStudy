using MeniuN;
using Players;
using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Xml.Serialization;

namespace LoginN
{
    class Login
    {
        public static void LogIn()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("LOGIN: \n");

                Console.Write("Enter nickname: ");
                string nickName = Console.ReadLine();

                Console.Write("Enter password: ");
                string passWord = Console.ReadLine();

                string path = nickName + ".xml";
                if (File.Exists(path))
                {
                    //Hero hero = new Hero();
                    Hero.Instance.Name = nickName;

                    Hero.LoadHero(ref Hero.Instance);

                    if (Hero.Instance.Password == passWord)
                    {
                        Console.Clear();
                        Console.WriteLine("Login successful!");
                        Console.WriteLine("\nPress any key to continue...");
                        Console.ReadKey();

                        Meniu.MeniuPrincipal();
                        break;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Login or password incorrect... Try again!");
                        Console.WriteLine("\nPress any key to continue...");
                        Console.ReadKey();
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Account inexistent");
                    Console.WriteLine("\nPress any key to continue...");
                    Console.ReadKey();

                    Meniu.MeniuLogin();
                }
            }
        }

        public static void SignIn()
        {
            while (true) 
            {
                Console.Clear();
                Console.WriteLine("REGISTER: \n");

                Console.Write("Enter nickname: ");
                string nickName = Console.ReadLine();

                Console.Write("Enter password: ");
                string passWord = Console.ReadLine();

                string path = nickName + ".xml";
                if (File.Exists(path))
                {
                    Console.Clear();
                    Console.WriteLine("Account exists, try other nickname...");
                    Console.WriteLine("\nPress any key to continue...");
                    Console.ReadKey();
                }
                else
                {
                    Hero.Instance.ResetHero();
                    Hero.Instance.Name = nickName;
                    Hero.Instance.Password = passWord;

                    Hero.Instance.SaveHero();

                    Console.Clear();
                    Console.WriteLine("Account created succesifully!");
                    Console.WriteLine("\nPress any key to continue...");
                    Console.ReadKey();

                    Meniu.MeniuLogin();
                    break;
                }
            }
        }
    }
}
