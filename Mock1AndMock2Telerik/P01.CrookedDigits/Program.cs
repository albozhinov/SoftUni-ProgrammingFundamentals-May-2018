using System;
using System.Linq;

namespace P01.CrookedDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputLine = Console.ReadLine().ToCharArray();
            var number = 0;

            for (int i = 0; i < inputLine.Length; i++)
            {
                if (inputLine[i] == '.' || inputLine[i] == '-')
                {
                    continue;
                }
                number += inputLine[i] - '0';
            }
            while (number > 9)
            {
                var n = 0;
                
                while (number > 0)
                {
                    n += number % 10;
                    number /= 10;
                }
                number = n;
            }
            Console.WriteLine(number);
        }
    }
}
