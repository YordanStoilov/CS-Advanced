
int rows = int.Parse(Console.ReadLine());
int[][] matrix = new int[rows][];

for (int row = 0; row < rows; row++)
{
    int[] line = Console.ReadLine().Split().Select(int.Parse).ToArray();
    matrix[row] = line;
}

for (int row = 0; row < rows - 1; row++)
{
    if (matrix[row].Length == matrix[row + 1].Length)
    {
        matrix[row] = matrix[row].Select(x => x *= 2).ToArray();
        matrix[row + 1] = matrix[row + 1].Select(x => x *= 2).ToArray();
    }
    else
    {
        matrix[row] = matrix[row].Select(x => x /= 2).ToArray();
        matrix[row + 1] = matrix[row + 1].Select(x => x /= 2).ToArray();
    }
}

while (true)
{
    string command = Console.ReadLine();
    if (command.ToLower() == "end")
    {
        break;
    }
    string[] split = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    string action = split[0];
    int r = int.Parse(split[1]), c = int.Parse(split[2]), value = int.Parse(split[3]);

    if (r < rows && r >= 0 && c < matrix[r].Length && c >= 0)
    {
        if (action.ToLower() == "subtract")
        {
            matrix[r][c] -= value;
        }
        else if (action.ToLower() == "add")
        {
            matrix[r][c] += value;
        }
    }
}

foreach (int[] line in matrix)
{
    Console.WriteLine(string.Join(" ", line));
}