using System;
using System.Collections.Generic;
using System.Linq;

namespace P05.SalesReport
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            var salesByTown = new SortedDictionary<string, decimal>();

            for (int i = 0; i < n; i++)
            {
                var sale = ReadSale();
                decimal sum = sale.Price * (decimal)sale.Quantity;

                if (!salesByTown.ContainsKey(sale.Town))
                {
                    salesByTown.Add(sale.Town, sum);
                }
                else
                {
                    salesByTown[sale.Town] += sum;
                }
            }

            foreach (var kvp in salesByTown)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value:F2}");
            }
        }
        static Sales ReadSale()
        {
            var inputLine = Console.ReadLine().Split(' ').ToList();

            return new Sales()
            {
                Town = inputLine[0],
                Product = inputLine[1],
                Price = decimal.Parse(inputLine[2]),
                Quantity = double.Parse(inputLine[3])
            };
        }
    }
}
