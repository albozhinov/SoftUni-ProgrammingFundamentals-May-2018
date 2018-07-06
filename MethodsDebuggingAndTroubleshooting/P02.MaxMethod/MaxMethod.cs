using System;

namespace P02.MaxMethod
{
    class MaxMethod
    {
        static void Main(string[] args)
        {
            var firstNum = int.Parse(Console.ReadLine());
            var secNum = int.Parse(Console.ReadLine());
            var thirdNum = int.Parse(Console.ReadLine());

            var biggestNum = GetMax(GetMax(firstNum, secNum), thirdNum);

            Console.WriteLine(biggestNum);
        }

         static int GetMax(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
    }
}
