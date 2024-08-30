
int[] dimensions = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
int rows = dimensions[0], cols = dimensions[1];
int[,] matrix = new int[rows, cols];
int sum = 0;

for (int row = 0; row < rows; row++)
{
    int[] line = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
    for (int col = 0; col < cols; col++)
    {
        matrix[row, col] = line[col];
    }
}

foreach (int num in matrix)
{
    sum += num;
}
Console.WriteLine(matrix.GetLength(0));
Console.WriteLine(matrix.GetLength(1));
Console.WriteLine(sum);