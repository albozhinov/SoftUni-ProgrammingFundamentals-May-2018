using System;
using System.Linq;

namespace P04.CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').ToArray();
            var firstWord = input[0];
            var secWord = input[1];
            int totalSum = 0;

            var minLenght = Math.Min(firstWord.Length, secWord.Length);
            var maxLenght = Math.Max(firstWord.Length, secWord.Length);
            var diff = Math.Abs(minLenght - maxLenght);

            for (int i = 0; i <minLenght; i++)
            {
                totalSum += firstWord[i] * secWord[i];
            }

            for (int i = minLenght; i < maxLenght; i++)
            {
                if (firstWord.Length > secWord.Length)
                {
                    totalSum += firstWord[i];
                }
                else if (firstWord.Length < secWord.Length)
                {
                    totalSum += secWord[i];
                }
            }
            Console.WriteLine(totalSum);
        }
    }
}
