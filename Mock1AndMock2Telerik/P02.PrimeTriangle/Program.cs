using System;

namespace P02.PrimeTriangle
{
    class Program
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine(1);
            bool[] isPrime = new bool[N + 1];
            isPrime[1] = true;
            for (int i = 2; i <= N; i++)
            {
                for (int k = 2; k <= i; k++)
                {
                    if (i % k == 0 && k == i)
                    {
                        isPrime[i] = true;
                        for (int j = 1; j <= i; j++)
                        {
                            if (isPrime[j])
                            {
                                Console.Write(1);
                            }
                            else
                            {
                                Console.Write(0);
                            }                                                       
                        }
                        Console.WriteLine();
                    }
                    else if (i % k == 0)
                    {
                        isPrime[i] = false;
                        break;
                    }
                }
            }
        }
    }
}
