using System;
using System.Collections.Generic;
using System.Linq;

namespace P09.LegendaryFarming
{
    class LegendaryFarming
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, int> farming = new SortedDictionary<string, int> {
                { "shards", 0},
                {"fragments", 0},
                { "motes", 0 }
              };

            Dictionary<string, int> junk = new Dictionary<string, int>();            
            string result = null;

            while (true)
            {
                string inputLine = Console.ReadLine();
                string[] array = inputLine.ToLower().Split(' ').ToArray();
                for (int i = 1; i < array.Length; i += 2)
                {
                    string item = array[i];
                    int quantity = int.Parse(array[i - 1]);
                    if (item == "shards" || item == "fragments" || item == "motes")
                    {
                        farming[item] += quantity;
                        if (farming.ContainsKey("shards") && farming["shards"] >= 250)
                        {
                            result = "Shadowmourne";
                            farming["shards"] -= 250;
                            PrintOutput(result, farming, junk);
                            Environment.Exit(0);
                        }
                        else if (farming.ContainsKey("fragments") && farming["fragments"] >= 250)
                        {
                            result = "Valanyr";
                            farming["fragments"] -= 250;
                            PrintOutput(result, farming, junk);
                            Environment.Exit(0);
                        }
                        else if (farming.ContainsKey("motes") && farming["motes"] >= 250)
                        {
                            result = "Dragonwrath";
                            farming["motes"] -= 250;
                            PrintOutput(result, farming, junk);
                            Environment.Exit(0);
                        }
                    }
                    else
                    {
                        if (!junk.ContainsKey(item))
                        {
                            junk.Add(item, quantity);
                        }
                        else
                        {
                            junk[item] += quantity;
                        }
                    }
                }               
            }            
        }

         static void PrintOutput(string result, SortedDictionary<string, int> farming, Dictionary<string, int> junk)
        {
            Console.WriteLine($"{result} obtained!");

            foreach (var kvp in farming.OrderByDescending(x => x.Value).ThenBy(y => y.Key))
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
            foreach (var kvp in junk.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
        }
    }
}
