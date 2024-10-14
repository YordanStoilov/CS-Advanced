

Queue<int> tools = new Queue<int> (Console.ReadLine().Split(" ", 
    StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));

Stack<int> substances = new Stack<int> (Console.ReadLine().Split(" ",
    StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList());

List<int> challenges = Console.ReadLine().Split(" ",
    StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

while (challenges.Count > 0)
{

    if (tools.Count <= 0 || substances.Count <= 0)
    {
        Console.WriteLine("Harry is lost in the temple. Oblivion awaits him.");
        break;
    }

    int tool = tools.Dequeue();
    int substance = substances.Pop();
    int value = tool * substance;

    if (challenges.Contains (value))
    {
        challenges.Remove (value);
    }
    else
    {
        tools.Enqueue (tool + 1);

        if (substance > 1)
        {
            substances.Push (substance - 1);
        }
    }
}

if (challenges.Count <= 0)
{
    Console.WriteLine("Harry found an ostracon, which is dated to the 6th century BCE.");
}

if (tools.Count > 0)
{
    Console.WriteLine($"Tools: {string.Join(", ", tools)}");
}

if (substances.Count > 0)
{
    Console.WriteLine($"Substances: {string.Join(", ", substances)}");
}

if (challenges.Count > 0)
{
    Console.WriteLine($"Challenges: {string.Join(", ", challenges)}");
}

