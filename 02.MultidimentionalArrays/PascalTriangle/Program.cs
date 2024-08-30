
int n = int.Parse(Console.ReadLine());
long[][] matrix = new long[n][];
matrix[0] = new long[1] { 1 };

for (int row = 1; row < n; row++)
{
    matrix[row] = new long[row + 1];
    for (int col = 0; col < row + 1; col++)
    {
        if (col < row)
        {
            // upwards
            matrix[row][col] += matrix[row - 1][col];
        }
        if (col > 0)
        {
            //up and left
            matrix[row][col] += matrix[row - 1][col - 1];
        }
    }
}

foreach (long[] array in matrix)
{
    Console.WriteLine(string.Join(" ", array));
}