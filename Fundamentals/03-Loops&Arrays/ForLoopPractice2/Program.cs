//Counting Up
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
}

//Counting down
for (int i = 10; i > 0; i--)
{
    Console.WriteLine(i);
}

// Skipping two values each iteration
for (int i = 0; i < 20; i += 3)
{
    Console.WriteLine(i);
}

// Stop iteration at 7 position
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
    if (i == 7) break;
}

//Looping through each element of array using For Loop
string[] names = { "Alex", "Eddie", "David", "Michael" };

for (int i = 0; i < names.Length; i++)
    if (names[i] == "Alex") names[i] = "Sani";

foreach (var name in names)
    Console.WriteLine(name);