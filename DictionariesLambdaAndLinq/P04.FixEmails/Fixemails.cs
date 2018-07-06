using System;
using System.Collections.Generic;
using System.Linq;

namespace P04.FixEmails
{
    class Fixemails
    {
        static void Main(string[] args)
        {
            string inputName = Console.ReadLine();
            Dictionary<string, string> emailsBook = new Dictionary<string, string>();
            

            while (inputName != "stop")
            {
                string inputEmail = Console.ReadLine();               

                if (!emailsBook.ContainsKey(inputName))
                {
                    emailsBook.Add(inputName, inputEmail);
                }                 

                inputName = Console.ReadLine();
            }
            foreach (var kvp in emailsBook.Where(x => !x.Value.EndsWith(".us") && !x.Value.EndsWith(".uk")))
            {
                Console.WriteLine(kvp.Key + " -> " + kvp.Value);
            }
        }
    }
}
