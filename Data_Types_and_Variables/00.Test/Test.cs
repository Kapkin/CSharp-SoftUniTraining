using System;

namespace _00.Test
{
    class Test
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
                        
            for (int i = 1; i <= n; i++)
            {
                int currentNum = i;
                int sumOfDigits = 0;
                while (currentNum > 0)
                {
                    sumOfDigits += currentNum % 10;
                    currentNum /= 10;
                }
                bool isSpecial = (sumOfDigits == 5) || (sumOfDigits == 7) || (sumOfDigits == 11);
                Console.WriteLine($"{i} -> {isSpecial}");
            }

        }
    }
}
