using System;

namespace P07.ExchangeVariableValues
{
    class ExchangeVariableValues
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;

            Console.WriteLine($"Before:\na = {a}\nb = {b}");
            int c = a;
            a = b;
            b = c;
            Console.WriteLine($"After:\na = {a}\nb = {b}");
        }
    }
}
