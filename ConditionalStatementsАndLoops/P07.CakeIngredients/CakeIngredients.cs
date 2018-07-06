using System;

namespace P07.CakeIngredients
{
    class CakeIngredients
    {
        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine();

            int count = 0;

            while (inputLine != "Bake!")
            {
                count++;
                Console.WriteLine($"Adding ingredient {inputLine}.");
                inputLine = Console.ReadLine();
            }
            Console.WriteLine("Preparing cake with {0} ingredients.", count);
        }
    }
}
