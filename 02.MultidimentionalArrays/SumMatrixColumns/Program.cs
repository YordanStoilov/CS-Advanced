
int[] input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
int rows = input[0], cols = input[1];
int[] sum = new int[cols];

for (int row = 0; row < rows; row++)
{
    int[] line = Console.ReadLine().Split().Select(int.Parse).ToArray();
    for (int col = 0; col < cols; col++)
    {
        sum[col] += line[col];
    }
}
foreach (int num in sum)
{
    Console.WriteLine(num);
}

