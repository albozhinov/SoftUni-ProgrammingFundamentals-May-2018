using System;

namespace P04.NumbersInReversedOrder
{
    class NumberInReversedOrder
    {
        static void Main(string[] args)
        {
            var inputLine = Console.ReadLine();

            PrintNumberInReversedOrder(inputLine);
        }

        private static void PrintNumberInReversedOrder(string text)
        {
            char[] charArray = text.ToCharArray();            
            Array.Reverse(charArray);
            Console.WriteLine(charArray);
        }
    }
}
