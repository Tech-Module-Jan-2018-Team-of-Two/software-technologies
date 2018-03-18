using System;

namespace RectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            //We receive the width and the height of a rectangle
            float width = float.Parse(Console.ReadLine());
            float height = float.Parse(Console.ReadLine());
            //Calculate the area
            float result = width * height;
            //Print the result
            Console.WriteLine($"{result:f2}");
        }
    }
}
