string SIM_1 = "MTN_NG1";

if (SIM_1 == "MTN_NG1")
{
    Console.WriteLine("Authorized SIM! Successful");
}
else if (SIM_1 == "")
{
    Console.WriteLine("ALERT: No SIM detected! - Sending SMS...");
}
else
{
    Console.WriteLine("CRITICAL ALERT: Unauthorized SIM detected! - Screaming");
}