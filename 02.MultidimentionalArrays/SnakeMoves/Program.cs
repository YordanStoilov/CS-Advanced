
int[] coordinates = Console.ReadLine()
.Split(" ", StringSplitOptions.RemoveEmptyEntries)
.Select(int.Parse).ToArray();

int rows = coordinates[0], cols = coordinates[1];
char[] text = Console.ReadLine().ToCharArray();
char[,] matrix = new char[rows, cols];

int charIndex = 0;

for (int row = 0; row < rows; row++)
{
    int start; int end; int increase; int type;

    if (row % 2 == 0)
    {
        start = 0; end = cols - 1; increase = 1; type = 0;
    }
    else
    {
        start = cols - 1; end = 0; increase = -1; type = 1;
    }
    for (int col = start; Condition(type, col, cols); col += increase)
    {
        matrix[row, col] = text[charIndex++ % text.Length];
    }
}
for (int row = 0; row < rows; row++)
{
    char[] line = new char[cols];
    for (int col = 0; col < cols; col++)
    {
        line[col] = matrix[row, col];
    }
    Console.WriteLine(string.Join("", line));
}

bool Condition(int type, int a, int b)
{
    if (type == 0)
    {
        return a < b;
    }
    else
    {
        return a >= 0;
    }
}