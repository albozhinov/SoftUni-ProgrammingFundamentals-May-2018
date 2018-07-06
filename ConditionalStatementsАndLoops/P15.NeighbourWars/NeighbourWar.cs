using System;

namespace P15.NeighbourWars
{
    class NeighbourWar
    {
        static void Main(string[] args)
        {
            var peshosDamage = int.Parse(Console.ReadLine());
            var goshosDamage = int.Parse(Console.ReadLine());

            var peshosHealth = 100;
            var goshosHealth = 100;

            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 != 0)
                {
                    goshosHealth -= peshosDamage;
                    if (goshosHealth > 0)
                    {
                        Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {goshosHealth} health.");
                    }                    
                }
                else
                {
                    peshosHealth -= goshosDamage;
                    if (peshosHealth > 0)
                    {
                        Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {peshosHealth} health.");
                    }
                    
                }
                if (goshosHealth <= 0)
                {
                    Console.WriteLine($"Pesho won in {i}th round.");
                    break;
                }
                else if (peshosHealth <= 0)
                {
                    Console.WriteLine($"Gosho won in {i}th round.");
                    break;
                }
                if (i % 3 == 0)
                {
                    goshosHealth += 10;
                    peshosHealth += 10;
                }
               
            }
        }
    }
}
