using System;
using System.Collections.Generic;
using System.Linq;

namespace P03.SearchForANumber
{
    class SearchForANumber
    {
        static void Main(string[] args)
        {
            List<int> inputNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int[] arrOfThreeNum = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            if (inputNumbers.Take(arrOfThreeNum[0]).Skip(arrOfThreeNum[1]).Contains(arrOfThreeNum[2]))
            {
                Console.WriteLine("YES!");
            }            
            else
	        {
                Console.WriteLine("NO!");
            }
            //List<int> takesNumbers = new List<int>();

            //for (int i = 0; i < arrOfThreeNum[0]; i++)
            //{
            //    takesNumbers.Add(inputNumbers[i]);
            //}
            //takesNumbers.RemoveRange(0, arrOfThreeNum[1]);

            //if (takesNumbers.Contains(arrOfThreeNum[2]))
            //{
            //    Console.WriteLine("YES!");
            //}
            //else
            //{
            //    Console.WriteLine("NO!");
            //}
        }
    }
}
