
int n = int.Parse(Console.ReadLine());
int mainDiagonalSum = 0;
int secondaryDiagonalSum = 0;

for (int row = 0; row < n; row++)
{
    string[] line = Console.ReadLine().Split();
    for (int col = 0; col < n; col++)
    {
        if (row == col)
        {
            mainDiagonalSum += int.Parse(line[col]);
        }
        if (col == n - 1 - row)
        {
            secondaryDiagonalSum += int.Parse(line[col]);
        }
    }
}
Console.WriteLine(Math.Abs(mainDiagonalSum - secondaryDiagonalSum));