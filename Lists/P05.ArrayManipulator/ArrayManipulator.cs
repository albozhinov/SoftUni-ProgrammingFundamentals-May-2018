using System;
using System.Collections.Generic;
using System.Linq;

namespace P05.ArrayManipulator
{
    class ArrayManipulator
    {
        static void Main(string[] args)
        {
            List<int> inputNums = Console.ReadLine()
                                  .Split(' ')
                                  .Select(int.Parse)
                                  .ToList();

            var command = Console.ReadLine()
                          .ToLower()
                          .Split(' ')
                          .ToList();

            while (command[0] != "print")
            {
                if (command[0] == "add")
                {
                    int index = int.Parse(command[1]);
                    int element = int.Parse(command[2]);
                    inputNums.Insert(index, element);
                }
                else if (command[0] == "addmany")
                {
                    int index = int.Parse(command[1]);

                    inputNums.InsertRange(index, command.Skip(2).Select(int.Parse));
                }
                else if (command[0] == "contains")
                {
                    int containsNum = int.Parse(command[1]);
                    if (inputNums.Contains(containsNum))
                    {
                        Console.WriteLine(inputNums.IndexOf(containsNum));
                    }
                    else
                    {
                        Console.WriteLine(-1);
                    }
                }
                else if (command[0] == "remove")
                {
                    int removeIndex = int.Parse(command[1]);
                    inputNums.RemoveAt(removeIndex);
                }
                else if (command[0] == "shift")
                {
                    int position = int.Parse(command[1]) % inputNums.Count;
                    var shifted = inputNums.Skip(position).ToList();
                    for (int i = 0; i < position; i++)
                    {
                        shifted.Add(inputNums[i]);
                    }
                    inputNums = shifted;                    
                }
                else if (command[0] == "sumpairs")
                {
                    int rotaition = inputNums.Count / 2;
                    for (int i = 0; i < rotaition; i++)
                    {
                        inputNums[i] += inputNums[i + 1];
                        inputNums.RemoveAt(i + 1);
                    }
                }               
                command = Console.ReadLine().ToLower().Split(' ').ToList();
            } 
            Console.WriteLine("[" + string.Join(", ", inputNums) + "]");
        }
    }
}
