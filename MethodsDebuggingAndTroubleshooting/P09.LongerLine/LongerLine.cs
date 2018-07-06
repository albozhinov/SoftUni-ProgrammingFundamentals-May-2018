using System;

namespace P09.LongerLine
{
    class LongerLine
    {
        static void Main(string[] args)
        {
            double maxDistance = double.MinValue;
            double maxX1 = 0.0;
            double maxY1 = 0.0;
            double maxX2 = 0.0;
            double maxY2 = 0.0;

            for (int i = 0; i < 2; i++)
            {
                double x1 = double.Parse(Console.ReadLine());
                double y1 = double.Parse(Console.ReadLine());
                double x2 = double.Parse(Console.ReadLine());
                double y2 = double.Parse(Console.ReadLine());

                var currentDistance = CalcDistance(x1, y1, x2, y2);

                if (currentDistance > maxDistance)
                {
                    maxDistance = currentDistance;
                    maxX1 = x1;
                    maxX2 = x2;
                    maxY1 = y1;
                    maxY2 = y2;
                }
            }
            PrintPoints(maxX1, maxY1, maxX2, maxY2);           
        }

        static void PrintPoints(double x1, double y1, double x2, double y2)
        {
            double point1 = Math.Sqrt(x1 * x1 + y1 * y1);
            double point2 = Math.Sqrt(x2 * x2 + y2 * y2);

            if (point1 < point2 || point1 == point2)
            {
                Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
            }

        }

        static double CalcDistance(double x1, double y1, double x2, double y2)
        {            
            double lineLenght = Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2));
            return lineLenght;            
        }
    }
}
