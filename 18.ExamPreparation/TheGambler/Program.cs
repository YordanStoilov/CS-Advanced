

using System.Text;

int rows = int.Parse(Console.ReadLine());
char[,] matrix = new char[rows, rows];

int[] player = new int[2];
int money = 100;
bool jackpot = false;

for (int row = 0; row < rows; row++)
{
    char[] line = Console.ReadLine().ToCharArray();
    for (int col = 0; col < rows; col++)
    {
        if (line[col] == 'G')
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

while (true)
{
    if (money <= 0)
    {
        Console.WriteLine("Game over! You lost everything!");
        return;
    }
    string direction = Console.ReadLine();
    int[] initial = new int[2] { player[0], player[1] };
    if (direction == "end")
    {
        break;
    }

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
        Console.WriteLine("Game over! You lost everything!");
        return;
    }

    char nextPosition = matrix[player[0], player[1]];
    matrix[player[0], player[1]] = '-';

    if (nextPosition == 'W')
    {
        money += 100;
    }
    else if (nextPosition == 'P')
    {
        money -= 200;
    }
    else if (nextPosition == 'J')
    {
        jackpot = true;
        money += 100000;
        break;
    }
}

if (jackpot)
{
    Console.WriteLine("You win the Jackpot!");
}

if (money > 0)
{
    Console.WriteLine($"End of the game. Total amount: {money}$");
}
else if (money <= 0)
{
    Console.WriteLine($"End of the game. Total amount: {money}$");
}

for (int row = 0; row < rows; row++)
{
    StringBuilder sb = new StringBuilder();

    for (int col = 0; col < rows; col++)
    {
        if (row == player[0] && col == player[1])
        {
            sb.Append("G");
        }
        else
        {
            sb.Append(matrix[row, col]);
        }
    }
    Console.WriteLine(sb.ToString().Trim());
}