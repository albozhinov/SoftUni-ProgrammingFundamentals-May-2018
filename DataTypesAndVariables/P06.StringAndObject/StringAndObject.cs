using System;

namespace P06.StringAndObject
{
    class StringAndObject
    {
        static void Main(string[] args)
        {
            var firstLine = Console.ReadLine();
            var secLine = Console.ReadLine();

            object concatenat = firstLine + " " + secLine;

            string text = (string)concatenat;

            Console.WriteLine(text);
        }
    }
}
