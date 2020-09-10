using System;

namespace Euler21
{
	

	class Program
    {
        static void Main(string[] args)
        {
			long sum = 0;
			int verify;
			for (int i = 1; i < 10000; i++)
			{
				verify = d(i);
				if (d(verify) == i && verify != i)
				{
					sum += i;
					Console.WriteLine(i.ToString().PadLeft(5) + " | " + verify);
				}
			}

			Console.WriteLine($"\nsum = {sum}");
		}

		static int d(int nr)
		{
			int D = 0;
			for (int i = 1; i <= nr / 2; i++)
			{
				if (nr % i == 0)
				{
					D += i;
				}
			}
			return D;
		}
	}
}
