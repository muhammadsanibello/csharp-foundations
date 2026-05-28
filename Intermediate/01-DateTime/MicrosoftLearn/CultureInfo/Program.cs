// Retrieve the current culture and UI culture
using System.Globalization;

CultureInfo currentCulture = CultureInfo.CurrentCulture;
CultureInfo currentUICulture = CultureInfo.CurrentUICulture;
Console.WriteLine($"Current Culture: {currentCulture.Name}");
Console.WriteLine($"Current UI Culture: {currentUICulture.Name}");

// Set a new culture and UI culture
CultureInfo newCulture = new CultureInfo("fr-FR");
CultureInfo.CurrentCulture = newCulture;
CultureInfo.CurrentUICulture = newCulture;
Console.WriteLine($"New Culture: {CultureInfo.CurrentCulture.Name}");
Console.WriteLine($"New UI Culture: {CultureInfo.CurrentUICulture.Name}");