using System;

namespace P14.MagicLetter
{
    class MagicLetter
    {
        static void Main(string[] args)
        {
            var firstLetter = char.Parse(Console.ReadLine());
            var secLetter = char.Parse(Console.ReadLine());
            var thirdLetter = char.Parse(Console.ReadLine());
             
            for (var i = firstLetter; i <= secLetter; i++)
            {
                for (var j = firstLetter; j <= secLetter; j++)
                {
                    for (var k = firstLetter; k <= secLetter; k++)
                    {

                        if (i != thirdLetter && j != thirdLetter && k != thirdLetter)
                        {
                            Console.Write($"{i}{j}{k} ");
                        }
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
