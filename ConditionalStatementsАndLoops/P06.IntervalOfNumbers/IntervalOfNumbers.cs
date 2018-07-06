using System;

namespace P06.IntervalOfNumbers
{
    class IntervalOfNumbers
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secNum = int.Parse(Console.ReadLine());

            var startNum = 0;
            var endNum = 0;
            if (firstNum > secNum)
            {
                startNum = secNum;
                endNum = firstNum;
            }
            else
            {
                startNum = firstNum;
                endNum = secNum;
            }

            for (int i = startNum; i <= endNum; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
