using System;

namespace P01.DebitCardNumber
{
    class DebitCardNumber
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            int fourthNumber = int.Parse(Console.ReadLine());

            Console.WriteLine($"{firstNumber:D4} {secNumber:D4} {thirdNumber:D4} {fourthNumber:D4}");
        }
    }
}
