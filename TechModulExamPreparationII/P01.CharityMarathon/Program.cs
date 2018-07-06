using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            var marathonDays = int.Parse(Console.ReadLine());
            var runners = long.Parse(Console.ReadLine());
            var averageNumOfLaps = int.Parse(Console.ReadLine());
            var lapLenght = int.Parse(Console.ReadLine());
            var trackCapacity = long.Parse(Console.ReadLine());
            var moneyPerKilometer = decimal.Parse(Console.ReadLine());
            
            if (runners > trackCapacity * marathonDays)
            {
                runners = trackCapacity * marathonDays;
            }

            var totalKilometers = (runners * averageNumOfLaps * lapLenght) / 1000;
            var marathonMoney = totalKilometers * moneyPerKilometer;
            Console.WriteLine($"Money raised: {marathonMoney:F2}");
        }
    }
}
