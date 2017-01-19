using System;

namespace _03.PrintingTriangle
{
    class PrintingTriangle
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            PrintTop(n);
            PrintBottom(n);
        }
                
        private static void PrintTop(int n)
        {
            for (int topRows = 1; topRows <= n; topRows++)
            {
                PrintLine(1, topRows);
            }
        }

        private static void PrintBottom(int n)
        {
            for (int bottomRows = n - 1; bottomRows > 0; bottomRows--)
            {
                PrintLine(1, bottomRows);
            }
        }

        static void PrintLine(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }
    }
}
