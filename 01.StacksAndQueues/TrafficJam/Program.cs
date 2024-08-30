
int numberOfCars = int.Parse(Console.ReadLine());
Queue<string> queue = new Queue<string>();
int carsPassed = 0;

while (true)
{
    string command = Console.ReadLine();
    if (command == "end")
    {
        break;
    }
    else if (command == "green")
    {
        int end = Math.Min(numberOfCars, queue.Count);
        for (int i = 0; i < end; i++)
        {
            Console.WriteLine($"{queue.Dequeue()} passed!");
            carsPassed++;
        }
    }
    else
    {
        queue.Enqueue(command);
    }
}

Console.WriteLine($"{carsPassed} cars passed the crossroads.");