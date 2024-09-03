
List<string> names = Console.ReadLine().Split().ToList();

Action<string> PrintName = s => Console.WriteLine(s);

foreach (string name in names)
{
    PrintName(name);
}