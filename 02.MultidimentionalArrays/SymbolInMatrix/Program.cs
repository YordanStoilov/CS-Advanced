
int n = int.Parse(Console.ReadLine());
char[,] matrix = new char[n, n];

for (int row = 0; row < n; row++)
{
    string line = Console.ReadLine();
    for (int col = 0; col < n; col++)
    {
        matrix[row, col] = line[col];
    }
}
char symbol = char.Parse(Console.ReadLine());

string FindCharInMatrix()
{
    for (int row = 0; row < n; row++)
    {
        for (int col = 0; col < n; col++)
        {
            if (matrix[row, col] == symbol)
            {
                return $"({row}, {col})";
            }
        }
    }
    return $"{symbol} does not occur in the matrix";
}

Console.WriteLine(FindCharInMatrix());