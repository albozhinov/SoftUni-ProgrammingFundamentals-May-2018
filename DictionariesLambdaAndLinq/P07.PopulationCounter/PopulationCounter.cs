using System;
using System.Collections.Generic;
using System.Linq;

namespace P07.PopulationCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, long>> peopleCounter = new Dictionary<string, Dictionary<string, long>>();
            string[] inputLine = Console.ReadLine().Split('|').ToArray();

            while (inputLine[0] != "report")
            {
                string country = inputLine[1];
                string city = inputLine[0];
                long population = long.Parse(inputLine[2]);

                if (!peopleCounter.ContainsKey(country))
                {
                    peopleCounter.Add(country, new Dictionary<string, long>());
                }
                if (!peopleCounter[country].ContainsKey(city))
                {
                    peopleCounter[country].Add(city, population);
                } 

                inputLine = Console.ReadLine().Split('|').ToArray();
            }

            foreach (var countries in peopleCounter.OrderByDescending(x => x.Value.Values.Sum()))
            {
                Console.WriteLine($"{countries.Key} (total population: {countries.Value.Values.Sum()})");
                foreach (var kvp in countries.Value.OrderByDescending(y => y.Value))
                {
                    Console.WriteLine($"=>{kvp.Key}: {kvp.Value}");
                }
            }
        }
    }
}
