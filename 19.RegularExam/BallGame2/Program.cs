Stack<int> strengths = new Stack<int>(Console.ReadLine().Split(" ",
    StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));

Queue<int> accuracies = new Queue<int>(Console.ReadLine().Split(" ",
    StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));

int goals = 0;

while (strengths.Any() && accuracies.Any())
{
    int strength = strengths.Peek();
    int accuracy = accuracies.Peek();

    int sum = strength + accuracy;

    if (sum == 100)
    {
        goals++;
        strengths.Pop();
        accuracies.Dequeue();
    }
    else if (sum < 100)
    {
        if (strength < accuracy)
        {
            strengths.Pop();
        }
        else if (strength > accuracy)
        {
            accuracies.Dequeue();
        }
        else
        {
            strengths.Pop();
            strengths.Push(strength + accuracy);
            accuracies.Dequeue();
        }
    }
    else
    {
        strengths.Push(strengths.Pop() - 10);

        accuracies.Enqueue(accuracies.Dequeue());
    }
}

if (goals > 3)
{
    Console.WriteLine("Paul performed remarkably well!");
}
else if (goals == 3)
{
    Console.WriteLine("Paul scored a hat-trick!");
}
else if (goals > 0)
{
    Console.WriteLine("Paul failed to make a hat-trick.");
}
else
{
    Console.WriteLine("Paul failed to score a single goal.");
}

if (goals > 0)
{
    Console.WriteLine($"Goals scored: {goals}");
}

if (strengths.Any())
{
    Console.WriteLine($"Strength values left: {string.Join(", ", strengths)}");
}
if (accuracies.Any())
{
    Console.WriteLine($"Accuracy values left: {string.Join(", ", accuracies)}");
}
