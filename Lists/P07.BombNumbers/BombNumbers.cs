using System;
using System.Collections.Generic;
using System.Linq;

namespace P07.BombNumbers
{
    class BombNumbers
    {
        static void Main(string[] args)
        {
            List<int> inputLine = Console.ReadLine()
                                  .Split(' ')
                                  .Select(int.Parse)
                                  .ToList();
            int[] bomb = Console.ReadLine()
                         .Split(' ')
                         .Select(int.Parse)
                         .ToArray();

            int number = bomb[0];
            int power = bomb[1];

            for (int i = 0; i < inputLine.Count; i++)
            {
                if (inputLine[i] == number)
                {
                    int left = Math.Max(i - power, 0);
                    int right = Math.Min(i + power, inputLine.Count - 1);
                    int lenght = right - left + 1;

                    inputLine.RemoveRange(left, lenght);
                    i = 0;
                }
            }
            Console.WriteLine(inputLine.Sum());
        }
    }
}
