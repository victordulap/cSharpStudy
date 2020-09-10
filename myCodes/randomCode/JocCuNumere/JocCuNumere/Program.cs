using System;
using System.Collections.Specialized;
using System.Threading;

namespace JocCuNumere
{
    class Program
    {
        public int count = 0;

        static void Main(string[] args)
        {
            int choise;
            Program laur = new Program();


            do
            {
                Console.Clear();
                Console.WriteLine(" Enter 1 to start game or 0 to stop game ");
                choise = Convert.ToInt32(Console.ReadLine());
                switch (choise)
                {
                    case 1:
                        laur.PlayGame();
                        break;
                    case 0:
                        Console.WriteLine(" Good Luck!");
                        break;
                }
            } while (choise != 0);

        }

        public void PlayGame()
        {

            Random random = new Random();
            int s_number = random.Next(0, 10);
            Console.WriteLine("Guess a number from 0 to 10 ");
            Console.WriteLine("Current game : " + count);
            while (true)
            {
                Console.Write(" Enter your guess : ");
                int x = Convert.ToInt32(Console.ReadLine());

                if (x > s_number)
                {
                    Console.Write(" The Secret number is smaller \n");
                }
                else if (x < s_number)
                {
                    Console.Write(" The Secret number is bigger \n");
                }
                else
                {
                    Console.Write(" You Win!!! \n");
                    Console.Beep();
                    Console.Beep();
                    Console.Beep();
                    count++;
                    break;
                }
            }
        }

    }

}