DateTime today = DateTime.Now; // Get the current date and time
DayOfWeek day = today.DayOfWeek; // Retrieve the current day of the week
Console.WriteLine($"Today is {day}");

DateTime nextSunday = today.AddDays(7 - (int)day); // Calculate the next sunday
Console.WriteLine($"Next sunday is on: {nextSunday}");

bool isWeekend = day == DayOfWeek.Saturday || day == DayOfWeek.Sunday; // Check if today is a weekend
Console.WriteLine($"Is Today is a weekend? {isWeekend}");