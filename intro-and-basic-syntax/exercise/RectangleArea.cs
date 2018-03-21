using System;

namespace p02._RectangleArea
{
    class RectangleArea
    {
        static void Main(string[] args)
        {
            //In the next 2 lines we receive from the Console the height and the length of the rectangle
            double length = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            //Here we print the area of the rectangle rounding to the second decimal point
            Console.WriteLine($"{length*height:F2}");
        }
    }
}
