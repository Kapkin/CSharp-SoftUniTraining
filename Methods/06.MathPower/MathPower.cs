using System;

namespace _06.MathPower
{
    class MathPower
    {
        static void Main()
        {
            int number =int.Parse(Console.ReadLine());
            int power =int.Parse(Console.ReadLine());
            Console.WriteLine(MathValue(number, power));
        }
        static double MathValue(int number,int power)
        {
            double value = 1;
            for (int i  = 1; i <=power; i ++)
			{
                value *= number;
			}
            return value;
        }
    }
}
