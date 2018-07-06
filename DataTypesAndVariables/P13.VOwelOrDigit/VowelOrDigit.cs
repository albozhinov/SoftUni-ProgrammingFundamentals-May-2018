using System;

namespace P13.VOwelOrDigit
{
    class VowelOrDigit
    {
        static void Main(string[] args)
        {
            var inputLine = Console.ReadLine();

            if (inputLine == "a" || inputLine == "o" || inputLine == "u" || inputLine == "e" || inputLine == "i")
            {
                Console.WriteLine("vowel");
                Environment.Exit(0);
            }
            else if (inputLine == "1" || inputLine == "2" || inputLine == "3" || inputLine == "4" || inputLine == "5" || inputLine == "6" || inputLine == "7" || inputLine == "8" || inputLine == "0" || inputLine == "9")
            {
                Console.WriteLine("digit");
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("other");
            }
        }
    }
}
