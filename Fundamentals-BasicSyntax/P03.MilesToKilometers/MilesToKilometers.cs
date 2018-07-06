using System;

namespace P03.MilesToKilometers
{
    class MilesToKilometers
    {
        static void Main(string[] args)
        {
            var inputMiles = double.Parse(Console.ReadLine());

            var kilometers = inputMiles * 1.60934;

            Console.WriteLine($"{kilometers:F2}");
        }
    }
}
