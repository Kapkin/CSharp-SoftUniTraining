using System;

namespace _14.IntegerToHexAndBinary
{
    class IntegerToHexAndBinary
    {
        static void Main()
        {
            int currentNum = int.Parse(Console.ReadLine());
            Console.WriteLine("{0:X}", currentNum);
            string binary = Convert.ToString(currentNum, 2);
            Console.WriteLine(binary);
        }
    }
}
