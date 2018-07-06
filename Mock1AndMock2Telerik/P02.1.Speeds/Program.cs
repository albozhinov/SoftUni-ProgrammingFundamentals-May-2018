using System;

namespace P02._1.Speeds
{
    class Program
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int currLenght = 0;
            int maxLenght = 0;
            int exSpeed = 0;
            int maxSpeed = 0;
            int currenSpeed = 0;
            int current = 0;

            for (int i = 0; i < N; i++)
            {
                current = int.Parse(Console.ReadLine());
                if (i == 0)
                {
                    exSpeed = current;
                }
                if (current > exSpeed)
                {
                    currenSpeed += current;
                    currLenght++;
                }
                else
                {
                    exSpeed = current;
                    currLenght = 1;
                    currenSpeed = current;
                }
                if (currLenght > maxLenght)
                {
                    maxLenght = currLenght;
                    maxSpeed = currenSpeed;
                }
                else if ((currLenght == maxLenght) && (currenSpeed > maxSpeed))
                {
                    maxSpeed = currenSpeed;
                }                
            }
            Console.WriteLine(maxSpeed);
        }
    }
}
