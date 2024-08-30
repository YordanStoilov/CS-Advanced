
Queue<string> queue = new Queue<string>();

while (true)
{
    string command = Console.ReadLine();
    if (command == "Paid")
    {
        while (queue.Count != 0)
        {
            Console.WriteLine(queue.Dequeue());
        }
    }
    else if (command == "End")
    {
        break;
    }
    else
    {
        queue.Enqueue(command);
    }
}

Console.WriteLine($"{queue.Count} people remaining.");