
int n = int.Parse(Console.ReadLine());
HashSet<string> uniqueNames = new();

for (int i = 0; i < n; i++)
{
    uniqueNames.Add(Console.ReadLine());
}

foreach (string name in uniqueNames)
{
    Console.WriteLine(name);
}