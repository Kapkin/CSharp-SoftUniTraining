using System;

class PriceChangeAlert
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        double threshold = double.Parse(Console.ReadLine());

        double currentPrice = double.Parse(Console.ReadLine());

        for (int i = 0; i < n - 1; i++)
        {
            double nextPrice = double.Parse(Console.ReadLine());
            double differenceInPercentages = GetDifferneceInPercentage(currentPrice, nextPrice);
            bool isSignificantDifference = IsSignificantDifference(threshold, differenceInPercentages);
            string message = GetMessageForPriceChanges(nextPrice, currentPrice, differenceInPercentages, isSignificantDifference);

            Console.WriteLine(message);

            currentPrice = nextPrice;
        }
    }

    private static string GetMessageForPriceChanges(double nextPrice, double currentPrice, double differenceInPercentages, bool isSignificantDifference)
    {
        string message = "";
        if (differenceInPercentages == 0)
        {
            message = string.Format("NO CHANGE: {0}", nextPrice);
        }
        else if (!isSignificantDifference)
        {
            message = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)",
                currentPrice, nextPrice, differenceInPercentages * 100);
        }
        else if (isSignificantDifference && (differenceInPercentages > 0))
        {
            message = string.Format("PRICE UP: {0} to {1} ({2:F2}%)",
                currentPrice, nextPrice, differenceInPercentages * 100);
        }
        else if (isSignificantDifference && (differenceInPercentages < 0))
        {
            message = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", 
                currentPrice, nextPrice, Math.Abs(differenceInPercentages * 100));
        }

        return message;
    }
    private static bool IsSignificantDifference(double treshold, double differenceInPercentage)
    {
        if (treshold <= Math.Abs(differenceInPercentage))
        {
            return true;
        }

        return false;
    }
    private static double GetDifferneceInPercentage(double currentPrice, double nextPrice)
    {
        double differenceInPercentages = (nextPrice - currentPrice) / currentPrice;
        return differenceInPercentages;
    }
}
