using System;

namespace DateTimeLectie
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime time1 = new DateTime();
            Console.WriteLine(time1);

            DateTime time2 = new DateTime(1999, 12, 30, 23, 11, 20);
            Console.WriteLine(time2);

            DateTime timeNow = DateTime.Now;
            Console.WriteLine("Este anul {0}, luna {1}, ziua {2}, si ora {3}:{4}:{5}", timeNow.Year, timeNow.Month, timeNow.Day, timeNow.Hour, timeNow.Minute, timeNow.Second);

            DateTime t1 = new DateTime(2003, 01, 01);
            DateTime t2 = new DateTime(2004, 01, 03);

            TimeSpan diference = t1 - t2;

            Console.WriteLine(diference); //ne returneaza in zile
        }
    }
}
