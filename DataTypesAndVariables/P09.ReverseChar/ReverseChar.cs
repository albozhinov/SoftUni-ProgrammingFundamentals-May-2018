using System;

namespace P09.ReverseChar
{
    class ReverseChar
    {
        static void Main(string[] args)
        {
            var firstChar = char.Parse(Console.ReadLine());
            var secChar = char.Parse(Console.ReadLine());
            var thirdChar = char.Parse(Console.ReadLine());

            Console.WriteLine($"{thirdChar}{secChar}{firstChar}");
        }
    }
}
