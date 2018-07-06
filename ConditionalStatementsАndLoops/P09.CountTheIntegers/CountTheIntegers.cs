using System;

namespace P09.CountTheIntegers
{
    class CountTheIntegers
    {
        static void Main(string[] args)
        {
            int number;
            
            int counter = 0;

            while (true)
            {
                var inputLine = int.TryParse(Console.ReadLine(), out number);
                if (!inputLine)
                {
                    break;
                }
                counter++;
            }
            Console.WriteLine(counter);
        }
    }
}
