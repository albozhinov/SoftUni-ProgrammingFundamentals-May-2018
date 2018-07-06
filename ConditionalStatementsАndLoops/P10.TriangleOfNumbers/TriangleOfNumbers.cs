using System;

namespace P10.TriangleOfNumbers
{
    class TriangleOfNumbers
    {
        static void Main(string[] args)
        {
            var inputLine = int.Parse(Console.ReadLine());

            for (int i = 1; i <= inputLine; i++)
            {
                for (int k = 0; k < i; k++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
