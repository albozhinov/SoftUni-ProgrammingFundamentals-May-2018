using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace P03.NetherRealms
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputDemos = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            List<Demon> demonsBook = new List<Demon>();

            foreach (var demon in inputDemos)
            {
                var demonName = demon;
                var health = CalcHealth(demon);
                var damage = CalcDamage(demon);
                Demon currDemon = new Demon(demonName, damage, health);
                demonsBook.Add(currDemon);
            }
            foreach (var demon in demonsBook.OrderBy(n => n.name))
            {
                Console.WriteLine($"{demon.name} - {demon.health} health, {demon.damage:F2} damage");
            }

        }

        public static double CalcDamage(string demon)
        {
            string pattern = @"-?\d+\.?\d*";
            Regex regex = new Regex(pattern);
            MatchCollection myMatches = regex.Matches(demon);
            double damage = 0.0;
            foreach (Match match in myMatches)
            {                
                damage += double.Parse(match.Value);
            }            
            foreach (var symbol in demon)
            {
                if (symbol == '*')
                {
                    damage *= 2;
                }
                else if (symbol == '/')
                {
                    damage /= 2;
                }
            }
            return damage;
        }

        public static int CalcHealth(string demon)
        {
            var health = demon.Where(x => (x >= 'a' && 'z' >= x) || (x >= 'A' && x <= 'Z')).ToList();
            return health.Sum(x => x);
        }
    }
    class Demon
    {
        public string name;
        public double damage;
        public int health;

        public Demon(string name, double damage, int health)
        {
            this.name = name;
            this.damage = damage;
            this.health = health;
        } 
    }
}
