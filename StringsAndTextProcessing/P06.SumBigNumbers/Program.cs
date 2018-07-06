using System;

namespace P06.SumBigNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string num1 = Console.ReadLine().TrimStart(new char[] { '0' });
            string num2 = Console.ReadLine().TrimStart(new char[] { '0' });
            string biggestNum = num1;
            string smallerNum = num2;
            if (num1.Length < num2.Length)
            {
                biggestNum = num2;
                smallerNum = num1;
            }

            int minLen = Math.Min(num1.Length, num2.Length);
            int maxLen = Math.Max(num1.Length, num2.Length);
            int diffLen = Math.Abs(minLen - maxLen);

            string calcNum = "";
            int sum;
            int restDigit = 0;

            for (int i = minLen - 1; i >= 0; i--)
            {
                sum = int.Parse(smallerNum[i].ToString()) + int.Parse(biggestNum[i + diffLen].ToString()) + restDigit;
                restDigit = 0;

                if (sum >= 10)
                {
                    int digit = sum % 10;
                    restDigit = sum / 10;
                    calcNum = digit + calcNum;
                }
                else
                {
                    calcNum = sum + calcNum;
                }
                if (i == 0 && restDigit != 0 && diffLen == 0)
                {
                    calcNum = restDigit + calcNum;
                }
            }

            for (int i = maxLen - minLen - 1; i >= 0; i--)
            {
                sum = restDigit + int.Parse(biggestNum[i].ToString());
                restDigit = 0;

                if (sum >= 10)
                {
                    int digit = sum % 10;
                    restDigit = sum / 10;
                    calcNum = digit + calcNum;
                }
                else
                {
                    calcNum = sum + calcNum;
                }
                if (i == 0 && restDigit != 0)
                {
                    calcNum = restDigit + calcNum;
                }
            }
            Console.WriteLine(calcNum);
        }
    }
}
