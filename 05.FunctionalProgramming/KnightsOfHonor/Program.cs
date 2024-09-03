
List<string> names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
Action<string> PrintWithTitle = name => Console.WriteLine($"Sir {name}");

names.ForEach(name => PrintWithTitle(name));