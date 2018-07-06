using System;
using System.Linq;
using System.Collections.Generic;

namespace P05.MagicExchangeableWords
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').ToArray();

            var firstWord = input[0];
            var secWord = input[1];

            var firstCounter = new List<char>();
            var secCounter = new List<char>();

            for (int i = 0; i < firstWord.Length; i++)
            {
                if (!firstCounter.Contains(firstWord[i]))
                {
                    firstCounter.Add(firstWord[i]);
                }
            }

            for (int i = 0; i < secWord.Length; i++)
            {
                if (!secCounter.Contains(secWord[i]))
                {
                    secCounter.Add(secWord[i]);
                }
            }

            var result = Math.Abs(secCounter.Count - firstCounter.Count);
            string print = result == 0 ? "true" : "false";

            Console.WriteLine($"{print}");
        }
    }
}
