using System;

namespace HelloName
{
    class HelloName
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();

            PrintName(name);
        }

        static void PrintName(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
