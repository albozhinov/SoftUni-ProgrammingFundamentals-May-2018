using System;

namespace P01.ChooseADrink
{
    class ChooseADrink
    {
        static void Main()
        {
            var profession = Console.ReadLine();
            //var quantity = int.Parse(Console.ReadLine());
            
            var drink = "Tea";
            //var price = 1.20;
            switch (profession)
            {
                case "Athlete":
                    drink = "Water";
                    //price = 0.70;
                    break;
                case "Businessman":
                case "Businesswoman":
                    drink = "Coffee";
                    //price = 1.0;
                    break;
                case "SoftUni Student":
                    drink = "Beer";
                    //price = 1.70;
                    break;                                    
            }
            //var result = quantity * price;
            //Console.WriteLine($"The {profession} has to pay {result:f2}.");
            Console.WriteLine(drink);
        }
    }
}
