using System;

namespace P15.FastPrimeChecjer
{
    class FastPrimeChecker
    {
        static void Main(string[] args)
        {
            int inputLine = int.Parse(Console.ReadLine());
            for (int i = 2; i <= inputLine; i++)
            {
                bool isPrime = true;
                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                Console.WriteLine($"{i} -> {isPrime}");
            }
        }
    }
}
