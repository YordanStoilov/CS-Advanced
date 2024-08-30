
Stack<int> clothes = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
int rackCapacity = int.Parse(Console.ReadLine());
int racksUsed = 0;
int currentRack = 0;

while (true)
{
    if (clothes.Count <= 0)
    {
        break;
    }
    int currentClothing = clothes.Pop();
    if (currentRack + currentClothing > rackCapacity)
    {
        currentRack = 0;
        clothes.Push(currentClothing);
    }
    else if (currentRack + currentClothing < rackCapacity)
    {
        currentRack += currentClothing;
        if (clothes.Count <= 0)
        {
            racksUsed++;
        }
        continue;
    }
    else
    {
        currentRack = 0;
    }
    racksUsed++;
}
Console.WriteLine(racksUsed);
