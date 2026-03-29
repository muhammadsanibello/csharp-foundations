// Converting int to string
int first = 5;
int second = 7;
string message = first.ToString() + second.ToString();
Console.WriteLine(message);

// Converting string to int using Parse() helper method
string firstNumber = "5";
string secondNumber = "7";
int sum = int.Parse(firstNumber) + int.Parse(secondNumber);
Console.WriteLine(sum);

// Converting string to int using convert class
string value1 = "5";
string value2 = "7";
int result = Convert.ToInt32(value1) * Convert.ToInt32(value2);
Console.WriteLine(result);

// Compare casting and converting a decimal into an int
int value = (int)1.5m; // casting truncate
Console.WriteLine(value);

int value3 = Convert.ToInt32(1.5m); // converting rounds up
Console.WriteLine(value3);