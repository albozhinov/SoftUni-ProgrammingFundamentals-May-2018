using System;

namespace P17.PrintPartOfASCIITable
{
    class PrintPartOfASCIITable
    {
        static void Main(string[] args)
        {
            var firstLine = int.Parse(Console.ReadLine());
            var secLine = int.Parse(Console.ReadLine());

            for (int i = firstLine; i <= secLine; i++)
            {
                Console.Write(Convert.ToChar(i) + " ");
            }
            Console.WriteLine();
        }
    }
}
