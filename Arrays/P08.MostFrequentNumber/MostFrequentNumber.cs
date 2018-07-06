using System;
using System.Linq;

namespace P08.MostFrequentNumber
{
    class MostFrequentNumber
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int number = 0;            
            int bestLen = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int len = 0;

                for (int k = i; k < numbers.Length; k++)
                {
                    if (numbers[i] == numbers[k])
                    {
                        len++;
                        if (bestLen < len)
                        {
                            bestLen = len;
                            number = numbers[i];
                        }                       
                    }
                }                
            }
            Console.WriteLine(number);            
        }
    }
}
