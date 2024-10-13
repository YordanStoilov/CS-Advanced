

Stack<int> fuelSequence = new Stack<int> (Console.ReadLine().Split(" ", 
    StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));

Queue<int> consumptionSequence = new Queue<int>(Console.ReadLine().Split(" ",
    StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));

Queue<int> neededSequence = new Queue<int>(Console.ReadLine().Split(" ",
    StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));

int altitudeReached = 0;
bool reachedTop = true;

for (int i = 0; i < 4; i++)
{
    if (fuelSequence.Pop() - consumptionSequence.Dequeue() >= neededSequence.Dequeue())
    {
        Console.WriteLine($"John has reached: Altitude {++altitudeReached}");
    }
    else
    {
        reachedTop = false;
        Console.WriteLine($"John did not reach: Altitude {altitudeReached + 1}");
        break;
    }
}

if (!reachedTop)
{
    Console.WriteLine("John failed to reach the top.");
    if (altitudeReached == 0)
    {
        Console.WriteLine("John didn't reach any altitude.");
    }
    else
    {
        Console.Write("Reached altitudes: ");
        for (int i = 1; i < altitudeReached; i++)
        {
            Console.Write($"Altitude {i}, ");
        }
        Console.Write($"Altitude {altitudeReached}");
    }
}
else
{
    Console.WriteLine("John has reached all the altitudes and managed to reach the top!");
}

