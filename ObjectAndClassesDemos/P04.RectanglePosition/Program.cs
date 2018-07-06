using System;
using System.Linq;

namespace P04.RectanglePosition
{
    class Program
    {
        static void Main()
        {
            var firstRectangle = ReadRectangle();
            var secRectangle = ReadRectangle();
            var result = firstRectangle.IsInside(secRectangle) ? "Inside" : "Not inside";

            Console.WriteLine($"{result}");
        }

        static Rectangle ReadRectangle()
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            return new Rectangle()
            {
                Left = input[0],
                Top = input[1],
                Width = input[2],
                Height = input[3]
            };
        }
    }
}
