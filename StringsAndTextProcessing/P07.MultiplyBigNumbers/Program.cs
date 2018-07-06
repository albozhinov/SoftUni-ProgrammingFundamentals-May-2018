using System;
using System.Linq;
using System.Text;

namespace P07.MultiplyBigNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var num1 = Console.ReadLine();
            int num2 = int.Parse(Console.ReadLine());

            if (num2 == 0)
            {
                Console.WriteLine("0");
                Environment.Exit(0);
            }


            StringBuilder sb = new StringBuilder();
            int multiplyer;
            int remainder = 0;


            for (int i = num1.Length - 1; i >= 0; i--)
            {
                multiplyer = (num1[i] - '0') * num2 + remainder;

                if (multiplyer > 9)
                {
                    remainder = multiplyer / 10;
                    multiplyer %= 10;
                    sb.Append(multiplyer);

                }
                else
                {
                    remainder = 0;
                    sb.Append(multiplyer);
                }
                if (i == 0 && remainder != 0)
                {
                    sb.Append(remainder);
                }
            }
            Console.WriteLine(sb.ToString().TrimEnd('0').ToCharArray().Reverse().ToArray());
        }
    }
}
