using AfisareN;
using MeniuN;
using Players;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;

namespace BattleN
{
    class Battle
    {

        public static void StartBattle()
        {
            if(Hero.Instance.Level == 1)
            {
                Hero.Instance.HP = 500;
                Hero.Instance.Damage = 50;
            }

            List<Enemy> en = new List<Enemy>();

            int EnemiesNr = Hero.Instance.GameLevel + 2;
            for (int i = 0; i < EnemiesNr; i++)
            {
                en.Add(new Enemy());
            }

            while (true) // (hero.HP > 0) // am facut asa pt ca la noi totul este verificat si el stie cand trebuie sa intrerupa loop-ul prin break
            {
                if (en[0].HP <= 0)//cand il maceste pe un enemy
                {
                    en.RemoveAt(0);
                    Console.Clear();
                    Afisare.EnemyDestroyed();
                    Thread.Sleep(1000); //1000

                    Console.Clear();



                    Hero.Instance.Exp += 10;
                    if (Hero.Instance.Exp >= Hero.Instance.Exp_Per_Level)
                    {
                        Hero.Instance.Level++;
                        Hero.Instance.Exp_Per_Level = Hero.Instance.Exp_Per_Level * 2 + (Hero.Instance.Exp_Per_Level / 4);
                    }

                    if (en.Count == 0)
                    {
                        Hero.Instance.HP = 500 + (200 * (Hero.Instance.Level / 10));
                        Hero.Instance.GameLevel++;
                        Hero.Instance.SaveHero();

                        Afisare.WinMessage();
                        Thread.Sleep(1500);
                        //hero.Level++;
                        NextLevel.LevelNext();
                        break;
                    }

                }
                else
                {
                    Console.Clear();
                    Afisare.ShowScreen(Hero.Instance.Name, Hero.Instance.HP, en[0].HP, Hero.Instance.Level, Hero.Instance.Exp, en.Count);
                    Hero.Instance.HP -= en[0].Damage;
                    Thread.Sleep(1000); //1000

                    en[0].HP -= Hero.Instance.Damage;
                    Console.Clear();
                    Afisare.ShowScreen(Hero.Instance.Name, Hero.Instance.HP, en[0].HP, Hero.Instance.Level, Hero.Instance.Exp, en.Count);
                    Thread.Sleep(1000); //1000
                }

                if (Hero.Instance.HP < 0)
                {
                    Hero.Instance.HP = 500 + (200 * (Hero.Instance.Level / 10));
                    Hero.Instance.SaveHero();

                    Afisare.LostMessage();
                    Thread.Sleep(1500);

                    Meniu.MeniuPrincipal();
                    break;
                }
            } //while
        }
    }
}
