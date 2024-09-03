
Func<List<int>, int> FindMin = list => list.Min();

List<int> nums = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
.Select(int.Parse)
.ToList();

Console.WriteLine(FindMin(nums));