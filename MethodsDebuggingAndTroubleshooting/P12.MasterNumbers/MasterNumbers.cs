using System;

namespace P12.MasterNumbers
{
    class MasterNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {                
                if (IsPalindrome(i) && IfSumOfDigitDivideSeven(i) && ContainsEvenDigits(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        static bool IsPalindrome(int number)
        {
            string num = number.ToString();
            int counter = 0;

            for (int i = num.Length - 1; i >= 0; i--)
            {
                if (num[i] != num[counter])
                {
                    return false;
                }
                counter++;
            }
            return true;            
        }
        static bool IfSumOfDigitDivideSeven(int number)
        {
            var sum = 0;
            string text = number.ToString();
            for (int i = 0; i < text.Length; i++)
            {
                sum += number % 10;
                number /= 10;
            }
            if (sum % 7 == 0)
            {
                return true;
            }
            return false;
        }
        static bool ContainsEvenDigits(int number)
        {
            while (number != 0)
            {
                var digit = number % 10;
                if (digit % 2 == 0)
                {
                    return true;
                }
                number /= 10;                
            }
            return false;            
        }
    }
}
