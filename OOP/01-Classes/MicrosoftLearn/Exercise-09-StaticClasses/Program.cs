// Static Class

public static class TemperatureConverter
{
    public static double CelciusToFahrenheit(string temperatureCelcius)
    {
        // Convert argument to double for calculations.
        double celcius = double.Parse(temperatureCelcius);

        // Convert Celcius to Fahrenheit.
        double fahrenheit = (celcius * 9 / 5) + 32;

        return fahrenheit;
    }

    public static double FahrenheitToCelcius(string temperatureFahrenheit)
    {
        // Convert argument to double for calculations.
        double farenheit = double.Parse(temperatureFahrenheit);

        // Convert Fahrenheit to Celcius.
        double celcius = (farenheit - 32) * 5 / 9;

        return celcius;
    }

}

class TestTemperatureConverter
{
    static void Main()
    {
        Console.WriteLine("Please select the convertor direction");
        Console.WriteLine("1. From Celcius to Fahrenheit.");
        Console.WriteLine("2. From Fahrenheit to Celcius.");
        Console.WriteLine(":");

        string? selection = Console.ReadLine();
        double F, C = 0;

        switch (selection)
        {
            case "1":
                Console.Write("Please enter Celcius temperature: ");
                F = TemperatureConverter.CelciusToFahrenheit(Console.ReadLine() ?? "0");
                Console.WriteLine("Temperature in Fahrenheit: {0:F2}", F);
                break;
            case "2":
                Console.Write("Please enter Farenheit temperature: ");
                C = TemperatureConverter.FahrenheitToCelcius(Console.ReadLine() ?? "0");
                Console.WriteLine("Temperature in Celcius: {0:F2}", C);
                break;
            default:
                Console.WriteLine("Please select a convertor.");
                break;
        }

        // Keep the console window open in debug mode.
        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();

    }
}