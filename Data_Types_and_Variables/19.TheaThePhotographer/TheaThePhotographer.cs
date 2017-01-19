using System;

namespace _19.TheaThePhotographer
{
    class TheaThePhotographer
    {
        static void Main()
        {
            long  takenPics = long.Parse(Console.ReadLine());
            long filterTimeInSeconds = long.Parse(Console.ReadLine());
            long percentOfFilteredPics =long.Parse(Console.ReadLine());
            long neededTimeForUpload = long.Parse(Console.ReadLine());

            decimal filtredPics = Math.Ceiling(takenPics * 
                percentOfFilteredPics / 100.0m);
            long timeForFilter = takenPics * filterTimeInSeconds;
            long timeForUploadedPics = (long)filtredPics * neededTimeForUpload;

            long totalNeededTime = timeForFilter + timeForUploadedPics;

            TimeSpan time = TimeSpan.FromSeconds(totalNeededTime);
            Console.WriteLine("{0:d1}:{1:d2}:{2:d2}:{3:d2}",
                          time.Days,
                          time.Hours,
                          time.Minutes,
                          time.Seconds);
        }
    }
}
