
SortedDictionary<string, Dictionary<string, double>> products = new();

while (true)
{
    string line = Console.ReadLine();
    if (line.ToLower() == "revision")
    {
        break;
    }
    string[] data = line.Split(", ", StringSplitOptions.RemoveEmptyEntries);
    string shopName = data[0], product = data[1];
    double price = double.Parse(data[2]);
    if (!products.ContainsKey(shopName))
    {
        products[shopName] = new Dictionary<string, double>();
    }
    products[shopName][product] = price;
}
foreach (var kvp in products)
{
    Console.WriteLine($"{kvp.Key}->");
    foreach (var (product, price) in kvp.Value)
    {
        Console.WriteLine($"Product: {product}, Price: {price}");
    }
}