using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace P03.CameraView
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').ToArray();
            int numberToSkip = int.Parse(numbers[0]);
            int numberToTake = int.Parse(numbers[1]);

            var text = Console.ReadLine();
            string pattern = @"\|<([\w]{" + numberToSkip + @"})([\w]{0," + numberToTake + @"})";

            MatchCollection cameraCollection = Regex.Matches(text, pattern);
            List<string> myMatches = new List<string>();


            foreach (Match item in cameraCollection)
            {
                myMatches.Add(item.Groups[2].Value);
            }

            Console.WriteLine(string.Join(", ", myMatches));
        }
    }
}
