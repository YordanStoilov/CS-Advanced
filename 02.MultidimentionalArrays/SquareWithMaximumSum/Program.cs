
int[] coordinates = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
int rows = coordinates[0], cols = coordinates[1];
int[,] matrix = new int[rows, cols];

for (int row = 0; row < rows; row++)
{
    int[] line = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
    for (int col = 0; col < cols; col++)
    {
        matrix[row, col] = line[col];
    }
}

int maxValue = int.MinValue;
int[] bestCoordinatesRow = new int[2];
int[] bestCoordinatesCol = new int[2];

//[r,c]

for (int row = 0; row < rows - 1; row++)
{
    for (int col = 0; col < cols - 1; col++)
    {
        int a = matrix[row, col]; int b = matrix[row, col + 1];
        int c = matrix[row + 1, col]; int d = matrix[row + 1, col + 1];
        int sum = new int[] { a, b, c, d }.Sum();

        if (sum > maxValue)
        {
            maxValue = sum;
            bestCoordinatesRow = new int[] { a, b };
            bestCoordinatesCol = new int[] { c, d };
        }
    }
}


Console.WriteLine(string.Join(" ", bestCoordinatesRow));
Console.WriteLine(string.Join(" ", bestCoordinatesCol));
Console.WriteLine(maxValue);