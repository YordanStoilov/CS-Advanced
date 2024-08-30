
int n = int.Parse(Console.ReadLine());

char[,] board = new char[n, n];
for (int i = 0; i < n; i++)
{
    string line = Console.ReadLine();
    for (int j = 0; j < n; j++)
    {
        board[i, j] = line[j];
    }
}

int[,] moves = new int[,]
{
            { -2, -1 }, { -2, 1 }, { -1, -2 }, { -1, 2 },
            { 1, -2 }, { 1, 2 }, { 2, -1 }, { 2, 1 }
};

int removedKnights = 0;

while (true)
{
    int maxAttacks = 0;
    int knightRow = -1;
    int knightCol = -1;

    for (int row = 0; row < n; row++)
    {
        for (int col = 0; col < n; col++)
        {
            if (board[row, col] == 'K')
            {
                int attacks = 0;

                for (int i = 0; i < 8; i++)
                {
                    int newRow = row + moves[i, 0];
                    int newCol = col + moves[i, 1];

                    if (IsInsideBoard(newRow, newCol, n) && board[newRow, newCol] == 'K')
                    {
                        attacks++;
                    }
                }

                if (attacks > maxAttacks)
                {
                    maxAttacks = attacks;
                    knightRow = row;
                    knightCol = col;
                }
            }
        }
    }

    if (maxAttacks == 0)
    {
        break;
    }

    board[knightRow, knightCol] = '0';
    removedKnights++;
}

Console.WriteLine(removedKnights);

bool IsInsideBoard(int row, int col, int n)
{
    return row >= 0 && row < n && col >= 0 && col < n;
}

