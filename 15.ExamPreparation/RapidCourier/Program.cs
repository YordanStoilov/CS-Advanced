

Stack<int> packages = new Stack<int>(Console.ReadLine().Split(" ",
    StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));

Queue<int> couriers = new Queue<int>(Console.ReadLine().Split(" ",
    StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));

int totalWeight = 0;

while (packages.Count > 0 && couriers.Count > 0)
{
    int package = packages.Pop();
    int capacity = couriers.Dequeue();

    int difference = capacity - package;

    if (difference >= 0)
    {
        totalWeight += package;
        if (difference - package > 0)
        {
            couriers.Enqueue(difference - package);
        }
    }
    else
    {
        totalWeight += capacity;
        packages.Push(package - capacity);
    }
}

Console.WriteLine($"Total weight: {totalWeight} kg");

if (packages.Count <= 0 && couriers.Count <= 0)
{
    Console.WriteLine("Congratulations, all packages were delivered successfully by the couriers today.");
}
else if (couriers.Count <= 0 && packages.Count > 0)
{
    Console.WriteLine($"Unfortunately, there are no more available couriers to deliver the following " +
        $"packages: {string.Join(", ", packages)}");
}
else if (packages.Count <= 0 && couriers.Count > 0)
{
    Console.WriteLine($"Couriers are still on duty: {string.Join(", ", couriers)} but there are no more packages to deliver.");
}