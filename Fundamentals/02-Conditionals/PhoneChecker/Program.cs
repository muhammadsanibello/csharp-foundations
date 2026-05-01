bool hasReceipt = true;
bool isBlackListed = false;
bool policeAlert = false;

if ((isBlackListed == true) || (policeAlert == true))
{
    Console.WriteLine("HOLD INDIVIDUAL AND CALL POLICE");
}
else if (hasReceipt == false)
{
    Console.WriteLine("PERMIT DENIED: Receipt Required.");
}
else
{
    Console.WriteLine("ACCES GRANTED: Save to Enter");
}