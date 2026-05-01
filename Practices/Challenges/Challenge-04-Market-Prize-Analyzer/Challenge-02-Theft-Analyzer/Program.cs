// Phone Theft Pattern Detector

int[] theftReports = [2, 0, 5, 3, 1, 0, 4];

int total = 0;
int zeroTheft = 0;
int highest = theftReports[0];

foreach (int theft in theftReports)
{
    if (theft > highest)
    {
        highest = theft;
    }

    if (theft == 0)
    {
        zeroTheft++;
    }

    total += theft;
}

if (total > 10)
{
    Console.WriteLine("High risk week.");
}

else
{
    Console.WriteLine("Normal week.");
}

Console.WriteLine("");
Console.WriteLine($"Zero theft days: {zeroTheft}");
Console.WriteLine($"Highest theft in a day: {highest}");
Console.WriteLine($"Total thefts: {total}");