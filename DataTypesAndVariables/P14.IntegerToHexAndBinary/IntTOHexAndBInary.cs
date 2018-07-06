using System;

namespace P14.IntegerToHexAndBinary
{
    class IntTOHexAndBInary
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            //string hexValue = number.ToString("X");
            string binary = Convert.ToString(number, 2);
            string hex = Convert.ToString(number, 16).ToUpper();

            //Console.WriteLine(hexValue);
            Console.WriteLine(hex);
            Console.WriteLine(binary);

        }
    }
}
