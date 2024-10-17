

int rows = int.Parse(Console.ReadLine());
char[,] matrix = new char[rows, rows];

int[] bee = new int[2];
int beeEnergy = 15;
int nectar = 0;

for (int row =0; row < rows; row++)
{
    char[] line = Console.ReadLine().ToCharArray();

    for (int col = 0; col < rows; col++)
    {
        matrix[row, col] = line[col];
        if (line[col] == 'B')
        {
            bee[0] = row; bee[1] = col;
        }
    }
}
while (beeEnergy > 0)
{
    matrix[bee[0], bee[1]] = '-';
    string direction = Console.ReadLine();

    switch (direction)
    {
        default:
            break;

        case "up":
            bee[0]--;
            if (bee[0] < 0)
            {
                bee[0] = rows - 1;
            }
            break;

        case "down":
            bee[0]++;
            if (bee[0] > rows - 1)
            {
                bee[0] = 0;
            }
            break;

        case "left":
            bee[1]--;
            if (bee[1] < 0)
            {
                bee[1] = rows - 1;
            }
            break;

        case "right":
            bee[1]++;
            if (bee[1] > rows - 1)
            {
                bee[1] = 0;
            }
            break;
    }

    beeEnergy--;
    char nextSymbol = matrix[bee[0], bee[1]];
    matrix[bee[0], bee[1]] = 'B';


    if (nextSymbol == 'H')
    {
        if (nectar < 30)
        {
            Console.WriteLine("Beesy did not manage to collect enough nectar.");
            PrintMatrix(matrix);
            return;
        }
        else
        {
            Console.WriteLine($"Great job, Beesy! The hive is full. Energy left: {beeEnergy}");
            PrintMatrix(matrix);
            return;
        }
    }
    else if (nextSymbol != '-')
    {
        nectar += int.Parse(nextSymbol.ToString());
    }

    if (beeEnergy <= 0)
    {
        beeEnergy += Math.Max(0, nectar - 30);
        nectar = Math.Min(nectar, 30);
    }
}
Console.WriteLine("This is the end! Beesy ran out of energy.");
PrintMatrix(matrix);

void PrintMatrix(char[,] matrix)
{
    for (int row = 0; row < rows; row++)
    {
        for (int col = 0; col < rows; col++)
        {
            Console.Write(matrix[row, col]);
        }
        Console.WriteLine();
    }
}