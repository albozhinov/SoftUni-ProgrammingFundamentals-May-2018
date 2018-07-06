using System;

namespace P11.DifferentNumbers
{
    class DifferentNumbers
    {
        static void Main(string[] args)
        {
            int firsNumber = int.Parse(Console.ReadLine());
            int secNumber = int.Parse(Console.ReadLine());

            if ((firsNumber + 4) > secNumber)
            {
                Console.WriteLine("No");
                Environment.Exit(0);
            }

            for (int i = firsNumber; i <= secNumber - 4; i++)
            {

                for (int h = i + 1; h <= secNumber - 3; h++)
                {
                    for (int j = h + 1; j <= secNumber - 2; j++)
                    {
                        for (int k = j + 1; k <= secNumber - 1; k++)
                        {
                            for (int c = k + 1; c <= secNumber; c++)
                            {
                                if (i < h && h < j && j < k && k < c)
                                {
                                    Console.WriteLine($"{i} {h} {j} {k} {c}");
                                }                                
                            }
                        }
                    }
                }
            }
        }
    }
}
