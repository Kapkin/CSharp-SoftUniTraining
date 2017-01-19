using System;

namespace _02.SignOfIntegerNumber
{
    class SignOfIntegerNumber
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            PrintSign(n);
        }
        static void PrintSign(int number)
        {
            string numberSign = "";
            if (number > 0) numberSign = "positive";
            else if (number < 0) numberSign = "negative";
            else numberSign = "zero";
            Console.WriteLine($"The number {number} is {numberSign}.");
        }
    }
}
