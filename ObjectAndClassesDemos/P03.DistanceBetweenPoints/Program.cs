using System;
using System.Collections.Generic;
using System.Linq;

namespace P03.DistanceBetweenPoints
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            var allPoint = new List<Point>();

            for (int i = 0; i < n; i++)
            {
                var currentPoint = ReadPoint();
                allPoint.Add(currentPoint);
            }

            var minDistance = double.MaxValue;
            Point firstMinPoint = null;
            Point secMinPoint = null;

            for (int i = 0; i < n; i++)
            {
                for (int k = i + 1; k < n; k++)
                {
                    var firstPoint = allPoint[i];
                    var secPoint = allPoint[k];

                    var currentDistance = Distance(firstPoint, secPoint);
                    if (currentDistance < minDistance)
                    {
                        minDistance = currentDistance;
                        firstMinPoint = firstPoint;
                        secMinPoint = secPoint;
                    }
                }

            }
            Console.WriteLine($"{minDistance:F3}");
            Console.WriteLine(firstMinPoint.Print());
            Console.WriteLine(secMinPoint.Print());


        }
        static double Distance(Point point1, Point point2)
        {
            var diffX = point1.X - point2.X;
            var powX = diffX * diffX;

            var diffY = point1.Y - point2.Y;
            var powY = diffY * diffY;

            return Math.Sqrt(powX + powY);
        }

        static Point ReadPoint()
        {
            var readPoint = Console.ReadLine().Split(' ');

            var point = new Point()
            {
                X = int.Parse(readPoint[0]),
                Y = int.Parse(readPoint[1])
            };
            return point;
        }
    }
}
