using System;

namespace _10.CenturiesToNanoseconds
{
    class CenturiesToNanoseconds
    {
        static void Main()
        {
            byte centuries = byte.Parse(Console.ReadLine());
            int years = centuries * 100;
            int days = (int)(Convert.ToInt32(years) * 365.2422);
            int hours = days * 24;
            int minutes = hours * 60;
            ulong seconds = Convert.ToUInt64(minutes) * 60;
            ulong miliseconds = seconds * 1000;
            decimal microseconds = miliseconds * 1000;
            decimal nanoseconds = microseconds * 1000;

            Console.WriteLine(
                $"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds}"+
                $" seconds = {miliseconds} milliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds");
        }
    }
}
