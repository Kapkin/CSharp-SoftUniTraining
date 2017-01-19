using System;

namespace _07.GreeterOfTwoValues
{
    class GreeterOfTwoValues
    {
        static void Main()
        {
            string input = Console.ReadLine();
            
            if (input == "char")
            {
                char firstValue = Console.ReadLine()[0];
                char secondValue = Console.ReadLine()[0];
                char result = GetMaxValue(firstValue, secondValue);
                Console.WriteLine(result);
            }
            else if (input == "int")
            {
                int firstValue = int.Parse(Console.ReadLine());
                int secondValue = int.Parse(Console.ReadLine());
                int result = GetMaxValue(firstValue, secondValue);
                Console.WriteLine(result);
            }
            else if (input == "string")
            {
                string firstValue = Console.ReadLine();
                string secondValue = Console.ReadLine();
                string result = GetMaxValue(firstValue, secondValue);
                Console.WriteLine(result);
            }
        }

        private static char GetMaxValue(char firstValue, char secondValue)
        {
            if (firstValue.CompareTo(secondValue) < 0)
            {
                return secondValue;
            }
            return firstValue;
        }
        private static int GetMaxValue(int firstValue, int secondValue)
        {
            int maxValue = Math.Max(firstValue, secondValue);
            return maxValue;
        }
        private static string GetMaxValue(string firstValue, string secondValue)
        {
            if (firstValue.CompareTo(secondValue) < 0)
            {
                return secondValue;
            }
            return firstValue;
        }
    }
}
