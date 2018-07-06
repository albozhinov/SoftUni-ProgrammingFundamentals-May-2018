using System;
using System.Linq;

namespace P03.FoldAndSum
{
    class FoldAndSum
    {
        static void Main(string[] args)
        {
            int[] inputRow = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int[] firstRow = new int[inputRow.Length / 2];

            for (int i = 0; i < firstRow.Length / 2; i++)
            {
                firstRow[i] = inputRow[(inputRow.Length / 4) - 1 - i];
            }

            for (int i = 0; i < firstRow.Length / 2; i++)
            {
                firstRow[firstRow.Length / 2 + i] = inputRow[inputRow.Length - 1 - i];
            }

            int[] sumArrays = new int[inputRow.Length / 2];

            for (int i = 0; i < sumArrays.Length; i++)
            {
                sumArrays[i] = inputRow[inputRow.Length / 4 + i] + firstRow[i];
            }            

            Console.WriteLine(string.Join(" ", sumArrays));
        }
    }
}
