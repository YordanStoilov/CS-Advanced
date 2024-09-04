
int n = int.Parse(Console.ReadLine());
int[] divisors = Console.ReadLine().Split().Select(int.Parse).ToArray();
List<Predicate<int>> predicates = new();
int[] numbersRange = Enumerable.Range(1, n).ToArray();

foreach (int num in divisors)
{
    predicates.Add(x => x % num == 0);
}

foreach (Predicate<int> predicate in predicates)
{
    numbersRange = numbersRange.Where(x => predicate(x)).ToArray();
}
if (numbersRange.Length > 0)
{
    Console.WriteLine(string.Join(" ", numbersRange));
}