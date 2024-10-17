

Queue<int> contestants = new Queue<int> (Console.ReadLine().Split(" ", 
    StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));

Stack<int> pies = new Stack<int>(Console.ReadLine().Split(" ",
    StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));

while(contestants.Count > 0 && pies.Count > 0)
{
    int contestant = contestants.Dequeue();
    int pie = pies.Pop();

    if (contestant > pie)
    {
        contestant -= pie;
        contestants.Enqueue(contestant);
    }
    else if (contestant < pie)
    {
        int remainingPie = pie - contestant;

        if (remainingPie > 1)
        {
            pies.Push(remainingPie);
        }
        else
        {
            if (pies.Count > 0)
            {
                pies.Push(pies.Pop() + remainingPie);
            }
            else
            {
                pies.Push(remainingPie);
            }
        }
    }
}

if (contestants.Count > 0 && pies.Count == 0)
{
    Console.WriteLine("We will have to wait for more pies to be baked!");
    Console.WriteLine($"Contestants left: {string.Join(", ", contestants)}");
}
else if (contestants.Count == 0 && pies.Count == 0)
{
    Console.WriteLine("We have a champion!");
}
else if (contestants.Count == 0 && pies.Count > 0)
{
    Console.WriteLine("Our contestants need to rest!");
    Console.WriteLine($"Pies left: {string.Join(", ", pies)}");
}