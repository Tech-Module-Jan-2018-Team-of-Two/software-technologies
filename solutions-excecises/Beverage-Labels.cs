using System;

namespace Beverage_Labels
{
    class Program
    {
        static void Main(string[] args)
        {
			// We receive a name from the console
            string name = Console.ReadLine();
			// We are given the volume
            int volume = int.Parse(Console.ReadLine());
			
			// There is a percentage of energy and sugar content received from the console
            int energyContent = int.Parse(Console.ReadLine());
            int sugarContent = int.Parse(Console.ReadLine());
			// In order to obtain the calories we divide the volume by 100 and then multiply the energyContent
            double calories = (volume / 100.0) * energyContent;
			// By obtaining the weight, we divide the volume by 100 and then multiply the sugarContent
            double weight = (volume / 100.0) * sugarContent;
			// Printing the result
            Console.WriteLine($"{volume}ml {name}:");
            Console.WriteLine($"{calories}kcal, {weight}g sugars");
        }
    }
}
