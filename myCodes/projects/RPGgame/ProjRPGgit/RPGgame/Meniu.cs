using System;
using System.Collections.Generic;
using System.Text;

namespace MeniuN
{
    using AfisareN;
    using BattleN;
    using LoginN;
    using Players;
    using RPGgame;
    using System.IO;

    class Meniu
    {
        public static void MeniuLogin()
        {
            Console.Clear();
            Console.WriteLine("Choose option\n");
            Console.WriteLine("1. Login");
            Console.WriteLine("2. Sign In");
            Console.WriteLine("\n0. EXIT");

            switch (Console.ReadKey(true).KeyChar)
            {
                case '1':
                    {
                        Login.LogIn();

                        break;
                    }
                case '2':
                    {
                        Login.SignIn();

                        break;
                    }
                case '0':
                    {
                        Environment.Exit(0);
                        break;
                    }
                default:
                    {
                        MeniuLogin();
                        break;
                    }
            }
        }

        public static void MeniuPrincipal() //afisarea meniului principal
        {
            Console.Clear();
            //1
            Console.ForegroundColor = ConsoleColor.White;

            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("RRR   PPP   GGGG");
            //2
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("R  R  P  P  G   ");
            //3
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("RRR   PPP   G GG");
            //4
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("RRR   P     G  G");
            //5
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("R  R  P     GGGG");

            Console.ResetColor();

            //Console.WriteLine("GAME\n");
            Console.WriteLine("\n1. Start game");
            Console.WriteLine("2. Profile info");
            Console.WriteLine("\n0. EXIT");

            switch (Console.ReadKey(true).KeyChar)
            {
                case '1':
                    {
                        Console.Clear();
                        Battle.StartBattle();
                        break;
                    }
                case '2':
                    {
                        MeniuProfile();
                        break;
                    }
                case '0':
                    {
                        Environment.Exit(0);
                        break;
                    }
                default:
                    {
                        MeniuPrincipal();
                        break;
                    }
            }
        }

        private static void MeniuProfile() //afisarea meniului Profile Info
        {
            Console.Clear();
            Console.WriteLine("PROFILE INFO\n");
            Console.WriteLine("1. Info");
            Console.WriteLine("2. Delete account");
            Console.WriteLine("3. Logout");
            Console.WriteLine("4. Back");

            switch (Console.ReadKey(true).KeyChar)
            {
                case '1':
                    {
                        Afisare.ShowStatsHero();

                        MeniuPrincipal();

                        break;
                    }
                case '2':
                    {
                        string path = Hero.Instance.Name + ".xml";
                        if (File.Exists(path))
                        {
                            File.Delete(path);
                        }

                        Console.Clear();

                        Console.WriteLine("Account deleted...");
                        Console.WriteLine("\nPress any key to go back...");
                        Console.ReadKey();

                        Meniu.MeniuLogin();

                        break;
                    }
                case '3':
                    {
                        Meniu.MeniuLogin();
                        break;
                    }
                case '4':
                    {
                        MeniuPrincipal();
                        break;
                    }
                default:
                    {
                        MeniuProfile();
                        break;
                    }
            }
        }
    }

    class NextLevel
    {
        public static void LevelNext()
        {
            Console.Clear();
            Console.WriteLine("Level finished!\n");
            Console.WriteLine("1. Next Level");
            Console.WriteLine("2. Menu");

            switch (Console.ReadKey(true).KeyChar)
            {
                case '1':
                    {
                        Console.Clear();
                        Battle.StartBattle();
                        break;
                    }
                case '2':
                    {
                        Console.Clear();
                        Meniu.MeniuPrincipal();

                        break;
                    }
                default:
                    {
                        LevelNext();
                        break;
                    }
            }
            
        }
    }
}
