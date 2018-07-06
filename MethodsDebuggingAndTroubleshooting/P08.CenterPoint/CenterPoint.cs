using System;

namespace P08.CenterPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());

            PrintCloserPoint(x1, y1, x2, y2);            
        }       

        static void PrintCloserPoint(double x1, double y1, double x2, double y2)
        {
            double point1 = Math.Sqrt(x1 * x1 + y1 * y1);
            double point2 = Math.Sqrt(x2 * x2 + y2 * y2);

            if (point1 < point2 || point1 == point2)
            {
                Console.WriteLine($"({x1}, {y1})");
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})");
            }

        }
    }
}
