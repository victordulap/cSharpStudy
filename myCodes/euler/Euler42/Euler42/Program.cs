using System;
using System.Collections.Generic;
using System.IO;
using System.Diagnostics;

namespace Euler42
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch clock = Stopwatch.StartNew();
            /*
				   The nth term of the sequence of triangle numbers is given by, tn = ½n(n+1); so the first ten triangle numbers are:
				   1, 3, 6, 10, 15, 21, 28, 36, 45, 55, ...
				   //done

				   By converting each letter in a word to a number corresponding to its alphabetical position and adding
                   these values we form a word value. For example, the word value for SKY is 19 + 11 + 25 = 55 = t10.
				   If the word value is a triangle number then we shall call the word a triangle word.
                   //done

				   Using words.txt (right click and 'Save Link/Target As...'), a 16K text file containing nearly two-thousand common
                   English words, how many are triangle words?
			 */

            #region examples
            //// generate triangle numbers:
            //int n = 500;
            //List<int> triangleNumbers = new List<int>();
            //for (int i = 1; i <= n; i++)
            //{
            //    int nr = (int)(0.5 * i * (i + 1));
            //    triangleNumbers.Add(nr);
            //}

            //// word to number:
            //string exampleWord = "SKY";
            //int sum = 0;
            //for (int i = 0; i < exampleWord.Length; i++)
            //{
            //    sum += GetAlphabeticIndex(exampleWord[i]);
            //}

            //Console.WriteLine(sum);
            #endregion

            // generate triangle numbers:
            int n = 500;
            List<int> triangleNumbers = new List<int>();
            for (int i = 1; i <= n; i++)
            {
                int nr = (int)(0.5 * i * (i + 1));
                triangleNumbers.Add(nr);
            }

            // open file and assign to a string
            string readText = File.ReadAllText(@"D:\C_Sharp\myCodes\euler\Euler42\Euler42\words.txt");

            // remove "s
            readText = readText.Replace("\"", "");

            string[] words = readText.Split(',');

            int sumOfTriangleWords = 0;
            foreach (var word in words)
            {
                if (IsTriangleWord(word, triangleNumbers)) sumOfTriangleWords++;
            }

            Console.WriteLine(sumOfTriangleWords);

            clock.Stop();
            Console.WriteLine($"Time: {clock.ElapsedMilliseconds} ms.");
        }

        static int GetIndexFromAlphabet(char character)
        {
            //character = char.ToUpper(character);
            return (int)(character - 64);
        }

        static int SumOfWord(string word)
        {
            int sum = 0;

            for (int i = 0; i < word.Length; i++)
            {
                sum += GetIndexFromAlphabet(word[i]);
            }

            return sum;
        }

        static bool IsTriangleWord(string word, List<int> triangleNumbers)
        {
            int sumOfWord = SumOfWord(word);

            foreach (var triangleNumber in triangleNumbers)
            {
                if (triangleNumber == sumOfWord) return true;
            }

            return false;
        }
    }
}
