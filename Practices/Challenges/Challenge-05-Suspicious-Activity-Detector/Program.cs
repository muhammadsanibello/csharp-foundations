// Suspicious Activity Detector Program

int[] loginAttempts = [1, 0, 0, 1, 0];

// 1 = Success
// 0 = failed attempt

int failedAttempts = 0;

foreach (var attempt in loginAttempts)
{
    if (attempt == 0)
    {
        failedAttempts++;
    }
}

if (failedAttempts >= 3)
{
    Console.WriteLine("Account locked");
}

else
{
    Console.WriteLine("Access status normal");
}