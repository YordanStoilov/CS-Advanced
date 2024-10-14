

int rows = int.Parse(Console.ReadLine());
int[,] matrix = new int[rows, rows];

int userRow = 0;
int userCol = 0;

int fishCaught = 0;

for (int row = 0; row < rows; row++)
{
    string line = Console.ReadLine();

    for (int col = 0; col < line.Length; col++)
    {
        matrix[row, col] = line[col];
        if (line[col] == 'S')
        {
            userRow = row;
            userCol = col;
        }
    }
}

while (true)
{
    string command = Console.ReadLine();

    if (command == "collect the nets")
    {
        break;
    }

    matrix[userRow, userCol] = '-';

    switch (command)
    {
        case "up":
            userRow--;
            if (userRow < 0)
            {
                userRow = rows - 1;
            }
            break;
        case "down":
            userRow++;
            if (userRow >= rows)
            {
                userRow = 0;
            }
            break;
        case "left":
            userCol--;
            if (userCol < 0)
            {
                userCol = rows - 1;
            }
            break;
        case "right":
            userCol++;
            if (userCol >= rows)
            {
                userCol = 0;
            }
            break;
        default:
            break;
    }

    char nextPosition = (char)matrix[userRow, userCol];

    if (nextPosition != '-')
    {
        if (nextPosition == 'W')
        {
            Console.WriteLine($"You fell into a whirlpool! The ship sank and you lost the fish you caught. " +
                $"Last coordinates of the ship: [{userRow},{userCol}]");
            return;
        }
        else
        {
            fishCaught += int.Parse(nextPosition.ToString());
        }
    }

    matrix[userRow, userCol] = 'S';
}

if (fishCaught >= 20)
{
    Console.WriteLine("Success! You managed to reach the quota!");
}
else
{
    Console.WriteLine($"You didn't catch enough fish and didn't reach the quota! " +
        $"You need {20 - fishCaught} tons of fish more.");
}


if (fishCaught > 0)
{
    Console.WriteLine($"Amount of fish caught: {fishCaught} tons.");
}

for (int row = 0; row < rows; row++)
{
    for (int col = 0; col < rows; col++)
    {
        Console.Write((char)matrix[row, col]);
    }
    Console.WriteLine();
}
