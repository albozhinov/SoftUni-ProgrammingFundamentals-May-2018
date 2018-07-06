using System;
using System.Collections.Generic;
using System.Linq;

namespace P06.UserLogs
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> usernames = new Dictionary<string, Dictionary<string, int>>();
            List<string> inputLine = Console.ReadLine().Split(new char[] { '=', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            while (inputLine[0] != "end")
            {
                string user = inputLine[inputLine.Count - 1];
                string ipAdress = inputLine[1];

                if (!usernames.ContainsKey(user))
                {
                    usernames.Add(user, new Dictionary<string, int>());
                }

                if (!usernames[user].ContainsKey(ipAdress))
                {
                    usernames[user].Add(ipAdress, 1);
                }
                else
                {
                    usernames[user][ipAdress]++;
                }

                inputLine = Console.ReadLine().Split(new char[] { '=', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            }

            foreach (var outerPair in usernames.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{outerPair.Key}:");
                Console.WriteLine("{0}.", string.Join(", ", outerPair.Value.Select(kvp => $"{kvp.Key} => {kvp.Value}")));
            }
        }
    }
}
