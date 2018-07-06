using System;
using System.Linq;
using System.Collections.Generic;

namespace P04.SnowWhite
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Dwarf> myDwarfs = new List<Dwarf>();
            while (true)
            {
                var inputLine = Console.ReadLine();
                if (inputLine == "Once upon a time")
                {
                    break;
                }
                var dwarfInfo = inputLine
                                .Split(new char[] { ' ', '<', ':', '>' },
                                StringSplitOptions.RemoveEmptyEntries)
                                .ToList();
                var name = dwarfInfo[0];
                var hat = dwarfInfo[1];
                var physics = int.Parse(dwarfInfo[2]);

                if (myDwarfs.Any(x => x.name == name))
                {
                    Dwarf currDwarf = myDwarfs.First(x => x.name == name);
                    if (currDwarf.hatcolor == hat)
                    {
                        currDwarf.physics = Math.Max(physics, currDwarf.physics);
                    }
                    else
                    {
                        Dwarf newDwarf = new Dwarf(name, hat, physics);
                        myDwarfs.Add(newDwarf);
                    }
                }
                else
                {
                    Dwarf currDwarf = new Dwarf(name, hat, physics);
                    myDwarfs.Add(currDwarf);
                }
            }
            foreach (var dwarf in myDwarfs.OrderByDescending(x => x.physics))
            {
                Console.WriteLine($"({dwarf.hatcolor}) {dwarf.name} <-> {dwarf.physics}");
            }
        }

        class Dwarf
        {
            public string name;
            public string hatcolor;
            public int physics;

            public Dwarf(string name, string hatcolor, int physics)
            {
                this.name = name;
                this.hatcolor = hatcolor;
                this.physics = physics;
            }
        }
    }
}
