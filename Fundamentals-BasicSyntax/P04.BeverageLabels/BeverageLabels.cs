using System;

namespace P04.BeverageLabels
{
    class BeverageLabels
    {
        static void Main(string[] args)
        {
            var productName = Console.ReadLine();
            var volumeOfProduct = int.Parse(Console.ReadLine());
            var energy = double.Parse(Console.ReadLine());
            var sugar = double.Parse(Console.ReadLine());

            var fullEnergyContent = (energy / 100) * volumeOfProduct;
            var fullSugarContent = (sugar / 100) * volumeOfProduct;

            Console.WriteLine($"{volumeOfProduct}ml {productName}:\n{fullEnergyContent}kcal, {fullSugarContent}g sugars");
        }
    }
}
