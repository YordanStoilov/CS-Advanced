
int[] coordinates = Console.ReadLine()
.Split(" ", StringSplitOptions.RemoveEmptyEntries)
.Select(int.Parse).ToArray();
int rows = coordinates[0], cols = coordinates[1];
string[,] matrix = new string[rows, cols];

for (int row = 0; row < rows; row++)
{
    string[] line = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
    for (int col = 0; col < cols; col++)
    {
        matrix[row, col] = line[col];
    }
}

while (true)
{
    string input = Console.ReadLine();
    if (input.ToLower() == "end")
    {
        break;
    }
    string[] split = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    string action = split[0];
    if (action != "swap" || split.Length != 5)
    {
        Console.WriteLine("Invalid input!");
        continue;
    }

    int row1 = int.Parse(split[1].ToString()), col1 = int.Parse(split[2].ToString());
    int row2 = int.Parse(split[3].ToString()), col2 = int.Parse(split[4].ToString());

    if (row1 < rows || row2 < rows || col1 < cols || col2 < cols)
    {
        (matrix[row1, col1], matrix[row2, col2]) = (matrix[row2, col2], matrix[row1, col1]);
        PrintMatrix();
    }
    else
    {
        Console.WriteLine("Invalid input!");
    }

}

void PrintMatrix()
{
    for (int row = 0; row < rows; row++)
    {
        string[] line = new string[cols];
        for (int col = 0; col < cols; col++)
        {
            line[col] = matrix[row, col];
        }
        Console.WriteLine(string.Join(" ", line));
    }
}