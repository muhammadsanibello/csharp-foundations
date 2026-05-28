DateTime utcTime = DateTime.UtcNow; // Get current UTC time
Console.WriteLine($"UTC Time: {utcTime}");

TimeZoneInfo estZone = TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time"); // Find EST time zone
Console.WriteLine($"EST Time Zone: {estZone.DisplayName}");

DateTime estTime = TimeZoneInfo.ConvertTimeFromUtc(utcTime, estZone); // Convert UTC to EST
Console.WriteLine($"EST Time: {estTime}");

TimeZoneInfo localZone = TimeZoneInfo.Local; // Get local time zone
Console.WriteLine($"Local Time Zone: {localZone.DisplayName}");

DateTime localTime = TimeZoneInfo.ConvertTimeFromUtc(utcTime, localZone); // Convert UTC to local time
Console.WriteLine($"Local Time: {localTime}");

TimeZoneInfo pstZone = TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time"); // Find PST time zone
Console.WriteLine($"PST Time Zone: {pstZone.DisplayName}");

DateTime pstTime = TimeZoneInfo.ConvertTimeFromUtc(utcTime, pstZone); // Convert UTC to PST
Console.WriteLine($"PST Time: {pstTime}");