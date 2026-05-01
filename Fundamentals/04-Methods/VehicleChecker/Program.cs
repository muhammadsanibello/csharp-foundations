// Methods

CheckVehicleStatus("BAU-123", 60);
CheckVehicleStatus("KNO-999", 80);
CheckVehicleStatus("XYZ", 140);

static void CheckVehicleStatus(string plateNumber, int speed)
{
    if (plateNumber == "BAU-123")
    {
        Console.WriteLine("WARNING: This bike is reported STOLEN in BAUCHI!");
    }

    else if (plateNumber == "KNO-999")
    {
        Console.WriteLine("CAUTION: This bike is flagged for unpaid registration");
    }

    else if (speed > 120)
    {
        Console.WriteLine("ALARM: Vehicle is overspeeding! Possible escape in progress...");
    }
    else
    {
        Console.WriteLine("CLEAR: No record found. Vehicle is safe");
    }
}