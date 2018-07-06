using System;
using System.Collections.Generic;
using System.Linq;

namespace P08.LogsAggregator
{
    class LogsAggregator1
    {
        static void Main(string[] args)
        {
            Dictionary<string, SortedDictionary<string, int>> logs = new Dictionary<string, SortedDictionary<string, int>>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] inputLine = Console.ReadLine().Split(' ').ToArray();

                string user = inputLine[1];
                string ipAddress = inputLine[0];
                int duration = int.Parse(inputLine[2]);

                if (!logs.ContainsKey(user))
                {
                    logs.Add(user, new SortedDictionary<string, int>());
                }
                if (!logs[user].ContainsKey(ipAddress))
                {
                    logs[user].Add(ipAddress, duration);
                }
                else
                {
                    logs[user][ipAddress] += duration;
                }                
            }

            foreach (var outerPair in logs.OrderBy(x => x.Key))
            {
                int sumOfDuration = outerPair.Value.Values.Sum();
                
                Console.WriteLine($"{outerPair.Key}: {sumOfDuration} [{string.Join(", ", outerPair.Value.Select(x => $"{x.Key}"))}]");
            }
        }
    }
}
