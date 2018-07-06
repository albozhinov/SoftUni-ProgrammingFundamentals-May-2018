using System;
using System.Linq;

namespace P06.MaxSequenceOfEqualElements
{
    class MaxSequenceOfEqualElements
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int lenght = 1;
            int number = 0;
            int bestLen = 0;
            

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i - 1] == numbers[i])
                {
                    lenght++;
                    if (lenght > bestLen)
                    {
                        bestLen = lenght;
                        number = numbers[i];
                    }
                }
                else
                {
                    lenght = 1;                    
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
