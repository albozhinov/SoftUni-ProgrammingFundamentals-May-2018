using System;

namespace P02.PracticeFloatingPointNumbers
{
    class FloatingPointNumbers
    {
        static void Main(string[] args)
        {
            var num1 = decimal.Parse(Console.ReadLine());
            var num2 = double.Parse(Console.ReadLine());
            var num3 = decimal.Parse(Console.ReadLine());

            Console.WriteLine(num1);
            Console.WriteLine(num2);
            Console.WriteLine(num3);
        }
    }
}
