
int n = int.Parse(Console.ReadLine());
Dictionary<string, Dictionary<string, int>> clothes = new();

for (int i = 0; i < n; i++)
{
    string[] input = Console.ReadLine().Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
    string color = input[0];
    string[] currentClothes = input[1].Split(",");

    if (!clothes.ContainsKey(color))
    {
        clothes[color] = new Dictionary<string, int>();
    }

    for (int j = 0; j < currentClothes.Length; j++)
    {
        if (!clothes[color].ContainsKey(currentClothes[j]))
        {
            clothes[color][currentClothes[j]] = 0;
        }
        clothes[color][currentClothes[j]]++;
    }
}

string[] itemForSearch = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

foreach (var kvp in clothes)
{
    Console.WriteLine($"{kvp.Key} clothes:");
    foreach (var dict in kvp.Value)
    {
        Console.Write($"* {dict.Key} - {dict.Value}");
        if (kvp.Key == itemForSearch[0] && dict.Key == itemForSearch[1])
        {
            Console.Write(" (found!)");
        }
        Console.WriteLine();
    }
}