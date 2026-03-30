int target = 60;
int[] coins = new int[] { 5, 5, 50, 25, 25, 10, 5 };
int[] result = TwoCoins(coins, target);

if (result.Length == 0)
{
    Console.WriteLine("No Coins make change");
}

else
{
    Console.WriteLine($"Coins make change at positions {result[0]} and {result[1]}");
}

    int[] TwoCoins(int[] coins, int target)
    {
        for (int curr = 0; curr < coins.Length; curr++)
        {
            for (int next = curr + 1; next < coins.Length; next++)
            {
                if (coins[curr] + coins[next] == target)
                {
                    return new int[] { curr, next };
                }
            }
        }

        return new int[0];
    }