using System;
using System.Linq;

namespace P02.RandomizeWords
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').ToArray();

            var random = new Random();

            for (int i = 0; i < input.Length; i++)
            {
                var currentword = input[i];

                var randomindex = random.Next(0, input.Length);
                var randomWord = input[randomindex];

                input[i] = randomWord;
                input[randomindex] = currentword;
            }

            foreach (var word in input)
            {
                Console.WriteLine(word);
            }
        }
    }
}
