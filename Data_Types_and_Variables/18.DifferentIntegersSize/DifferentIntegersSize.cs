using System;

namespace _18.DifferentIntegersSize
{
    class DifferentIntegersSize
    {
        static void Main()
        {
            string input = Console.ReadLine();

            try
            {
                long num = long.Parse(input);
                Console.WriteLine($"{num} can fit in:");
                if (num >= byte.MinValue && num <= byte.MaxValue) Console.WriteLine("* byte");
                if (num >= sbyte.MinValue && num <= sbyte.MaxValue) Console.WriteLine("* sbyte");
                if (num >= short.MinValue && num <= short.MaxValue) Console.WriteLine("* short");
                if (num >= ushort.MinValue && num <= ushort.MaxValue) Console.WriteLine("* ushort");
                if (num >= int.MinValue && num <= int.MaxValue) Console.WriteLine("* int");
                if (num >= uint.MinValue && num <= uint.MaxValue) Console.WriteLine("* uint");
                if (num >= long.MinValue && num <= long.MaxValue) Console.WriteLine("* long");
            }
            catch 
            {

                Console.WriteLine($"{input} can't fit in any type");
            }
        }
    }
}
