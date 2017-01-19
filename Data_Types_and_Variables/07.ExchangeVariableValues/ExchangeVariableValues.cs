using System;

namespace _07.ExchangeVariableValues
{
    class ExchangeVariableValues
    {
        static void Main()
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum =int.Parse(Console.ReadLine());

            Console.WriteLine("Before:\r\n"+
                $"a = {firstNum}\r\n"+
                $"b = {secondNum}\r\n");
            Console.WriteLine("After:\r\n" +
                $"a = {secondNum}\r\n" +
                $"b = {firstNum}\r\n");
        }
    }
}
