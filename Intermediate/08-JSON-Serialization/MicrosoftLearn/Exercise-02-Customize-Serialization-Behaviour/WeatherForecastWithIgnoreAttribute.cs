using System;
using System.Text.Json.Serialization;

namespace Exercise_02_Customize_Serialization_Behaviour
{
    // Ignore individual properties
    public class WeatherForecastWithIgnoreAttribute
    {
        public DateTimeOffset Date { get; } = DateTimeOffset.Now;
        public int Temperature { get; set; }

        [JsonIgnore]
        public string? Summary { get; set; }
    }
}