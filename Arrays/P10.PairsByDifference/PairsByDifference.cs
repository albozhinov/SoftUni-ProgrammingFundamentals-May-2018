using System;
using System.Linq;

namespace P10.PairsByDifference
{
    class PairsByDifference
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int diff = int.Parse(Console.ReadLine());
            int counter = 0;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int k = i + 1; k < numbers.Length; k++)
                {
                    if (numbers[i] - numbers[k] == diff || numbers[k] - numbers[i] == diff)
                    {
                        counter++;
                    }
                }
            }
            Console.WriteLine(counter);
        }
    }
}
