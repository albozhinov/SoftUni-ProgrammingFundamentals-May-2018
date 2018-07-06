using System;

namespace P05.BooleanVariable
{
    class BooleanVariable
    {
        static void Main(string[] args)
        {
            var inputLine = Console.ReadLine();

            if (Convert.ToBoolean(inputLine))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
