using System;
using System.Linq;

namespace P02
{
    class Program
    {
        static void Main(string[] args)
        {
            var lessonsAndExercises = Console.ReadLine()
                                      .Split(new char[] { ',' },
                                      StringSplitOptions.RemoveEmptyEntries)
                                      .ToList();
            for (int i = 0; i < lessonsAndExercises.Count; i++)
            {
                lessonsAndExercises[i] = lessonsAndExercises[i].Trim();
            }                
            

            while (true)
            {
                var inputLine = Console.ReadLine();

                if (inputLine == "course start")
                {
                    break;
                }
                var commands = inputLine
                               .Split(new char[] { ':' },
                               StringSplitOptions.RemoveEmptyEntries)
                               .ToList();

                if (commands[0] == "Add")
                {
                    if (!lessonsAndExercises.Contains(commands[1]))
                    {
                        lessonsAndExercises.Add(commands[1]);
                    }
                }
                else if (commands[0] == "Insert")
                {
                    
                    var index = int.Parse(commands[2]);
                    if (index < 0)
                    {
                        continue;
                    }
                    if (!lessonsAndExercises.Contains(commands[1]) && lessonsAndExercises.Count > index)
                    {
                        lessonsAndExercises.Insert(index, commands[1]);
                    }
                }
                else if (commands[0] == "Remove")
                {
                    if (lessonsAndExercises.Contains(commands[1]))
                    {
                        lessonsAndExercises.Remove(commands[1]);

                        string helper = $"{commands[1]}-Exercise";

                        if (lessonsAndExercises.Contains(helper))
                        {
                            lessonsAndExercises.Remove(helper);
                        }
                    }
                }
                else if (commands[0] == "Swap")
                {
                    if (lessonsAndExercises.Contains(commands[1]) && lessonsAndExercises.Contains(commands[2]))
                    {
                        var firstIndex = lessonsAndExercises.IndexOf(commands[1]);
                        var secIndex = lessonsAndExercises.IndexOf(commands[2]);

                        var firstSwap = lessonsAndExercises[firstIndex];
                        var secSwap = lessonsAndExercises[secIndex];

                        lessonsAndExercises.Remove(firstSwap);
                        lessonsAndExercises.Remove(secSwap);

                        if (firstIndex >= lessonsAndExercises.Count)
                        {
                            lessonsAndExercises.Add(secSwap);
                        }

                        lessonsAndExercises.Insert(firstIndex, secSwap);

                        if (secIndex >= lessonsAndExercises.Count)
                        {
                            lessonsAndExercises.Add(firstSwap);
                        }

                        lessonsAndExercises.Insert(secIndex, firstSwap);

                        if (lessonsAndExercises.Contains($"{commands[1]}-Exercise"))
                        {
                            var excersice = $"{commands[1]}-Exercise";
                            lessonsAndExercises.Remove(excersice);

                            if (secIndex + 1 <= lessonsAndExercises.Count)
                            {
                                lessonsAndExercises.Insert(secIndex + 1, excersice);
                            }
                            else
                            {
                                lessonsAndExercises.Add(excersice);
                            }                            
                        }
                        if (lessonsAndExercises.Contains($"{commands[2]}-Exercise"))
                        {
                            var excersice = $"{commands[2]}-Exercise";
                            lessonsAndExercises.Remove(excersice);

                            if (firstIndex + 1 <= lessonsAndExercises.Count)
                            {
                                lessonsAndExercises.Insert(firstIndex + 1, excersice);
                            }
                            else
                            {
                                lessonsAndExercises.Add(excersice);
                            }
                        }
                    }
                }
                else if (commands[0] == "Exercise")
                {
                    
                    if (!lessonsAndExercises.Contains(commands[1]))
                    {
                        var ex = $"{commands[1]}-Exercise";
                        lessonsAndExercises.Add(commands[1]);
                        lessonsAndExercises.Add(ex);
                    }
                    else
                    {
                        var ex = $"{commands[1]}-Exercise";
                        var exIndex = lessonsAndExercises.IndexOf(commands[1]) + 1;

                        if (exIndex <= lessonsAndExercises.Count)
                        {
                            lessonsAndExercises.Insert(exIndex, ex);
                        }
                        else
                        {
                            lessonsAndExercises.Add(ex);
                        }
                        
                    }
                }
            }
            var result = lessonsAndExercises.Distinct();
            var number = 1;
            foreach (var item in result)
            {
                Console.WriteLine($"{number}.{item}");
                number++;
            }
        }
    }
}
