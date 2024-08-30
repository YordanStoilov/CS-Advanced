
int[] dimensions = Console.ReadLine().Split().Select(int.Parse).ToArray();
int rows = dimensions[0], cols = dimensions[1];
string[,] matrix = new string[rows, cols];
int numberOfSquareMtx = 0;

for (int row = 0; row < rows; row++)
{
    string[] line = Console.ReadLine().Split();
    for (int col = 0; col < cols; col++)
    {
        matrix[row, col] = line[col];
    }
}

for (int row = 0; row < rows - 1; row++)
{
    for (int col = 0; col < cols - 1; col++)
    {
        string a = matrix[row, col], b = matrix[row, col + 1];
        string c = matrix[row + 1, col], d = matrix[row + 1, col + 1];
        if (new string[] { a, b, c, d }.Distinct().Count() == 1)
        {
            numberOfSquareMtx++;
        }
    }
}
Console.WriteLine(numberOfSquareMtx);