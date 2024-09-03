
int n = int.Parse(Console.ReadLine());
string[] names = Console.ReadLine().Split();

Predicate<string> predicate = name => name.Length <= n;
Action<string[]> PrintNames = names => Console.WriteLine(string.Join("\n", names));

names = names.Where(name => predicate(name)).ToArray();
PrintNames(names);