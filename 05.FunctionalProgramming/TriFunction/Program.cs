
int AsciiSum(string name)
{
    int sum = 0;

    foreach (char character in name)
    {
        sum += character;
    }
    return sum;
}

string FindNameBasedOnFunction(string[] names, Predicate<string> predicate)
{
    string[] filtered = names.Where(name => predicate(name)).ToArray();
    if (filtered.Length > 0)
    {
        return filtered[0];
    }
    return null;
}

int n = int.Parse(Console.ReadLine());
string[] names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
Predicate<string> predicate = name => AsciiSum(name) >= n;
Action<string> Print = value => Console.WriteLine(value);

Print(FindNameBasedOnFunction(names, predicate));
