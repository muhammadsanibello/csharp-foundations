int heroHealth = 10;
int monsterHealth = 10;

Random attack = new Random();
int heroTurn = 0;
int monsterTurn = 0;

do
{
    heroTurn = attack.Next(1, 11);
    monsterHealth -= heroTurn;
    Console.WriteLine($"The Monster lost {heroTurn} of health, the remaining monster Health is {monsterHealth}");

    if (monsterHealth <= 0) continue;

    monsterTurn = attack.Next(1, 11);
    heroHealth -= monsterTurn;
    Console.WriteLine($"The Hero lost {monsterTurn} of Health, the remaining hero health is {heroHealth}");

} while (heroHealth > 0 && monsterHealth > 0);

Console.WriteLine(heroHealth > monsterHealth ? "Hero wins!" : "Monster wins!");