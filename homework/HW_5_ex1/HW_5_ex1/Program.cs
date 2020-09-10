using System;
using CalculeNameSpace;

namespace Executie
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1, b = 0;
            try
            {
                Console.WriteLine(Calcule.Divide(a, b));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
