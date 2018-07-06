using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;

namespace P05.KeyReplacer
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern1 = @"([A-Za-z]+)([\\<\|])([\w]*)([\\<\|])([A-Za-z]+)";            
            var inputKyeWords = Console.ReadLine();

            Match myMatch = Regex.Match(inputKyeWords, pattern1);
            string startWord = myMatch.Groups[1].Value;
            string endWord = myMatch.Groups[5].Value;

            string pattern2 = $@"{startWord}(.*?){endWord}";

            var inputText = Console.ReadLine();

            MatchCollection myMatchWords = Regex.Matches(inputText, pattern2);
            string result = "";
            
            foreach (Match item in myMatchWords)
            {                
                result += item.Groups[1].Value;
            }
            if (result == "")
            {
                Console.WriteLine("Empty result");
                return;
            }
            Console.WriteLine(result);
        }
    }
}
