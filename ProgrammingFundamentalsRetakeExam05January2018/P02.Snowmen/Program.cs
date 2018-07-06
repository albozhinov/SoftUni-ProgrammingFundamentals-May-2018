using System;
using System.Collections.Generic;
using System.Linq;

namespace P02.Snowmen
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputline = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            while (inputline.Count > 1)
            {
                
                for (int i = 0; i < inputline.Count; i++)
                {
                    if (inputline.Where(x => x != -1).Count() == 1)
                    {
                        break;
                    }
                    if (inputline[i] == -1)
                    {
                        continue;
                    }
                    
                    var attacker = i;
                    var target = inputline[i] % inputline.Count;
                    var diff = Math.Abs(attacker - target);

                    if (attacker == target)
                    {
                        inputline[attacker] = -1;
                        Console.WriteLine($"{attacker} performed harakiri");                        
                    }
                    else if (diff % 2 == 0)
                    {
                        Console.WriteLine($"{attacker} x {target} -> {attacker} wins");
                        inputline[target] = -1;
                    }
                    else if (diff % 2 == 1)
                    {
                        Console.WriteLine($"{attacker} x {target} -> {target} wins");
                        inputline[attacker] = -1;
                    }
                }
                inputline = inputline.Where(y => y != -1).ToList();
            }
            

        }
    }
}
