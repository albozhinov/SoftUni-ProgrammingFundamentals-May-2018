using System;

namespace P04.Hotel
{
    class Hotel
    {
        static void Main(string[] args)
        {
            var month = Console.ReadLine();
            var countOfNight = int.Parse(Console.ReadLine());

            double priceOfStudio = 68;
            double priceOfDouble = 77;
            double priceOfSuite = 89;

            switch (month)
            {
                case "May":
                case "October":
                    priceOfStudio = 50;
                    priceOfDouble = 65;
                    priceOfSuite = 75;
                    break;
                case "June":
                case "September":
                    priceOfStudio = 60;
                    priceOfDouble = 72;
                    priceOfSuite = 82;
                    break;
            }

            double totalStudio = countOfNight * priceOfStudio;
            double totalDouble = countOfNight * priceOfDouble;
            double totalSuite = countOfNight * priceOfSuite;

            if (7 < countOfNight)
            {
                if (month == "May" || month == "October")
                {
                    priceOfStudio *= 0.95;
                    totalStudio = countOfNight * priceOfStudio;     
                }
                if (month == "September" || month == "October")
                {
                    totalStudio -= priceOfStudio;
                }
            }
            if (countOfNight > 14)
            {
                if (month == "June" || month == "September")
                {
                    priceOfDouble *= 0.90;
                    totalDouble = countOfNight * priceOfDouble;
                }
                else if (month == "July" || month == "August" || month == "December")
                {
                    priceOfSuite *= 0.85;
                    totalSuite = countOfNight * priceOfSuite;
                }
            }
            Console.WriteLine($"Studio: {totalStudio:f2} lv.");
            Console.WriteLine($"Double: {totalDouble:f2} lv.");
            Console.WriteLine($"Suite: {totalSuite:f2} lv.");
        }
    }
}
