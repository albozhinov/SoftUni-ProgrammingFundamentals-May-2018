using System;

namespace P13.GameOfNumbers
{
    class GameOfNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());

            int findNum = 0;
            int firstDigit = 0;
            int secDigit = 0;
            int counter = 0;
            for (int i = n; i <= m; i++)
            {
                for (int k = n; k <= m; k++)
                {
                    findNum = i + k;
                    if (findNum == magicNum)
                    {
                        firstDigit = i;
                        secDigit = k;
                    }
                    counter++;
                }
            }
            if (firstDigit == 0)
            {
                Console.WriteLine($"{counter} combinations - neither equals {magicNum}");
            }
            else
            {
                Console.WriteLine($"Number found! {firstDigit} + {secDigit} = {magicNum}");
            }
        }
    }
}
