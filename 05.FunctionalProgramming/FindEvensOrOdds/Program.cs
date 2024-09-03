
int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
int start = input[0], end = input[1];
string criteria = Console.ReadLine();

Predicate<int> predicate;
if (criteria.ToLower() == "odd")
{
    predicate = num => num % 2 != 0;
}
else if (criteria.ToLower() == "even")
{
    predicate = num => num % 2 == 0;
}
else
{
    return;
}

int[] numbers = Enumerable.Range(start, end - start + 1)
    .Where(num => predicate(num))
    .ToArray();
if (numbers.Length > 0)
{
    Console.WriteLine(string.Join(" ", numbers));
}

