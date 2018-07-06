using System;
using System.Linq;
using System.Collections.Generic;

namespace P01.LargestCommonEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstLine = Console.ReadLine().Split(' ').ToArray();
            string[] secondLine = Console.ReadLine().Split(' ').ToArray();
            int lenghtOfShorter = Math.Min(firstLine.Length, secondLine.Length);          

            int leftCounter = 0;
            for (int i = 0; i < lenghtOfShorter; i++)
            {
                if (firstLine[i] == secondLine[i])
                {
                    leftCounter++;
                }
            }

            int rightCounter = 0;
            for (int i = 1; i <= lenghtOfShorter; i++)
            {
                if (firstLine[firstLine.Length - i] == secondLine[secondLine.Length - i])
                {
                    rightCounter++;
                }
            }

            if (leftCounter >= rightCounter)
            {
                Console.WriteLine(leftCounter);
            }
            else if (leftCounter < rightCounter)
            {
                Console.WriteLine(rightCounter);
            }
            else
            {
                Console.WriteLine(0);
            }           
        }
    }
}
