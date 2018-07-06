using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> peopleAndNumber = new Dictionary<string, string>();
            List<string> inputLine = Console.ReadLine().Split(' ').ToList();

            while (inputLine[0] != "END")
            {
                if (inputLine[0] == "A")
                {
                    peopleAndNumber[inputLine[1]] = inputLine[2];                    
                }
                else if (inputLine[0] == "S")
                {
                    if (peopleAndNumber.ContainsKey(inputLine[1]))
                    {
                        Console.WriteLine($"{inputLine[1]} -> {peopleAndNumber[inputLine[1]]}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {inputLine[1]} does not exist.");
                    }
                }
                inputLine = Console.ReadLine().Split(' ').ToList();
            }
        }
    }
}
