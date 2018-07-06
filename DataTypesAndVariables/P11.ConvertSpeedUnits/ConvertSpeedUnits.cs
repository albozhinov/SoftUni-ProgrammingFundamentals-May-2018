using System;

namespace P11.ConvertSpeedUnits
{
    class ConvertSpeedUnits
    {
        static void Main(string[] args)
        {
            float distance = float.Parse(Console.ReadLine());
            float hours = float.Parse(Console.ReadLine());
            float minutes = float.Parse(Console.ReadLine());
            float seconds = float.Parse(Console.ReadLine());

            float allTime = (((hours * 60) + minutes) * 60) + seconds;
            float speedInMetersPerSecond = distance / allTime;
            float speedInKmPerHour = speedInMetersPerSecond * 3.6F;
            float speedMilesPerhours = speedInKmPerHour * 0.621504065F;
            Console.WriteLine(speedInMetersPerSecond);
            Console.WriteLine(speedInKmPerHour);
            Console.WriteLine(speedMilesPerhours);
        }
    }
}
