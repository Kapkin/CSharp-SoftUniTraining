using System;

namespace _05.CalculateTriangleArea
{
    class CalculateTriangleArea
    {
        static void Main()
        {
            double baseSide = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double area = TriangleArea(baseSide,height);
            Console.WriteLine(area);
        }

        static double TriangleArea(double baseSide,double height)
        {
            return baseSide * height / 2;
        }
    }
}
