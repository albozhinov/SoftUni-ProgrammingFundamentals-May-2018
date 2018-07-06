using System;

namespace P01._1Game
{
    class Program
    {
        static void Main()
        {
            string n = Console.ReadLine();
            int firstDigit = int.Parse(n[0].ToString());
            int sectDigit = int.Parse(n[1].ToString());
            int thirdDigit = int.Parse(n[2].ToString());
            int currentNum = 0;
            int biggestNum = int.MinValue;

            for (int i = 0; i < 4; i++)
            {
                if (i == 0)
                {
                    currentNum = firstDigit * sectDigit * thirdDigit;
                }
                else if (i == 1)
                {
                    currentNum = firstDigit + sectDigit + thirdDigit;
                }
                else if (i == 2)
                {
                    currentNum = firstDigit + sectDigit * thirdDigit;
                }
                else if (i == 3)
                {
                    currentNum = firstDigit * sectDigit + thirdDigit;
                }                
                
                if (currentNum > biggestNum)
                {
                    biggestNum = currentNum;
                }
            }
            Console.WriteLine(biggestNum);
        }
    }
}
