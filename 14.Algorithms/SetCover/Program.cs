

List<int> fullSet = Console.ReadLine().Split(", ").Select(int.Parse).ToList();
int n = int.Parse(Console.ReadLine());

List<int[]> subsets = new List<int[]>();
List<int[]> finalSets = new List<int[]>();

for (int i = 0; i < n; i++)
{
    subsets.Add(Console.ReadLine().Split(", ").Select(int.Parse).ToArray());
}
;

while (fullSet.Count > 0)
{
    int maxCovered = 0;
    List<int> elements = new();
    int[] bestSubset = null;

    for (int i = 0; i < subsets.Count; i++)
    {
        for (int j = 0; j < subsets[i].Length; j++)
        {
            int currentNum = subsets[i][j];
            if (fullSet.Contains(currentNum))
            {
                elements.Add(currentNum);
            }
        }

        if (elements.Count > maxCovered)
        {
            maxCovered = elements.Count;
            bestSubset = subsets[i].ToArray();
        }
        elements = new();
    }

    foreach(var element in bestSubset)
    {
        fullSet.Remove(element);
    }
    finalSets.Add(bestSubset);
}

Console.WriteLine($"Sets to take ({finalSets.Count}):");

foreach (var set in finalSets)
{
    Console.Write("{ ");

    for (int i = 0; i < set.Length - 1; i++)
    {
        Console.Write($"{set[i]}, ");
    }

    Console.Write(set[set.Length - 1]);
    Console.Write(" }");
    Console.WriteLine();
}