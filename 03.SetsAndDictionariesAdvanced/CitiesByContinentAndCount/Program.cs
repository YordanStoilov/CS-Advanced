
int n = int.Parse(Console.ReadLine());
Dictionary<string, Dictionary<string, List<string>>> locations = new();

for (int i = 0; i < n; i++)
{
    string[] line = Console.ReadLine().Split();
    string continent = line[0], country = line[1], city = line[2];
    if (!locations.ContainsKey(continent))
    {
        locations[continent] = new Dictionary<string, List<string>>();
    }
    if (!locations[continent].ContainsKey(country))
    {
        locations[continent][country] = new List<string>();
    }
    locations[continent][country].Add(city);
}

foreach (var (continent, countries) in locations)
{
    Console.WriteLine($"{continent}:");
    foreach (var (country, cities) in countries)
    {
        Console.WriteLine($"  {country} -> {string.Join(", ", cities)}");
    }
}

