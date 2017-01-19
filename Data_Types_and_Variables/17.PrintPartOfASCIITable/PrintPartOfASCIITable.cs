using System;

namespace _17.PrintPartOfASCIITable
{
    class PrintPartOfASCIITable
    {
        static void Main()
        {
            int firstSymbol = int.Parse(Console.ReadLine());
            int secondSymbol = int.Parse(Console.ReadLine());

            for (int currentSymbol = firstSymbol ; currentSymbol <= secondSymbol; currentSymbol++)
            {
                Console.Write($"{Convert.ToChar(currentSymbol)} ");
            }
            Console.WriteLine();
        }
    }
}
