
Dictionary<string, int> numbersOccurence = new();
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    string num = Console.ReadLine();
    if (!numbersOccurence.ContainsKey(num))
    {
        numbersOccurence[num] = 0;
    }
    numbersOccurence[num]++;
}

Dictionary<string, int> even = numbersOccurence
.Where(x => x.Value % 2 == 0)
.Take(1)
.ToDictionary(x => x.Key, x => x.Value);

foreach (var kvp in even)
{
    Console.WriteLine(kvp.Key);
}
