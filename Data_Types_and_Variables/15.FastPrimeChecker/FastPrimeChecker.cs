using System;

namespace _15.FastPrimeChecker
{
    class FastPrimeChecker
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            for (int currentNum = 2; currentNum <= number; currentNum++)
            {
                bool isPrime = true;
                for (int primeChecker = 2; primeChecker <= Math.Sqrt(currentNum); primeChecker++)
                {
                    if (currentNum % primeChecker == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                Console.WriteLine($"{currentNum} -> {isPrime}");
            }

        }
    }
}
