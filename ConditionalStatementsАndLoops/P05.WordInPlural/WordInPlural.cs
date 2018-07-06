using System;

namespace P05.WordInPlural
{
    class WordInPlural
    {
        static void Main(string[] args)
        {
            var inputWord = Console.ReadLine().ToLower();

            if (inputWord.EndsWith("ch") || inputWord.EndsWith("sh") || inputWord.EndsWith("o") || inputWord.EndsWith("s") || inputWord.EndsWith("x") || inputWord.EndsWith("z"))
            {               
                inputWord += "es";
            }
            else if (inputWord.EndsWith("y"))
            {
                inputWord = inputWord.Remove(inputWord.Length - 1, 1);
                inputWord += "ies";
            }
            else
            {
                inputWord += "s";
            }
            Console.WriteLine(inputWord);
        }
    }
}
