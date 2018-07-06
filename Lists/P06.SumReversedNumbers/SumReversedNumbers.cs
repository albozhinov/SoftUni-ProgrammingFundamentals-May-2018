using System;
using System.Collections.Generic;
using System.Linq;

namespace P06.SumReversedNumbers
{
    class SumReversedNumbers
    {
        static void Main(string[] args)
        {
            List<string> numbers = Console.ReadLine()
                                .Split(' ')                                
                                .ToList();           
            int sum = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                List<char> reversedNums = numbers[i].ToString().ToList();
                reversedNums.Reverse();
                sum += int.Parse(string.Join("", reversedNums));
            }
            Console.WriteLine(sum);           
        }
    }
}
