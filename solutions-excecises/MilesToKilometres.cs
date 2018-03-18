using System;

namespace MilesToKilometres
{
    class Program
    {
        static void Main(string[] args)
        {
            //We receive miles from the Console
            double miles = Double.Parse(Console.ReadLine());
            //We convert them to kilometers
            double convertMilesToKilometres = miles * 1.60934;
            //Print result
            Console.WriteLine($"{convertMilesToKilometres:f2}");
        }
    }
}
