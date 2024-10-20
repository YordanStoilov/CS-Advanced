

using System.Numerics;
using System.Text;

int[] dimensions = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
int rows = dimensions[0];
int cols = dimensions[1];

int[] player = new int[2];
char[,] matrix = new char[rows, cols];

int time = 16;
int timeNeeded = 0;
bool blewUp = false;
bool defused = false;
bool terroristsWin = false;



for (int row = 0; row < rows; row++)
{
    char[] line = Console.ReadLine().ToCharArray();
    for (int col = 0; col < cols; col++)
    {
        if (line[col] == 'C')
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

int[] initPlayer = new int[2] { player[0], player[1] };

while (true)
{
    time--;
    if (time == 0)
    {
        blewUp = true;
        break;
    }
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
    if (direction == "defuse")
    {
        if (matrix[initial[0], initial[1]] == 'B')
        {
            if (time >= 3)
            {
                matrix[initial[0], initial[1]] = 'D';
                time -= 3;
                defused = true;
                break;
            }
            else
            {
                matrix[initial[0], initial[1]] = 'X';
                timeNeeded = 3 - time;
                blewUp = true;
                break;
            }
        }
        else
        {
            time--;
            continue;
        }
    }
    if (player[0] < 0 || player[1] < 0 || player[0] >= rows || player[1] >= cols)
    {
        player[0] = initial[0]; player[1] = initial[1];
        continue;
    }

    char nextPosition = matrix[player[0], player[1]];

    if (nextPosition == 'T')
    {
        terroristsWin = true;
        matrix[player[0], player[1]] = '*';
        break;
    }
}


if (blewUp)
{
    Console.WriteLine("Terrorists win!");
    Console.WriteLine("Bomb was not defused successfully!");
    Console.WriteLine($"Time needed: {timeNeeded} second/s.");
}
else if (defused)
{
    Console.WriteLine("Counter-terrorist wins!");
    Console.WriteLine($"Bomb has been defused: {time} second/s remaining.");
}
else if (terroristsWin)
{
    Console.WriteLine("Terrorists win!");
}

for (int row = 0; row < rows; row++)
{
    StringBuilder sb = new StringBuilder();

    for (int col = 0; col < cols; col++)
    {
        if (row == initPlayer[0] && col == initPlayer[1])
        {
            sb.Append('C');
        }
        else
        {
            sb.Append(matrix[row, col]);
        }
    }
    Console.WriteLine(sb.ToString().Trim());
}