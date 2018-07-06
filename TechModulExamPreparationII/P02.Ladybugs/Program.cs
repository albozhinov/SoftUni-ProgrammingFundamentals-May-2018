using System;
using System.Linq;
using System.Collections.Generic;


namespace P02.Ladybugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            var ladybugIndexes = Console.ReadLine()
                                .Split(new char[] { ' ' },
                                StringSplitOptions.RemoveEmptyEntries)
                                .Select(int.Parse)
                                .Where(x => x >= 0 && x < size)
                                .ToList();

            int[] field = new int[size];

            foreach (var item in ladybugIndexes)
            {
                field[item] = 1;
            }            

            while (true)
            {
                var input = Console.ReadLine().ToLower();
                var commands = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (input == "end")
                {
                    break;
                }
                var direction = commands[1];
                var ladybugIndex = int.Parse(commands[0]);
                var flyLenght = int.Parse(commands[2]);

                if (direction == "left")
                {
                    flyLenght *= -1;
                }

                int currLadybugPosition = ladybugIndex + flyLenght;

                if (ladybugIndex < 0 || ladybugIndex >= size)
                {
                    continue;
                }
                else if (field[ladybugIndex] == 0)
                {
                    continue;
                }

                field[ladybugIndex] = 0;

                while (true)
                {
                    if (currLadybugPosition < 0 || currLadybugPosition >= size)
                    {
                        break;
                    }

                    if (field[currLadybugPosition] == 1)
                    {
                        currLadybugPosition += flyLenght;
                        continue;
                    }
                    
                    field[currLadybugPosition] = 1;
                    break;
                }
            }
            Console.WriteLine(string.Join(" ", field));
        }
    }
}
