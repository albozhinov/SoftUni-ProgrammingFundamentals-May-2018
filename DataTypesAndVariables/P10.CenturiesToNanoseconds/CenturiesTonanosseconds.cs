using System;

namespace P10.CenturiesToNanoseconds
{
    class CenturiesTonanosseconds
    {
        static void Main(string[] args)
        {
            int centuries = int.Parse(Console.ReadLine());

            var years = centuries * 100;
            var days = Math.Floor(years * 365.2422);
            var hours = days * 24;
            var minutes = hours * 60;
            var seconds = minutes * 60;
            var miliSeconds = seconds * 1000;
            decimal microSeconds = (decimal)miliSeconds * 1000;
            decimal nanoSeconds = microSeconds * 1000;

            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {miliSeconds} milliseconds = {microSeconds} microseconds = {nanoSeconds} nanoseconds");
        }
    }
}
