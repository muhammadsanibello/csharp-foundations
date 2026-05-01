// SIGNED INTEGRAL TYPE (- $ +)
Console.WriteLine("Signed integral types:\n");

Console.WriteLine($"sbyte : {sbyte.MinValue} to {sbyte.MaxValue}");
Console.WriteLine($"short : {short.MinValue} to {short.MaxValue}");
Console.WriteLine($"int : {int.MinValue} to {int.MaxValue}");
Console.WriteLine($"long : {long.MinValue} to {long.MaxValue}\n\n");

// UNSIGNED INTEGRAL TYPE (+ only)
Console.WriteLine("Unsigned integral types:\n");

Console.WriteLine($"byte : {byte.MinValue} to {byte.MaxValue}");
Console.WriteLine($"ushort : {ushort.MinValue} to {ushort.MaxValue}");
Console.WriteLine($"uint : {uint.MinValue} to {uint.MaxValue}");
Console.WriteLine($"ulong : {ulong.MinValue} to {ulong.MaxValue}");

// FLOATING POINT TYPES
Console.WriteLine("");
Console.WriteLine("Floating point types:\n");

Console.WriteLine($"float : {float.MinValue} to {float.MaxValue}");
Console.WriteLine($"double : {double.MinValue} to {double.MaxValue}");
Console.WriteLine($"decimal : {decimal.MinValue} to {decimal.MaxValue}");

// REFERENCE TYPE VARIABLE
Console.WriteLine("");
Console.WriteLine("Example of a Reference type variable:\n");

int[] data = new int[3];