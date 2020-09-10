using System;

namespace lectia_5_13_2020_ex1
{
    public class Angajat
    {
        private int salariu;

        public Angajat()
        {
            salariu = 0;
        }

        public int GetSalariu => salariu;
        public void SetSalariu(int _salariu) { salariu = _salariu; }

        public void MinusSalariu(int val) 
        {
            int rezult = salariu - val;
            try
            {
                if (rezult < 0)
                {
                    throw new Exception("Salariu nu poate fi negativ!");
                }
                else
                {
                    salariu -= val;
                    Console.WriteLine("Salariu nou = " + salariu);
                }
            }
            catch
            {
                Console.WriteLine("Schimbarea nu a fost acceptata. Salariu a ramas {0}", rezult);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Angajat rab = new Angajat();

            rab.SetSalariu(1000);
            rab.MinusSalariu(1001);
        }
    }
}
