// DiceGame

Random dice = new Random();
int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;

if ((roll1 == roll2) || (roll1 == roll3) || (roll2 == roll3))
{
    if ((roll1 == roll2) && (roll2 == roll3))
    {
        Console.WriteLine("Awesome!! You rolled triples! +6 bonus to total\n");
        total += 6;
    }

    else
    {
        Console.WriteLine("Wow! You rolled doubles! +2 bonus to total\n");
        total += 2;
    }
}

Console.WriteLine($"{roll1} + {roll2} + {roll3} = {total}\n");
if (total >= 15)
{
    Console.WriteLine("You Won!\n");
}
else if (total <= 14)
{
    Console.WriteLine("You lost!\n");
}

Console.WriteLine("Press any key to exit...");
Console.ReadKey();