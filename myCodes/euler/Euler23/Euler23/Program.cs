using System;
using System.Collections.Generic;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        Stopwatch clock = Stopwatch.StartNew();

        List<int> abudantNumbers = new List<int>();
        for (int i = 12; i < 28123; i++)
        {
            if (CheckAbudant(i))
            {
                abudantNumbers.Add(i);
            }
        }

        int sum = 0;
        for (int i = 1; i <= 28123; i++)
        {
            if (CheckIfSumOf2Abudant(i, abudantNumbers))
            {
                sum += i;
                Console.WriteLine($"sum: {sum} | i: {i}");
            }
        }

        Console.WriteLine("Sum = {0}", sum);

        clock.Stop();
        Console.WriteLine("Solution took {0} ms", clock.ElapsedMilliseconds);
    }

    static bool CheckAbudant(int nr)
    {
        int sum = 0;
        for (int i = 1; i <= nr / 2; i++)
        {
            if (nr % i == 0) sum += i;
        }

        if (nr < sum) return true;
        else return false;
    }

    static bool CheckIfSumOf2Abudant(int nr, List<int> _abudantNumbers)
    {
        // copy
        List<int> abudantNumbers = new List<int>(_abudantNumbers);

        for (int i = 0; i < abudantNumbers.Count; i++)
        {
            for (int j = i; j < abudantNumbers.Count; j++)
            {
                //Console.WriteLine($"i: {i}   /   j: {j}");
                if ((abudantNumbers[i] + abudantNumbers[j]) == nr)
                {
                    return false;
                }
            }
            abudantNumbers.RemoveAt(i);
        }

        return true;
    }
}

