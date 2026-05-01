// Number Guessing Game
Random random = new Random();
int target = random.Next(1, 101);

int attempts = 0;
int maxAttempts = 10;

Console.WriteLine("Guess a number between 1 and 100. You have 10 attempts:\n");

while (attempts < maxAttempts)
{
    Console.Write("Enter your guess: ");
    string? guess = Console.ReadLine();

    if (!int.TryParse(guess, out int number))
    {
        Console.WriteLine("Invalid input! Please enter a number.\n");
        continue;
    }

    attempts++;
    int remainingAttempts = maxAttempts - attempts;

    if (number > target)
    {
        Console.WriteLine($"Too high! You have {remainingAttempts} attempts left...\n");
    }
    else if (number < target)
    {
        Console.WriteLine($"Too low! You have {remainingAttempts} attempts left...\n");
    }
    else
    {
        Console.WriteLine($"Correct! You guessed in {attempts} attempts.");
        break;
    }

    if (remainingAttempts == 0)
    {
        Console.WriteLine($"\nYou are out of attempts! The number was {target}");
    }
}