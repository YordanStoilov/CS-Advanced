
string[] lengths = Console.ReadLine().Split();

int set1Length = int.Parse(lengths[0]);
int set2Length = int.Parse(lengths[1]);

HashSet<int> set1 = new();
HashSet<int> set2 = new();

for (int i = 0; i < set1Length; i++)
{
    set1.Add(int.Parse(Console.ReadLine()));
}

for (int i = 0; i < set2Length; i++)
{
    set2.Add(int.Parse(Console.ReadLine()));
}

HashSet<int> commonNumbers = set1.Intersect(set2).ToHashSet();

Console.WriteLine(string.Join(" ", commonNumbers));