int passwordAttempts = 2;
bool remoteActive = false;
string activeSim = "MTN_NG1";

if (remoteActive)
{
    Console.WriteLine("ALERT: Phone has stolled! - Sending GPS location...");
}
else if (activeSim == "")
{
    Console.WriteLine("PHONE LOCKED: Master Password is required! - Sending SMS with location...");
}
else if (passwordAttempts >= 3)
{
    Console.WriteLine("TRAP: 3 failed attempts. Taking photo of user...");
}
else
{
    Console.WriteLine("Welcome! Nothing unusual happened");
}