using System;

namespace P12.TestNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int maxNum = int.Parse(Console.ReadLine());

            int sum = 0;
            int counter = 0;
            for (int i = n; i > 0; i--)
            {
                if (sum >= maxNum)
                {
                    break;
                }
                for (int j = 1; j <= m; j++)
                {
                    if (sum >= maxNum)
                    {
                        break;
                    }
                    sum += (i * j) * 3;
                    counter++;
                }
            }

            if (sum > maxNum || sum == maxNum)
            {
                Console.WriteLine($"{counter} combinations");
                Console.WriteLine($"Sum: {sum} >= {maxNum}");
            }
            else
            {
                Console.WriteLine($"{counter} combinations");
                Console.WriteLine($"Sum: {sum}");
            }
        }
    }
}
