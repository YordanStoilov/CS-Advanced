
char[] chars = Console.ReadLine().ToCharArray();
SortedDictionary<char, int> charOccurences = new();

foreach (char character in chars)
{
    if (!charOccurences.ContainsKey(character))
    {
        charOccurences[character] = 0;
    }
    charOccurences[character]++;
}
foreach (var kvp in charOccurences)
{
    Console.WriteLine($"{kvp.Key}: {kvp.Value} time/s");
}