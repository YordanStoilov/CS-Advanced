
List<int> nums = Console.ReadLine()
.Split(" ", StringSplitOptions.RemoveEmptyEntries)
.Select(int.Parse)
.OrderByDescending(x => x)
.Take(3)
.ToList();

Console.WriteLine(string.Join(" ", nums));