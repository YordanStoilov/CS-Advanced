
int[] coordinates = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
int rows = coordinates[0], cols = coordinates[1];
int[,] matrix = new int[rows, cols];
int biggestSum = int.MinValue;
int[,] bestMatrix = new int[3, 3];

for (int row = 0; row < rows; row++)
{
    int[] line = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
    for (int col = 0; col < cols; col++)
    {
        matrix[row, col] = line[col];
    }
}

for (int row = 0; row < rows - 2; row++)
{
    for (int col = 0; col < cols - 2; col++)
    {
        int a = matrix[row, col], b = matrix[row, col + 1], c = matrix[row, col + 2];
        int d = matrix[row + 1, col], e = matrix[row + 1, col + 1], f = matrix[row + 1, col + 2];
        int g = matrix[row + 2, col], h = matrix[row + 2, col + 1], i = matrix[row + 2, col + 2];
        int[] currentMtx = new int[] { a, b, c, d, e, f, g, h, i };

        int currentSum = currentMtx.Sum();
        if (currentSum > biggestSum)
        {
            biggestSum = currentSum;
            int idx = 0;
            for (int j = 0; j < 3; j++)
            {
                for (g = 0; g < 3; g++)
                {
                    bestMatrix[j, g] = currentMtx[idx++];
                }
            }
        }
    }
}
Console.WriteLine($"Sum = {biggestSum}");
for (int row = 0; row < 3; row++)
{
    int[] line = new int[3];
    for (int col = 0; col < 3; col++)
    {
        line[col] = bestMatrix[row, col];
    }
    Console.WriteLine(string.Join(" ", line));
}