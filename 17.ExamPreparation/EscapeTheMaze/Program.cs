

using System.Numerics;
using System.Text;

int rows = int.Parse(Console.ReadLine());
char[,] matrix = new char[rows, rows];

int[] player = new int[2];
int health = 100;
bool won = false;

for (int row = 0; row < rows; row++)
{
    char[] line = Console.ReadLine().ToCharArray();
    for (int col = 0; col < rows; col++)
    {
        if (line[col] == 'P')
        {
            player[0] = row;
            player[1] = col;
            matrix[row, col] = '-';
        }
        else
        {
            matrix[row, col] = line[col];
        }
    }
}

while (!won)
{
    string direction = Console.ReadLine();
    int[] initial = new int[2] { player[0], player[1] };

    switch (direction)
    {
        default:
            break;
        case "up":
            player[0]--;
            break;
        case "down":
            player[0]++;
            break;
        case "left":
            player[1]--;
            break;
        case "right":
            player[1]++;
            break;
    }

    if (player[0] < 0 || player[1] < 0 || player[0] >= rows || player[1] >= rows)
    {
        player[0] = initial[0]; player[1] = initial[1];
        continue;
    }

    char nextPosition = matrix[player[0],player[1]];

    if (nextPosition == 'M')
    {
        health -= 40;
        if (health <= 0)
        {
            health = 0;
            break;
        }
    }
    else if (nextPosition == 'H')
    {
        health = Math.Min(100, health + 15);
    }
    else if (nextPosition == 'X')
    {
        won = true;
    }
    matrix[player[0], player[1]] = '-';
}

if (won)
{
    Console.WriteLine("Player escaped the maze. Danger passed!");
}
else
{
    Console.WriteLine("Player is dead. Maze over!");
}

Console.WriteLine($"Player's health: {health} units");

for (int row = 0; row < rows; row++)
{
    StringBuilder sb = new StringBuilder();

    for (int col = 0; col < rows; col++)
    {
        if (row == player[0] && col == player[1])
        {
            sb.Append("P");
        }
        else
        {
            sb.Append(matrix[row, col]);
        }
    }
    Console.WriteLine(sb.ToString().Trim());
}
