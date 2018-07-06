using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace P02.ExtracSentencesNyKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            var text = Console.ReadLine().Split(new char[] { '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            string pattern = $@"\b{word}\b";

            foreach (var sentences in text)
            {
                if (Regex.IsMatch(sentences, pattern))
                {
                    Console.WriteLine(sentences.Trim());
                }
            }
        }
    }
}
