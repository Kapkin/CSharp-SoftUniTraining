using System;

namespace _04.DrawAFilledSquare
{
    class DrawAFilledSquare
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            DashLine(2 * num);
            for (int rows = 0; rows < num-2; rows++)
            {
                MiddleRows(num - 1);

            }
            DashLine(2 * num);
        }

        private static void MiddleRows(int end)
        {
            Console.Write("-");
            for (int columns = 1; columns <= end; columns++)
            {
                Console.Write("\\/");
            }
            Console.WriteLine("-");
        }

        private static void DashLine(int num)
        {
            Console.WriteLine(new string('-', num));
        }
    }
}
