using System;
using System.Collections.Generic;
using System.Linq;

namespace P02.ChangeList
{
    class ChangeList
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                   .Split(' ')
                   .Select(int.Parse)
                   .ToList();

            List<string> command = Console.ReadLine()
                .ToLower()
                .Split(' ')
                .ToList();

            do
            {     
                if (command[0] == "delete")
                {
                    int numberToRemove = int.Parse(command[1]);
                    numbers.RemoveAll(x => x == numberToRemove);
                }
                else if (command[0] == "insert")
                {
                    var element = int.Parse(command[1]);
                    var position = int.Parse(command[2]);
                    numbers.Insert(position, element);
                }
                else if (command[0] == "odd")
                {
                    numbers.RemoveAll(x => x % 2 == 0);
                    Console.WriteLine(string.Join(" ", numbers));
                    return;
                }
                else if (command[0] == "even")
                {
                    numbers.RemoveAll(x => x % 2 == 1);
                    Console.WriteLine(string.Join(" ", numbers));
                    return;
                }
                command = Console.ReadLine()
                          .ToLower()
                          .Split(' ')
                          .ToList();

            } while (command[0] != "odd" || command[0] != "even");            
        }
    }
}
