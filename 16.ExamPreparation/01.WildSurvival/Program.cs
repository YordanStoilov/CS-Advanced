

Queue<int> bees = new Queue<int> (Console.ReadLine().Split(" ", 
    StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));

Stack<int> beeEaters = new Stack<int>(Console.ReadLine().Split(" ",
    StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));

while (beeEaters.Count > 0 && bees.Count > 0)
{
    int bee = bees.Dequeue();
    int beeEater = beeEaters.Pop();

    int beesSurvived = Math.Max(0, bee - (beeEater * 7));
    int beeEatersSurvived = beeEater - (bee / 7);

    if (beesSurvived > 0)
    {
        bees.Enqueue (beesSurvived);
    }
    if (beeEatersSurvived > 0)
    {
        if (beeEaters.Count > 0)
            beeEaters.Push(beeEaters.Pop() + beeEatersSurvived);
        else
            beeEaters.Push (beeEatersSurvived);
    }
}

Console.WriteLine("The final battle is over!");

if (beeEaters.Count == 0 && bees.Count == 0)
{
    Console.WriteLine("But no one made it out alive!");
}
else if (beeEaters.Count == 0)
{
    Console.WriteLine($"Bee groups left: {string.Join(", ", bees)}");
}
else
{
    Console.WriteLine($"Bee-eater groups left: {string.Join(", ", beeEaters)}");
}