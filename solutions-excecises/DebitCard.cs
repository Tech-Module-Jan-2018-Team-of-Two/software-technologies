using System;

namespace CSharpProblemsLesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            //We recieve from the Console numbers for the credit card
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int num4 = int.Parse(Console.ReadLine());
            //Print result
            Console.Write($"{num1:d4} {num2:d4} {num3:d4} {num4:d4}");

        }
    }
}
