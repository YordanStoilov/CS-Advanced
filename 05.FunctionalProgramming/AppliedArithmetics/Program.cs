

Action<int[]> PrintArray = array => Console.WriteLine(string.Join(" ", array));

int[] nums = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse).ToArray();

while (true)
{
    Func<int, int> action = x => x;
    string input = Console.ReadLine();
    if (input.ToLower() == "end")
    {
        break;
    }
    if (input.ToLower() == "add")
    {
        action = x => x + 1;
    }
    else if (input.ToLower() == "multiply")
    {
        action = x => x * 2;
    }
    else if (input.ToLower() == "subtract")
    {
        action = x => x - 1;
    }
    else if (input.ToLower() == "print")
    {
        PrintArray(nums);
    }
    nums = nums.Select(x => action(x)).ToArray();
}
