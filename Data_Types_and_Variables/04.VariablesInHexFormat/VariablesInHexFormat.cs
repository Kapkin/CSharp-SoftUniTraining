using System;
namespace _04.VariablesInHexFormat
{
    public class VariablesInHexFormat
    {
        public static void Main()
        {
            string variableInHex = Console.ReadLine();
            Console.WriteLine(Convert.ToInt32(variableInHex, 16));
            
        }
    }
}
