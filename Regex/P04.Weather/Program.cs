using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;

namespace P04.Weather
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputLine = Console.ReadLine();
            string pattern = @"([A-Z]{2})([0-9]{2}\.[0-9]{0,2})([a-zA-Z]+)\|";

            List<CitiesWeather> myCities = new List<CitiesWeather>();
            CitiesWeather currCity = null;

            string nameOfCity = "";
            double temperature;
            string typeOfWeather = "";

            while (inputLine != "end")
            {
                MatchCollection myMatches = Regex.Matches(inputLine, pattern);

                foreach (Match item in myMatches)
                {
                    nameOfCity = item.Groups[1].Value;
                    temperature = double.Parse(item.Groups[2].Value);
                    typeOfWeather = item.Groups[3].Value;
                    if (!myCities.Any(c => c.City == nameOfCity))
                    {
                        currCity = new CitiesWeather();

                        currCity.City = nameOfCity;
                        currCity.AverageTemperature = temperature;
                        currCity.TypeOfWeather = typeOfWeather;
                        myCities.Add(currCity);
                    }
                    else
                    {
                        currCity = myCities.First(x => x.City == nameOfCity);
                        currCity.AverageTemperature = temperature;
                        currCity.TypeOfWeather = typeOfWeather;
                    }
                }
                inputLine = Console.ReadLine();
            }
            foreach (var city in myCities.OrderBy(x => x.AverageTemperature))
            {
                Console.WriteLine($"{city.City} => {city.AverageTemperature:F2} => {city.TypeOfWeather}");
            }
        }
    }
    class CitiesWeather
    {
        public string City { get; set; }

        public double AverageTemperature { get; set; }

        public string TypeOfWeather { get; set; }
    }
}
