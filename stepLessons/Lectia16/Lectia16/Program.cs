using System;

namespace Lectia16
{
    namespace ExpresiiFunc
    {
        class Program
        {
            static void Main()
            {
                Func<string, string> func1 = (x) => (x.Remove(x.Length / 2, x.Length / 2));
                Console.WriteLine(func1.Invoke("abcdefg"));

            }
        }
    }

}
