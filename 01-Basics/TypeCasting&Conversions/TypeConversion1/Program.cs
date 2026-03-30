// Automatic conversion by a compiler.
int first = 2;
string second = "4";
string result = first + second;
Console.WriteLine(result);

// Widening conversion (implicit conversion)
int myInt = 3;
Console.WriteLine($"int: {myInt}");

decimal myDecimal = myInt;
Console.WriteLine($"decimal: {myDecimal}");

// Narrowing conversion (explicit conversion, intentional)
decimal myDecimal1 = 3.14m;
Console.WriteLine($"decimal: {myDecimal1}");

int myInt1 = (int)myDecimal1;
Console.WriteLine($"int: {myInt1}");

decimal myDecimal2 = 1.234567897676666669m;
float myFloat = (float)myDecimal2;

Console.WriteLine($"Decimal: {myDecimal2}");
Console.WriteLine($"Float: {myFloat}");