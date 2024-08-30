
Dictionary<string, List<decimal>> grades = new();
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    string[] data = Console.ReadLine().Split();
    if (!grades.ContainsKey(data[0]))
    {
        grades[data[0]] = new List<decimal>();
    }
    grades[data[0]].Add(decimal.Parse(data[1]));
}

foreach (var (name, listGrades) in grades)
{
    Console.Write($"{name} -> ");
    foreach (decimal grade in listGrades)
    {
        Console.Write($"{grade:F2} ");
    }
    Console.Write($"(avg: {listGrades.Average():F2})");
    Console.WriteLine();
}