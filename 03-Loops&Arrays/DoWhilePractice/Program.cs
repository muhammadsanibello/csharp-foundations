// Do-While loop
Random random = new();
int current = 0;

do
{
    current = random.Next(1, 11);
    Console.WriteLine(current);
} while (current != 7);

// While Loop
int current1 = random.Next(1, 11);

while (current1 >= 3)
{
    Console.WriteLine(current1);
    current1 = random.Next(1, 11);
}

Console.WriteLine($"Last Number: {current1}");

// Using Continue
int current2 = random.Next(1, 11);

do
{
    current2 = random.Next(1, 11);

    if (current2 >= 8) continue;

    Console.WriteLine(current2);
} while (current2 != 7);