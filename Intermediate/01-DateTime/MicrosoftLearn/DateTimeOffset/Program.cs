DateTimeOffset now = DateTimeOffset.Now; // Get the current date and time with offset
Console.WriteLine($"Current date and time with offset: {now}");

DateTimeOffset utcNow = DateTimeOffset.UtcNow; // Get the current UTC date and time with offset
Console.WriteLine($"Current UTC date and time with offset: {utcNow}");

DateTimeOffset futureDate = now.AddDays(10); // Add 10 days to the current date and time
Console.WriteLine($"Date 10 days from now: {futureDate}");

DateTimeOffset pastDate = now.AddHours(-5); // Subtract 5 hours from the current date and time
Console.WriteLine($"Date 5 hours ago: {pastDate}");

TimeSpan difference = futureDate - now; // Calculate the time difference between two dates
Console.WriteLine($"Difference between now and future date: {difference}");