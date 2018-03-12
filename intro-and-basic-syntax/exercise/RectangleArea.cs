using System;

namespace p02._RectangleArea
{
    class RectangleArea
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine($"{a*b:F2}");
        }
    }
}
