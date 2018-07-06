using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace P03.Snowflake
{
    class Program
    {
        static void Main(string[] args)
        {
            var surface = Console.ReadLine();
            var mantle = Console.ReadLine();
            var core = Console.ReadLine();
            var secMantle = Console.ReadLine();
            var secSurface = Console.ReadLine();

            string surfacePattern = @"^[^a-zA-Z0-9]+$";
            Regex surfaceReg = new Regex(surfacePattern);

            string mantlePattern = @"^[0-9_]+$";
            Regex mantleReg = new Regex(mantlePattern);

            string corePattern = @"^[^a-zA-Z0-9\s]+[0-9_]+([a-zA-Z]+)[0-9_]+[^a-zA-z0-9\s]+$";
            Regex regex = new Regex(corePattern);

            if (!surfaceReg.IsMatch(surface) || !surfaceReg.IsMatch(secSurface) || !mantleReg.IsMatch(mantle) || !mantleReg.IsMatch(secMantle) || !regex.IsMatch(core))
            {
                Console.WriteLine("Invalid");
                return;
            }
            else
            {
                Console.WriteLine("Valid");
                var coreMatches = regex.Match(core);
                Console.WriteLine(coreMatches.Groups[1].Length);
            }           
        }
    }
}
