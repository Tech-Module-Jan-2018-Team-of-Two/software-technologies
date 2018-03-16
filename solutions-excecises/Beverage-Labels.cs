using System;

namespace Beverage_Labels
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int volume = int.Parse(Console.ReadLine());
            int energyContent = int.Parse(Console.ReadLine());
            int sugarContent = int.Parse(Console.ReadLine());

            double calories = (volume / 100.0) * energyContent;
            double weight = (volume / 100.0) * sugarContent;

            Console.WriteLine($"{volume}ml {name}:");
            Console.WriteLine($"{calories}kcal, {weight}g sugars");
        }
    }
}
