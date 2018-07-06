using System;


namespace P03.BalancedNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputLine = Console.ReadLine();
            string lastInput = inputLine;
            int firstNum = inputLine[0] - '0' + inputLine[2] - '0';
            int secNum = inputLine[1] - '0';
            int sumOfAll = 0;

            while (firstNum == secNum)
            {
                sumOfAll += int.Parse(inputLine);
                inputLine = Console.ReadLine();
                firstNum = inputLine[0] - '0' + inputLine[2] - '0';
                secNum = inputLine[1] - '0';
            }
            Console.WriteLine(sumOfAll);            
        }
    }
}
