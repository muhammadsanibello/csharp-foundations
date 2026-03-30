Random random = new Random();

Console.WriteLine("Would you like to play? (Y/N)");
if (ShouldPlay())
{
    PlayGame();
}

bool ShouldPlay()
{
    string? response = Console.ReadLine();
    return response.ToLower().Equals("y");
}

void PlayGame()
{
    var play = true;

    while (play)
    {
        var target = GetTarget();
        var roll = GetRoll();

        Console.WriteLine($"Roll number greater than {target} to win");
        Console.WriteLine($"You roll {roll}");
        Console.WriteLine(WinOrLost(roll, target));
        Console.WriteLine("Would you like to play again? (Y/N)");

        play = ShouldPlay();
    }
}

int GetTarget()
{
    return random.Next(1, 6);
}

int GetRoll()
{
    return random.Next(1, 7);
}

string WinOrLost(int roll, int target)
{
    if (roll > target)
    {
        return "You Win!";
    }

    return "You Lost!";
}