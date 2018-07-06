using System;

namespace P11.GeometryCalculator
{
    class GeometryCalculator
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine().ToLower();

            double areaOfFigure = CalculateTheAreaOfFigure(figure);
            Console.WriteLine($"{areaOfFigure:f2}");
        }

        static double CalculateTheAreaOfFigure(string typeOfFigure)
        {
            switch (typeOfFigure)
            {
                case "triangle":
                    double side = double.Parse(Console.ReadLine());
                    double height = double.Parse(Console.ReadLine());
                    return (side * height) / 2;
                case "square":
                    double sideSquare = double.Parse(Console.ReadLine());
                    return sideSquare * sideSquare;
                case "rectangle":
                    double width = double.Parse(Console.ReadLine());
                    double heightRectangle = double.Parse(Console.ReadLine());
                    return width * heightRectangle;
                case "circle":
                    double radius = double.Parse(Console.ReadLine());
                    return Math.PI * radius * radius;
                default:
                    return 0.0;
            }
        }
    }
}
