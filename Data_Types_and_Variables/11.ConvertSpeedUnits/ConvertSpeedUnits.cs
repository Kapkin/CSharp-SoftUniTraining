using System;

namespace _11.ConvertSpeedUnits
{
    class ConvertSpeedUnits
    {
        static void Main()
        {
            int distance = int.Parse(Console.ReadLine());
            float hours = float.Parse(Console.ReadLine());
            double minutes = double.Parse(Console.ReadLine());
            double seconds = double.Parse(Console.ReadLine());

            float timeInHours = hours + (float)(minutes / 60) + (float)(seconds / 3600);

            float speedInMetersPerSeconds = distance / (timeInHours*3600);
            float speedInKmPerHour = (distance / 1000) / timeInHours;
            float speedInMilesPerHour = (distance /1609) / timeInHours;
            
            Console.WriteLine($"{speedInMetersPerSeconds}");
            Console.WriteLine($"{speedInKmPerHour}");
            Console.WriteLine($"{speedInMilesPerHour}");
        }
    }
}
