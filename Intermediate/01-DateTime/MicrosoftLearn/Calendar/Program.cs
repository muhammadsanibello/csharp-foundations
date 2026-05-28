using System.Globalization;

// Create a calendar instance
Calendar calendar = CultureInfo.InvariantCulture.Calendar;

// Get the number of days in May 2026
int daysInMonth = calendar.GetDaysInMonth(2026, 5);
Console.WriteLine($"Days in May 2026: {daysInMonth}");

// Determine the week of the year for December 31, 2026
DateTime date = new DateTime(2026, 12, 31);
CalendarWeekRule rule = CalendarWeekRule.FirstDay;
DayOfWeek firstDayOfWeek = DayOfWeek.Sunday;
int weekOfYear = calendar.GetWeekOfYear(date, rule, firstDayOfWeek);
Console.WriteLine($"Week of the year for December 31, 2026: {weekOfYear}");