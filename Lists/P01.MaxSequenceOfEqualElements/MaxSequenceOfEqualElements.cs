using System;
using System.Collections.Generic;
using System.Linq;

namespace P01.MaxSequenceOfEqualElements
{
    class MaxSequenceOfEqualElements
    {
        static void Main(string[] args)
        {
            List<int> inputNumbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            int number = inputNumbers[0];
            int len = 1;
            int bestLen = 1;


            for (int i = 1; i < inputNumbers.Count; i++)
            {
                if (inputNumbers[i] == inputNumbers[i - 1])
                {
                    len++;
                    if (len > bestLen)
                    {
                        bestLen = len;
                        number = inputNumbers[i];
                    }
                }
                else
                {
                    len = 1;                    
                }
            }
            for (int i = 0; i < bestLen; i++)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }
    }
}
