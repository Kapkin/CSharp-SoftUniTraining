using System;

namespace _16.CompairingFloats
{
    class ComparingFloats
    {
        static void Main()
        {
            double firstNum = double.Parse(Console.ReadLine());
            double secondNum = double.Parse(Console.ReadLine());

            float eps = 0.000001f;
            double difference = Math.Abs(firstNum - secondNum);

            Console.WriteLine(difference <= eps ? "True" : "False");
        }
    }
}
