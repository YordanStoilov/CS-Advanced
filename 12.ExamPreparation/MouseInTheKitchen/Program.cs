

string[] dimensions = Console.ReadLine().Split(",", StringSplitOptions.RemoveEmptyEntries);
int rows = int.Parse(dimensions[0]), cols = int.Parse(dimensions[1]);

int[,] matrix = new int[rows, cols];
int mouseRow = 0;
int mouseCol = 0;

int totalCheese = 0;
int cheeseEaten = 0;

for (int row = 0; row < rows; row++)
{
    string line = Console.ReadLine();

    for (int col = 0; col < line.Length; col++)
    {
        matrix[row, col] = line[col];
        if (matrix[row, col] == 'M')
        {
            mouseRow = row;
            mouseCol = col;
        }
        else if (matrix[row, col] == 'C')
        {
            totalCheese++;
        }
    }
}


while (true)
{
    string command = Console.ReadLine();
    if (command == "danger")
    {
        Console.WriteLine("Mouse will come back later!");
        break;
    }

    int[] nextPosition = new int[] { mouseRow, mouseCol };

    switch (command)
    {
        default:
            break;

        case "up":
            nextPosition[0]--;
            break;

        case "down":
            nextPosition[0]++;
            break;

        case "left":
            nextPosition[1]--;
            break;

        case "right":
            nextPosition[1]++;
            break;
    }

    if (nextPosition[0] < 0 || nextPosition[0] >= rows ||  nextPosition[1] < 0 || nextPosition[1] >= cols)
    {
        Console.WriteLine("No more cheese for tonight!");
        break;
    }

    char nextChar = (char)matrix[nextPosition[0], nextPosition[1]];

    if (nextChar == '@')
    {
        continue;
    }

    matrix[mouseRow, mouseCol] = '*';
    mouseRow = nextPosition[0]; mouseCol = nextPosition[1];
    matrix[mouseRow, mouseCol] = 'M';

    if (nextChar == 'C')
    {
        cheeseEaten++;
    }
    else if (nextChar == 'T')
    {
        Console.WriteLine("Mouse is trapped!");
        break;
    }

    if (cheeseEaten >= totalCheese)
    {
        Console.WriteLine("Happy mouse! All the cheese is eaten, good night!");
        break;
    }
}

for (int row = 0; row < rows; row++)
{
    for (int col = 0; col < cols; col++)
    {
        Console.Write((char)matrix[row, col]);
    }
    Console.WriteLine();
}