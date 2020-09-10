using Players;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AfisareN
{
    class Afisare
    {


        public static void ShowScreen(string _HeroName, float _HeroHP, float _EnHP, int _Level, int _Exp, int _EnemiesLeft)
        {
            if(_EnHP < 0) { _EnHP = 0; }
            if(_HeroHP < 0) { _HeroHP = 0; }
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Game Level: " + Hero.Instance.GameLevel);
            Console.ResetColor();
            Console.WriteLine("\n+--------------------------------------------------------------------------------------------------------------+");
            //Console.WriteLine("|   " + _HeroName + "            HP : " + _HeroHP + "             Level : " + _Level + "    Experience : " + _Exp + "            Enemy Hp : " + _EnHP + "  Enemies Left" + _EnemiesLeft + "  |");
            Console.Write(("|   " + _HeroName + "   ").PadRight(25));
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write(("HP : " + _HeroHP).PadRight(10));
            Console.ResetColor();
            Console.Write(("  Level : " + _Level + "    Experience : " + _Exp + "      ").PadRight(40));
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Write(("Enemy Hp : " + _EnHP).PadRight(17));
            Console.ResetColor();
            Console.WriteLine(("  Enemies Left : " + _EnemiesLeft + " |").PadRight(21));
            Console.WriteLine("|                                                                                                              |");
            Console.WriteLine("|                                                                                                              |");
            Console.WriteLine("|                                                                                                              |");
            Console.WriteLine("|                                                                                                              |");
            Console.WriteLine("|   (\")                                                                                     (\")                |");
            Console.WriteLine("|   \\|/                                                                                     \\|/                |");
            Console.WriteLine("|    |                                                                                       |                 |");
            Console.WriteLine("|   / \\                                                                                     / \\                |");
            Console.WriteLine("|--------------------------------------------------------------------------------------------------------------|");
            Console.WriteLine("||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||");
            Console.WriteLine("||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||");
            Console.WriteLine("||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||");
            Console.WriteLine("||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||");
            Console.WriteLine("+--------------------------------------------------------------------------------------------------------------+");

        }

        public static void EnemyDestroyed()
        {
            Console.WriteLine("EEEEEEEEEE   NNN         NNN   EEEEEEEEEE   MMM            MMM   YYY       YYY");
            Console.WriteLine("EEEEEEEEEE   NNNNNN      NNN   EEEEEEEEEE   MMMMM        MMMMM   YYY       YYY");
            Console.WriteLine("EEE          NNN NNN     NNN   EEE          MMMMMM      MMMMMM   YYY       YYY");
            Console.WriteLine("EEE          NNN  NNN    NNN   EEE          MMM MMM    MMM MMM    YYY     YYY ");
            Console.WriteLine("EEEEEEEEEE   NNN   NNN   NNN   EEEEEEEEEE   MMM  MMM  MMM  MMM     YYY   YYY  ");
            Console.WriteLine("EEEEEEEEEE   NNN   NNN   NNN   EEEEEEEEEE   MMM   MMMMMM   MMM      YYYYYYY   ");
            Console.WriteLine("EEE          NNN    NNN  NNN   EEE          MMM    MMMM    MMM        YYY     ");
            Console.WriteLine("EEE          NNN     NNN NNN   EEE          MMM            MMM        YYY     ");
            Console.WriteLine("EEEEEEEEEE   NNN      NNNNNN   EEEEEEEEEE   MMM            MMM        YYY     ");
            Console.WriteLine("EEEEEEEEEE   NNN       NNNNN   EEEEEEEEEE   MMM            MMM        YYY     ");

            Console.WriteLine("\n\n");

            Console.WriteLine("                    DDDDDD       III   EEEEEEEEEE   DDDDD");
            Console.WriteLine("                    DDD DDD      III   EEEEEEEEEE   DDD DDD");
            Console.WriteLine("                    DDD  DDD     III   EEE          DDD  DDD");
            Console.WriteLine("                    DDD   DDD    III   EEE          DDD   DDD");
            Console.WriteLine("                    DDD    DDD   III   EEEEEEEEEE   DDD    DDD");
            Console.WriteLine("                    DDD    DDD   III   EEEEEEEEEE   DDD    DDD");
            Console.WriteLine("                    DDD   DDD    III   EEE          DDD   DDD");
            Console.WriteLine("                    DDD  DDD     III   EEE          DDD  DDD");
            Console.WriteLine("                    DDD DDD      III   EEEEEEEEEE   DDD DDD");
            Console.WriteLine("                    DDDDDD       III   EEEEEEEEEE   DDDDDD");

            // you won
            // you lost
        }

        public static void WinMessage()
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" YYY       YYY       OOOOOOOO       UUU         UUU                             ");
            Console.WriteLine(" YYY       YYY     OOOOOOOOOOOO     UUU         UUU                             ");
            Console.WriteLine(" YYY       YYY    OOO        OOO    UUU         UUU                             ");
            Console.WriteLine("  YYY     YYY    OOO          OOO   UUU         UUU                             ");
            Console.WriteLine("   YYY   YYY     OOO          OOO   UUU         UUU                             ");
            Console.WriteLine("    YYYYYYY      OOO          OOO   UUU         UUU                             ");
            Console.WriteLine("      YYY        OOO          OOO   UUU         UUU                             ");
            Console.WriteLine("      YYY         OOO        OOO     UUUU     UUUU                              ");
            Console.WriteLine("      YYY          OOOOOOOOOOOO       UUUUUUUUUU                                ");
            Console.WriteLine("      YYY            OOOOOOOO          UUUUUUUU                               !!!!!");
            Console.WriteLine("                                                                              !!!!!");
            Console.WriteLine("           WWW         WWW         WWW      OOOOOOOO       NNN         NNN    !!!!!");
            Console.WriteLine("           WWW        WWWWW        WWW    OOOOOOOOOOOO     NNNNNN      NNN    !!!!!");
            Console.WriteLine("           WWW       WWW WWW       WWW   OOO        OOO    NNN NNN     NNN    !!!!!");
            Console.WriteLine("            WWW      WWW WWW      WWW   OOO          OOO   NNN  NNN    NNN    !!!!!");
            Console.WriteLine("            WWW     WWW   WWW     WWW   OOO          OOO   NNN   NNN   NNN    !!!!!");
            Console.WriteLine("            WWW     WWW   WWW     WWW   OOO          OOO   NNN   NNN   NNN    !!!!!");
            Console.WriteLine("             WWW   WWW     WWW   WWW    OOO          OOO   NNN    NNN  NNN    !!!!!");
            Console.WriteLine("             WWW  WWW       WWW  WWW     OOO        OOO    NNN     NNN NNN         ");
            Console.WriteLine("              WWWWWW         WWWWWW       OOOOOOOOOOOO     NNN      NNNNNN         ");
            Console.WriteLine("                WWW           WWW           OOOOOOOO       NNN       NNNNN    !!!!!");
            Console.WriteLine("                                                                              !!!!!");
            Console.ResetColor();
        }

        public static void LostMessage()
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" YYY       YYY       OOOOOOOO       UUU         UUU                                ");
            Console.WriteLine(" YYY       YYY     OOOOOOOOOOOO     UUU         UUU                                ");
            Console.WriteLine(" YYY       YYY    OOO        OOO    UUU         UUU                                ");
            Console.WriteLine("  YYY     YYY    OOO          OOO   UUU         UUU                                ");
            Console.WriteLine("   YYY   YYY     OOO          OOO   UUU         UUU                                ");
            Console.WriteLine("    YYYYYYY      OOO          OOO   UUU         UUU                                ");
            Console.WriteLine("      YYY        OOO          OOO   UUU         UUU                                ");
            Console.WriteLine("      YYY         OOO        OOO     UUUU     UUUU                                 ");
            Console.WriteLine("      YYY          OOOOOOOOOOOO       UUUUUUUUUU                                   ");
            Console.WriteLine("      YYY            OOOOOOOO          UUUUUUUU                              !!!!!");
            Console.WriteLine("                                                                             !!!!!");
            Console.WriteLine("          LLL                 OOOOOOOO         SSSSSSSSS     TTTTTTTTTTTTT   !!!!!");
            Console.WriteLine("          LLL               OOOOOOOOOOOO     SSSSSSSSSSSSS   TTTTTTTTTTTTT   !!!!!");
            Console.WriteLine("          LLL              OOO        OOO    SSS       SSS        TTT        !!!!!");
            Console.WriteLine("          LLL             OOO          OOO   SSS                  TTT        !!!!!");
            Console.WriteLine("          LLL             OOO          OOO   SSSSSSSSSSS          TTT        !!!!!");
            Console.WriteLine("          LLL             OOO          OOO     SSSSSSSSSSS        TTT        !!!!!");
            Console.WriteLine("          LLL             OOO          OOO             SSS        TTT             ");
            Console.WriteLine("          LLL              OOO        OOO    SSS       SSS        TTT             ");
            Console.WriteLine("          LLLLLLLLLLLLL     OOOOOOOOOOOO     SSSSSSSSSSSSS        TTT        !!!!!");
            Console.WriteLine("          LLLLLLLLLLLLL       OOOOOOOO         SSSSSSSSS          TTT        !!!!!");
            Console.ResetColor();
        }

        public static void ShowStatsHero()
        {
            Console.Clear();
            string path = Hero.Instance.Name + ".xml";
            if (File.Exists(path)) // verificam daca fileul e creat
            {
                Hero.LoadHero(ref Hero.Instance);

                Console.WriteLine("Name: " + Hero.Instance.Name);
                Console.WriteLine("HP: " + Hero.Instance.HP);
                Console.WriteLine("Damage: " + Hero.Instance.Damage);
                //Console.WriteLine("Dodge: " + Hero.Instance.Dodge);
                Console.WriteLine("Exp: " + Hero.Instance.Exp);
                Console.WriteLine("Hero Level: " + Hero.Instance.Level);
                Console.WriteLine("Game Level: " + Hero.Instance.GameLevel);
            }
            else 
            {
                Console.WriteLine("No stats (launch game one time)");
            }

            Console.WriteLine("\nPress any key to go back...");
            Console.ReadKey();
        }
    }
}
