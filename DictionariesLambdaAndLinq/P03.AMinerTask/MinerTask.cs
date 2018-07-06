using System;
using System.Collections.Generic;
using System.Linq;

namespace P03.AMinerTask
{
    class MinerTask
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            
            Dictionary<string, int> miner = new Dictionary<string, int>();
            

            while (input != "stop")
            {
                int number = int.Parse(Console.ReadLine());
                if (!miner.ContainsKey(input))
                {
                    miner[input] = number;
                }
                else
                {
                    miner[input] += number;
                }

                input = Console.ReadLine();                
            }
            foreach (var kvp in miner)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
