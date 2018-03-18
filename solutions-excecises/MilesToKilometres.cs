using System;

namespace MilesToKilometres
{
    class Program
    {
        static void Main(string[] args)
        {
            double miles = Double.Parse(Console.ReadLine());
            double convertMilesToKilometres = miles * 1.60934;
            Console.WriteLine($"{convertMilesToKilometres:f2}");
        }
    }
}
