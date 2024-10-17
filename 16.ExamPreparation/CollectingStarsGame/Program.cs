

using System.Text;

int rows = int.Parse(Console.ReadLine());

string[,] matrix = new string[rows, rows];
int[] player = new int[2];

int starsCollected = 2;

for (int row = 0; row < rows; row++)
{
    string[] line = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
    for (int col = 0; col < rows; col++)
    {
        matrix[row, col] = line[col];
        if (matrix[row, col] == "P")
        {
            player[0] = row;
            player[1] = col;

            matrix[row, col] = ".";
        }
    }
}

while (starsCollected < 10 && starsCollected > 0)
{
    string direction = Console.ReadLine();
    int[] initialPos = new int[2] { player[0], player[1] };

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
        player[0] = 0; player[1] = 0;
    }

    string nextPosition = matrix[player[0], player[1]];

    if (nextPosition == "#")
    {
        starsCollected--;
        player[0] = initialPos[0]; player[1] = initialPos[1];
        continue;
    }
    if (nextPosition == "*")
    {
        starsCollected++;
    }
    matrix[player[0], player[1]] = ".";
}

if (starsCollected >= 10)
{
    Console.WriteLine("You won! You have collected 10 stars.");
}
else
{
    Console.WriteLine("Game over! You are out of any stars.");
}
Console.WriteLine($"Your final position is [{player[0]}, {player[1]}]");

for (int row = 0; row < rows; row++)
{
    StringBuilder sb = new StringBuilder();

    for (int col = 0; col < rows; col++)
    {
        if (row == player[0] && col == player[1])
        {
            sb.Append("P ");
        }
        else
        {
            sb.Append(matrix[row, col] + " ");
        }
    }
    Console.WriteLine(string.Join(" ", sb.ToString().Trim()));
}
