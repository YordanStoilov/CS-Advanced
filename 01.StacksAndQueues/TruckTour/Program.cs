
int n = int.Parse(Console.ReadLine());
Queue<int[]> stations = new();
int fuel = 0;

for (int i = 0; i < n; i++)
{
    int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
    stations.Enqueue(new int[] { input[0], input[1] });
}

int[][] copy = stations.ToArray();
int position = 0;

while (true)
{
    foreach (int[] element in stations)
    {
        int litres = element[0], distance = element[1];
        fuel += litres - distance;

        if (fuel < 0)
        {
            position++;
            stations.Enqueue(stations.Dequeue());
            break;
        }
    }
    if (fuel >= 0)
    {
        Console.WriteLine(position);
        break;
    }
    fuel = 0;
}
