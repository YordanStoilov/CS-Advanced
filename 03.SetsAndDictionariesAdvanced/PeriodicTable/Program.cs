
HashSet<string> uniqueElements = new();
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    string[] elements = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

    foreach (string element in elements)
    {
        uniqueElements.Add(element);
    }
}

Console.WriteLine(string.Join(" ", uniqueElements
.OrderBy(x => x)
.ToHashSet()));