using System.Globalization;

Calendar calendar = CultureInfo.InvariantCulture.Calendar;

DateTime date = new DateTime(2026, 1, 5);
CalendarWeekRule rule = CalendarWeekRule.FirstFourDayWeek;
DayOfWeek firstDayOfWeek = DayOfWeek.Sunday;
int weekOfYear = calendar.GetWeekOfYear(date, rule, firstDayOfWeek);
Console.WriteLine($"Week of the year: {weekOfYear}");