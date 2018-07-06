using System;

namespace P05.FibonacciNumbers
{
    class FIbonacciNumbers
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            Fibonacci(number);
        }

         static void Fibonacci(int number)
        {
            var fib = 0;
            var num1 = 0;
            var num2 = 1;
            var index = 0;

            do
            {
                fib = num1 + num2;
                num1 = num2;
                num2 = fib;
                index++;
            } while (index < number);
            
            Console.WriteLine(fib);
        }
    }
}
