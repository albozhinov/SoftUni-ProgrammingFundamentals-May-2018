using System;
using System.Text.RegularExpressions;

namespace P01.ExtractEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"(^|(?<=\s))([a-z0-9]+)([_\.-]?[a-z0-9])*@([a-z0-9])+([-.][a-z0-9]+)*\.([a-z0-9]+)([\.-][a-z0-9]+)*";


            MatchCollection myMatches = Regex.Matches(input, pattern);

            foreach (Match m in myMatches)
            {
                Console.WriteLine(m.Value);
            }
        }
    }
}
