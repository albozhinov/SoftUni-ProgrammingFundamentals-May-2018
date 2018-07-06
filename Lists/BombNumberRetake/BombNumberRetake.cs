using System;
using System.Collections.Generic;
using System.Linq;

namespace BombNumberRetake
{
    class BombNumberRetake
    {
        static void Main(string[] args)
        {
            List<int> inputNums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> commands = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int bombNumber = commands[0];
            int bombPower = commands[1];
            

            for (int i = 0; i < inputNums.Count; i++)
            {
                if (inputNums[i] == bombNumber)
                {
                    int left = Math.Max(0, i - bombPower);
                    int right = Math.Min(inputNums.Count - 1, i + bombPower);
                    int counter = right - left + 1;
                    inputNums.RemoveRange(left, counter);
                    i = 0;
                }
            }
            Console.WriteLine(inputNums.Sum());
        }
    }
}
