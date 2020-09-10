using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Xml.Serialization;

namespace Players
{
    [Serializable]
    abstract public class Abilitati
    {
        abstract public int HP { get; set; }
        abstract public int Damage { get; set; }
        //abstract public int Dodge { get; set; }
        abstract public int Level { get; set; }
    }

    [Serializable]
    public class Hero : Abilitati
    {
        public static Hero Instance = new Hero();

        public string Name { get; set; }
        public string Password { get; set; }
        public override int HP { get; set; }
        public override int Damage { get; set; }
        //public override int Dodge { get; set; }
        public int Exp { get; set; }
        public override int Level { get; set; }
        // ultimul nivel
        public int GameLevel { get; set; }

        public int Exp_Per_Level { get; set; }//numarul de exp pentru a ajunge la levelul urmator

        public Hero()
        {
            Level = 1;
            HP = 500 + Convert.ToInt32(200 * ((double)Level / 10)) + Level * 3;
            Damage = 50 + Convert.ToInt32(30 * ((double)this.Level / 10)) + Level * 2;
            Exp_Per_Level = 50;
            Exp = 0;
            GameLevel = 1;
            //CreatedHero = false;
        }

        public void SaveHero()
        {
            if (this.Level == 1)
            {
                this.HP = 500;
                this.Damage = 50;
            }
            else
            {
                this.HP = 500 + Convert.ToInt32(200 * ((double)this.Level / 10)) + Level * 3;
                this.Damage = 50 + Convert.ToInt32(30 * ((double)this.Level / 10)) + Level * 2;
            }

            string path = this.Name + ".xml";

            XmlSerializer formatter = new XmlSerializer(typeof(Hero));
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
                formatter.Serialize(fs, this);
        }

        public static void LoadHero(ref Hero hero)
        {
            string path = hero.Name + ".xml";

            XmlSerializer formatter = new XmlSerializer(typeof(Hero));
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                hero = (Hero)formatter.Deserialize(fs);
            };
        }

        public void ResetHero()
        {
            Level = 1;
            HP = 500;
            Damage = 50;
            Exp_Per_Level = 50;
            Exp = 0;
            GameLevel = 1;
        }
    }

    class Enemy : Abilitati
    {
        public override int HP { get; set; }
        public override int Damage { get; set; }
        //public override int Dodge { get; set; }
        private int tipEnemy; // 0 - std, 1 - defencer (hp+), 2 - attacker (damage+)
        public override int Level { get; set; }

        public Enemy()
        {
            Random rand = new Random();
            tipEnemy = rand.Next(0, 3);

            switch (tipEnemy)
            {
                case 0: // standart
                    {
                        HP = 100 + (100 * Convert.ToInt32((double)Hero.Instance.GameLevel / 10)) + Hero.Instance.GameLevel * 3;
                        Damage = 15 + (10 * Convert.ToInt32((double)Hero.Instance.GameLevel / 10)) + Hero.Instance.GameLevel * 2;

                        break;
                    }

                case 1: // defencer
                    {
                        HP = 250 + (100 * Convert.ToInt32((double)Hero.Instance.GameLevel / 10)) + Hero.Instance.GameLevel * 3;
                        Damage = 10 + (10 * Convert.ToInt32((double)Hero.Instance.GameLevel / 10)) + Hero.Instance.GameLevel * 2;

                        break;
                    }

                case 2: // attacker
                    {
                        HP = 50 + (100 * Convert.ToInt32((double)Hero.Instance.GameLevel / 10)) + Hero.Instance.GameLevel * 3;
                        Damage = 30 + (10 * Convert.ToInt32((double)Hero.Instance.GameLevel / 10)) + Hero.Instance.GameLevel * 2;

                        break;
                    }

            }
        }

    }
}

