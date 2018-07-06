using System;
using System.Linq;

namespace P09.IndexOfLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine().ToLower();

            char[] letters = new char[26];

            for (char i = 'a'; i <= 'z'; i++)
            {

                letters[i - 97] = i;
            }

            for (int i = 0; i < inputLine.Length; i++)
            {
                for (int k = 0; k < letters.Length; k++)
                {
                    if (inputLine[i] == letters[k])
                    {
                        Console.WriteLine($"{inputLine[i]} -> {k}");
                    }
                }
            }            
        }
    }
}
