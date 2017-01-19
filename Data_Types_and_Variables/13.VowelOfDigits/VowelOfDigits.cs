using System;

namespace _13.VowelOfDigits
{
    class VowelOfDigits
    {
        static void Main()
        {
            char givenDigit = char.Parse(Console.ReadLine());

            if (givenDigit == 'a' || givenDigit == 'e' ||
                givenDigit == 'i' || givenDigit == 'o' ||
                givenDigit == 'u' || givenDigit == 'y')
            {
                Console.WriteLine("vowel");
            }
            else
            {
                Console.WriteLine(givenDigit >= 48 && givenDigit <= 57 ? "digit" : "other");
            }
        }
    }
}
