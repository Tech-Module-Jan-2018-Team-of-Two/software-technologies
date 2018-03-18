using System;

namespace RectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            float width = float.Parse(Console.ReadLine());
            float height = float.Parse(Console.ReadLine());
            float result = width * height;
            Console.WriteLine($"{result:f2}");
        }
    }
}
