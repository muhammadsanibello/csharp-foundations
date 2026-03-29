// Converting the string into an int using TryParse()
string value = "2024";
int result;
bool final = int.TryParse(value, out result);
if (int.TryParse(value, out result))
    Console.WriteLine($"Measurement: {result}");
else
    Console.WriteLine("Unable to report the measurement.");

if (result > 0)
    Console.WriteLine($"Measurement (w/ offset): {50 + result}");

// Converting Challenge
string myInput = "2.71828";
decimal myInputDecimal = Convert.ToDecimal(myInput);
Console.WriteLine($"{50 + myInputDecimal}");