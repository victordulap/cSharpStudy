using System;
using System.Threading;

namespace Timer
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i< 10; i++)
            {
                Thread.Sleep(1000);
                Console.Beep();
            }
        }
    }
}
