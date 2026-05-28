TimeSpan duration = new TimeSpan(2, 14, 18); // 2 hours, 14 minutes, 18 seconds
Console.WriteLine($"Duration: {duration}");

TimeSpan fromDays = TimeSpan.FromDays(1.5); // Create TimeSpan from 1.5 days
Console.WriteLine($"From Days: {fromDays}");

TimeSpan fromHours = TimeSpan.FromHours(5.75); // Create TimeSpan from 5.75 hours
Console.WriteLine($"From Hours: {fromHours}");

TimeSpan difference = TimeSpan.FromHours(10) - TimeSpan.FromMinutes(30); // Subtract intervals
Console.WriteLine($"Differences: {difference}");

TimeSpan multiplied = TimeSpan.FromMinutes(15) * 2; // Multiply interval
Console.WriteLine($"Multiplied: {multiplied}");