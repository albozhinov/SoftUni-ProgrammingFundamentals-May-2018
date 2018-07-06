using System;

namespace P04.SieveOfEratosthenes
{
    class SieveOfEratosthenes
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            bool[] primes = new bool[n + 1];

            primes[0] = false;
            primes[1] = false;
            for (int i = 0; i < primes.Length; i++)
            {
                primes[i] = true;
            }

            for (int i = 2; i <= n; i++)
            {
                if (primes[i])
                {
                    for (int k = i; k <= n; k += i)
                    {
                        if (k % i == 0 && k != i && primes[k])
                        {
                            primes[k] = false;
                        }                       
                    }
                }               
            }
            for (int i = 2; i < primes.Length; i++)
            {
                if (primes[i])
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
