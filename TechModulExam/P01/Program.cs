using System;

namespace P01
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstEmployee = int.Parse(Console.ReadLine());
            int secEmployee = int.Parse(Console.ReadLine());
            int thirdEmployee = int.Parse(Console.ReadLine());

            int students = int.Parse(Console.ReadLine());

            int counter = 1;

            for (int i = 1; i < int.MaxValue; i++)
            {
                students -= firstEmployee + secEmployee + thirdEmployee;

                if (students > 0)
                {
                    counter++;
                    if (i % 3 == 0 && students > 0)
                    {
                        counter++;
                    }
                }
                else
                {
                    break;
                }
            }           
            Console.WriteLine($"Time needed: {counter}h.");
        }
    }
}
