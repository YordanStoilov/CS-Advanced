
Queue<string> names = new Queue<string>(Console.ReadLine().Split());
int n = int.Parse(Console.ReadLine());

int turn = 1;

while (names.Count != 1)
{
    string currentName = names.Dequeue();
    if (turn % n == 0)
    {
        Console.WriteLine($"Removed {currentName}");
    }
    else
    {
        names.Enqueue(currentName);
    }
    turn++;
}
Console.WriteLine($"Last is {names.Dequeue()}");