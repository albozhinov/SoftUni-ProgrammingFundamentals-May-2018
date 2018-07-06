using System;
using System.Collections.Generic;
using System.Linq;

namespace P1._3.IntersectionOfCircles
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> cordinatesOfFirstCircle = Console.ReadLine()
                                                .Split(' ')
                                                .Select(x => int.Parse(x))
                                                .ToList();
            List<int> cordinatesOfSecCircle = Console.ReadLine()
                                              .Split(' ')
                                              .Select(x => int.Parse(x))
                                              .ToList();
            int x1 = cordinatesOfFirstCircle[0];
            int y1 = cordinatesOfFirstCircle[1];
            int radius1 = cordinatesOfFirstCircle[2];

            int x2 = cordinatesOfSecCircle[0];
            int y2 = cordinatesOfSecCircle[1];
            int radius2 = cordinatesOfSecCircle[2];

            Point firstCenter = new Point(x1, y1);
            Point secCenter = new Point(x2, y2);

            Circle firstCircle = new Circle(radius1, firstCenter.CalcPoint(firstCenter.X, firstCenter.Y));
            Circle secCircle = new Circle(radius2, secCenter.CalcPoint(secCenter.X, secCenter.Y));

            bool result = Intersect(firstCircle, secCircle);

            Console.WriteLine(result ? "Yes" : "No");
        }

        static double CalcDistance(Circle c1, Circle c2)
        {
            return Math.Sqrt(c1.Center * c1.Center + c2.Center * c2.Center);            
        }

        static bool Intersect(Circle firstCircle, Circle secondCircle)
        {
            double d = CalcDistance(firstCircle, secondCircle);
            if (d <= firstCircle.Radius + secondCircle.Radius)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    class Point
    {
        public double X { get; set; }

        public double Y { get; set; }

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        public double CalcPoint(double x, double y)
        {
            return Math.Sqrt(x * x + y * y);
        }
    }
    class Circle
    {
        public double Radius { get; set; }

        public double Center { get; set; }

        public Circle(double radius, double center)
        {
            Radius = radius;
            Center = center;
        }
    }
}
