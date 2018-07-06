using System;
using System.Linq;

namespace P02.RotateAndSum
{
    class RotateAndSum
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int rotation = int.Parse(Console.ReadLine());

            int[] sumArray = new int[numbers.Length];

            for (int i = 0; i < rotation; i++)
            {
                int lastElement = numbers[numbers.Length - 1];

                for (int k = numbers.Length - 1; k > 0; k--)
                {
                    numbers[k] = numbers[k - 1];
                }
                numbers[0] = lastElement;

                for (int j = 0; j < numbers.Length; j++)
                {
                    sumArray[j] += numbers[j];
                }
            }
            Console.WriteLine(string.Join(" ", sumArray));
        }
    }
}
