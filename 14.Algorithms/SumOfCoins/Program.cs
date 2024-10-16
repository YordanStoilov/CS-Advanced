

int[] coins = Console.ReadLine().Split(", ").Select(int.Parse).OrderByDescending(n => n).ToArray();
int moneySum = int.Parse(Console.ReadLine());

Dictionary<int, int> coinQuantities = new();
int coinsCount = 0;

while (true)
{
    bool coinsTaken = false;

    for (int i = 0; i < coins.Length; i++)
    {
        if (coins[i] <= moneySum)
        {
            if (!coinQuantities.ContainsKey(coins[i]))
            {
                coinQuantities[coins[i]] = 0;
            }
            coinQuantities[coins[i]]++;
            coinsCount++;
            moneySum -= coins[i];
            coinsTaken = true;
            break;
        }
    }
    if (coinsTaken == false)
    {
        if (moneySum > 0)
        {
            Console.WriteLine("Error");
            return;
        }
        break;
    }
}

Console.WriteLine($"Number of coins to take: {coinsCount}");

foreach (var kvp in coinQuantities)
{
    Console.WriteLine($"{kvp.Value} coin(s) with value {kvp.Key}");
}