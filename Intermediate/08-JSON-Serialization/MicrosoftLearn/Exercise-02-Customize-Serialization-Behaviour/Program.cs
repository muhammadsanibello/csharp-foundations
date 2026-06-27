using Exercise_02_Customize_Serialization_Behaviour;
using System.Text.Json;
using System.Text.Json.Serialization;

var forecast = new WeatherForecastWithIgnoreAttribute
{
    //Date = DateTimeOffset.Now,
    Temperature = 25,
    Summary = "Warm"
};

var option1 = new JsonSerializerOptions
{
    IgnoreReadOnlyProperties = true,
    WriteIndented = true
};

string jsonString = JsonSerializer.Serialize(forecast, option1);
Console.WriteLine(jsonString);

// Forecast object
var forecast1 = new Forecast
{
    Date = default,
    Summary = null,
    TemperatureC = default,
    Password = "12345678"
};

JsonSerializerOptions options = new()
{
    DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingDefault,
    WriteIndented = true,
    IncludeFields = true
};

string forecastJson =
    JsonSerializer.Serialize(forecast1, options);

Console.WriteLine(forecastJson);