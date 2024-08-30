
Dictionary<double, int> occurences = new();
double[] input = Console.ReadLine()
.Split(" ", StringSplitOptions.RemoveEmptyEntries)
.Select(double.Parse)
.ToArray();

foreach (double value in input)
{
    if (!occurences.ContainsKey(value))
    {
        occurences[value] = 0;
    }
    occurences[value]++;
}

foreach (var (value, times) in occurences)
{
    Console.WriteLine($"{value} - {times} times");
}
