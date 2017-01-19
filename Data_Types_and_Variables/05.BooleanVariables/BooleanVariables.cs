using System;

namespace _05.BooleanVariables
{
    class BooleanVariables
    {
        static void Main()
        {
            string booleanInput = Console.ReadLine();
            bool isTrue = Convert.ToBoolean(booleanInput);
            Console.WriteLine(isTrue ? "Yes" : "No");
        }
    }
}