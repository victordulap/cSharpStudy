using System;
using System.Collections.Generic;
using System.Text;

namespace Euler35
{
    class Program
    {
        static void Main(string[] args)
        {
            //do
            //{
            //    int n = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine(Prime(n));
            //} while (true);

            List<int> x = Rotations(197);
            foreach (var item in x)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            x = Rotations(197);
            foreach (var item in x)
            {
                Console.WriteLine(item);
            }
        }

        static bool Prime(int nr)
        {
            if (nr <= 1) return false;
            if (nr <= 3) return true;

            for (int i = 2; i * i <= nr; i++) // saw on internet that i*i <= nr is faster than i <= Math.Sqrt(nr)
            {
                if (nr % i == 0) return false;
            }

            return true;
        }

        static List<int> Rotations(int nr)
        {
            List<int> rezult = new List<int>();

            string str = nr.ToString();
            int len = nr.ToString().Length;

            rezult.Add(nr);

            
            for (int i = 0; i < len - 1; i++)
            {
                char[] nrToAdd = new char[str.Length];
                string s = rezult[i].ToString();
                for (int j = 0; j < len; j++)
                {
                    int poz = j;
                    if ((poz + (len - 1)) > (len - 1))
                    {
                        poz += len - 1 - len;
                    }
                    else
                    {
                        poz += (len - 1);
                    }

                    nrToAdd[j] = s[poz];
                }

                string s2 = new string(nrToAdd);
                rezult.Add(Convert.ToInt32(s2));
            }

            #region
            //int[] nums = new int[str.Length];
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    nums[i] = 0;
            //}

            //int k = 0;
            //for (int i = 0; i < str.Length; i++)
            //{
            //    for (int j = 0; j < str.Length; j++, k++)
            //    {
            //        nums[j] += Convert.ToInt32(str[i] - 48) * (int)(Math.Pow(10,k));
            //        Console.WriteLine($"i: {i}, j: {j}, nums[j] = {nums[j]}");
            //    }
            //}

            //for (int i = 0; i < nums.Length; i++)
            //{
            //    rezult.Add(nums[i]);
            //}

            //for (int i = 1; i < rezult.Count; i++)
            //{
            //    string strNr;

            //}
            #endregion

            return rezult;
        }
    }
}
