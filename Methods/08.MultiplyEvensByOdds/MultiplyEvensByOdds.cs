using System;

namespace _08.MultiplyEvensByOdds
{
    class MultiplyEvensByOdds
    {
        static void Main()
        {
            int number = Math.Abs(int.Parse(Console.ReadLine()));
            PrintMultipleOfEvensAndOdds(number);
            

        }

        private static int GetSumOfEvenDigits(int number)
        {
            int sumOfEvenDigits = 0;
            int n = number;
            while (n > 0)
            {
                int lastDigit = n % 10;
                if (lastDigit % 2 == 0)
                {
                    sumOfEvenDigits += lastDigit;
                }
                n /= 10;
            }
            return sumOfEvenDigits;
        }
        private static int GetSumOfOddDigits(int number)
        {
            int sumOfOddDigits = 0;
            int n = number;
            while (n > 0)
            {
                int lastDigit = n % 10;
                if (lastDigit % 2 != 0)
                {
                    sumOfOddDigits += lastDigit;
                }
                n /= 10;
            }
            return sumOfOddDigits;
        }
        private static void PrintMultipleOfEvensAndOdds(int number)
        {
            int evenDigitsSum = GetSumOfEvenDigits(number);
            int oddDigitsSum = GetSumOfOddDigits(number);
            int evenByOddMultiply = evenDigitsSum * oddDigitsSum;
            Console.WriteLine(evenByOddMultiply);
        }
    }
}
