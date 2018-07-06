using System;

namespace P03.RestaurantDiscount
{
    class RestaurantDiscount
    {
        static void Main(string[] args)
        {
            var countOfPeople = int.Parse(Console.ReadLine());
            var servicePackage = Console.ReadLine();

            if (countOfPeople > 120)
            {
                Console.WriteLine("We do not have an appropriate hall.");
                Environment.Exit(0);
            }
            var hallName = "Small Hall";
            var priceOfHall = 2500;
            var priceOfPackege = 500;
            var discount = 0.95;
                       
            if (50 < countOfPeople && countOfPeople <= 100)
            {
                priceOfHall = 5000;
                hallName = "Terrace";
            }
            else if (100 < countOfPeople && countOfPeople < 120)
            {
                priceOfHall = 7500;
                hallName = "Great Hall";
            }

            switch (servicePackage)
            {
                case "Gold":
                    priceOfPackege = 750;
                    discount = 0.9;
                    break;
                case "Platinum":
                    priceOfPackege = 1000;
                    discount = 0.85;
                    break;
            }
            double totalPrice = priceOfHall + priceOfPackege;
            totalPrice *= discount;
            var pricePerPerson = totalPrice / countOfPeople;

            Console.WriteLine($"We can offer you the {hallName}\n" +
                $"The price per person is {pricePerPerson:f2}$");
        }
    }
}
