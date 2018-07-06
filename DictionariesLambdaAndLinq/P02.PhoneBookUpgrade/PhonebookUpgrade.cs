using System;
using System.Collections.Generic;
using System.Linq;

namespace P02.PhoneBookUpgrade
{
    class PhonebookUpgrade
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(' ').ToList();
            Dictionary<string, string> phoneBook = new Dictionary<string, string>();

            while (input[0] != "END")
            {
                if (input[0] == "A")
                {
                    phoneBook[input[1]] = input[2];
                }
                else if (input[0] == "S")
                {
                    if (phoneBook.ContainsKey(input[1]))
                    {
                        Console.WriteLine($"{input[1]} -> {phoneBook[input[1]]}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {input[1]} does not exist.");
                    }
                }
                else if (input[0] == "ListAll")
                {
                    var print = phoneBook.OrderBy(key => key.Key);
                    foreach (var kvp in print)
                    {
                        Console.WriteLine("{0} -> {1}", kvp.Key, kvp.Value);
                    }
                }
                input = Console.ReadLine().Split(' ').ToList();
            }            
        }
    }
}
