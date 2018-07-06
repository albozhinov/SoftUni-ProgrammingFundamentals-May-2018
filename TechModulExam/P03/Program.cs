using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace P03
{
    class Program
    {
        static void Main(string[] args)
        {
            string namePattern = @"%([A-Z][a-z]+)%";
            string productPattern = @"<(\w+)>";
            string countPattern = @"\|(\d+)\|";
            string pricePattern = @"([\d]+\.?[\d]*)\$";


            Dictionary<string, string> nameToProduct = new Dictionary<string, string>();
            Dictionary<string, decimal> nameToPrice = new Dictionary<string, decimal>();

            Regex regName = new Regex(namePattern);
            Regex regProduct = new Regex(productPattern);
            Regex regCount = new Regex(countPattern);
            Regex regPrice = new Regex(pricePattern);


            while (true)
            {
                var inputLine = Console.ReadLine();

                if (inputLine == "end of shift")
                {
                    break;
                }

                if (!regName.IsMatch(inputLine) || !regProduct.IsMatch(inputLine) || !regCount.IsMatch(inputLine) || !regPrice.IsMatch(inputLine))
                {
                    continue;
                }

                
                var name = regName.Match(inputLine).Groups[1].ToString();
                var product = regProduct.Match(inputLine).Groups[1].ToString();
                var count = int.Parse(regCount.Match(inputLine).Groups[1].ToString());
                var price = decimal.Parse(regPrice.Match(inputLine).Groups[1].ToString());

                if (!nameToProduct.ContainsKey(name))
                {
                    var totalPrice = count * price;
                    nameToProduct.Add(name, product);
                    nameToPrice.Add(name, totalPrice);
                }
                
               
            }

            foreach (var item in nameToProduct)
            {
                Console.WriteLine($"{item.Key}: {item.Value} - {nameToPrice[item.Key]:F2}");
            }
            Console.WriteLine($"Total income: {nameToPrice.Sum(x => x.Value):F2}");
        }
    }
}
