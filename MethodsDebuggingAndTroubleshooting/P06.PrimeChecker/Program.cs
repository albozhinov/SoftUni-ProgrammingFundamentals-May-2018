using System;

namespace P06.PrimeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());

            Console.WriteLine(IsPrime(n));
        }

        static bool IsPrime(long number)
        {
            bool isPrime = true;

            if (number < 2)
            {
                isPrime = false;
                return isPrime;
            }
            else
            {
                for (int i = 2; i <= Math.Sqrt(number); i++)
                {
                    if (number % i == 0)
                    {
                        isPrime = false;
                        return isPrime;
                    }
                }
                return isPrime;
            }            
        }
    }
}
