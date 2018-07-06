using System;

namespace P04.VaruableInHehFormat
{
    class VariableIntHexFormat
    {
        static void Main(string[] args)
        {
            var numInHex = Console.ReadLine();

            Console.WriteLine(Convert.ToInt32(numInHex, 16));
        }
    }
}
