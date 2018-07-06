using System;

namespace P10.CubeProperties
{
    class CUbeProperties
    {
        static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());
            string parameter = Console.ReadLine().ToLower();

            double result = CalculateCubeProperties(side, parameter);

            Console.WriteLine($"{result:f2}");
        }

        static double CalculateCubeProperties(double side, string propertie)
        {
            switch (propertie)
            {
                case "face":
                    return Math.Sqrt(2 * side * side);
                case "volume":
                    return side * side * side;
                case "space":
                    return Math.Sqrt(3 * side * side);
                case "area":
                    return 6 * (side * side);
                default:
                    return 0.0;
            }
        }
    }
}
