interface IMetric
{
    double GetDistance();  // Return meters
}

interface IImperial
{
    double GetDistance();  // Return feet
}

public class Runway(double meters) : IMetric, IImperial
{
    // Explicit implementation for IMetric
    double IMetric.GetDistance() => meters;

    // Explicit implemtation for IImperial
    double IImperial.GetDistance() => meters;
}