using System;
using System.Collections.Generic;

namespace P07.PrimesInGivenRange
{
    class PrimesInGiverRange
    {
        static void Main()
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secNum = int.Parse(Console.ReadLine());

            var result = FindPrimesInRange(firstNum, secNum);
            Console.WriteLine(string.Join(", ", result));
        }

        static List<int> FindPrimesInRange(int startNumber, int endNumber)
        {
            List<int> primeNumbers = new List<int>();
            for (int i = startNumber; i <= endNumber; i++)
            {
                if (i < 2)
                {
                    continue;
                }
                for (int k = 2; k <= i; k++)
                {
                    if (i % k == 0 && k != i)
                    {
                        break;
                    }
                    else if (k == i)
                    {
                        primeNumbers.Add(i);
                    }
                }
            }
            return primeNumbers;
        }
    }
}
