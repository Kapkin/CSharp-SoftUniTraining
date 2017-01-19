using System;

namespace _12.RectangleProperties
{
    class RectangleProperties
    {
        static void Main()
        {
            double width = double.Parse(Console.ReadLine());
            double height =double.Parse(Console.ReadLine());

            double permiter = 2 * width + 2 * height;
            double area = width * height;
            double diagonale = Math.Sqrt(width * width + height * height);

            Console.WriteLine(permiter);
            Console.WriteLine(area);
            Console.WriteLine(diagonale);
        }
    }
}
