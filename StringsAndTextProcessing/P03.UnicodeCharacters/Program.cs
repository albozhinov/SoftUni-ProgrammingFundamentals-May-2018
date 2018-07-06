using System;

namespace P03.UnicodeCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();


            foreach (var symbol in input)
            {
                Console.Write($"\\u{(int)symbol:x4}");
            }
            Console.WriteLine();
        }
    }
}
