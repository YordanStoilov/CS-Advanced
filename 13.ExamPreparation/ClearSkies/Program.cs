

int rows = int.Parse(Console.ReadLine());
char[,] matrix = new char[rows, rows];

int[] coordinates = new int[2];

const int aircraftInitialHealth = 300;
const int battleDamage = 100;
int aircraftHealth = 300;

int enemyAircrafts = 0;


for (int row = 0; row < rows; row++)
{
    string line = Console.ReadLine();

    for (int col = 0; col < rows; col++)
    {
        char current = line[col];

        if (current == 'J')
        {
            coordinates[0] = row;
            coordinates[1] = col;
            current = '-';
        }
        else if (line[col] == 'E')
        {
            enemyAircrafts++;
        }

        matrix[row, col] = current;
    }
}

while (enemyAircrafts > 0 && aircraftHealth > 0)
{
    string command = Console.ReadLine();

    switch (command)
    {
        case "up":
            coordinates[0]--;
            break;

        case "down":
            coordinates[0]++;
            break;

        case "left":
            coordinates[1]--;
            break;

        case "right":
            coordinates[1]++;
            break;
    }

    char positionValue = matrix[coordinates[0], coordinates[1]];
    matrix[coordinates[0], coordinates[1]] = '-';


    if (positionValue == 'E')
    {
        enemyAircrafts--;
        aircraftHealth -= battleDamage;
    }
    else if (positionValue == 'R')
    {
        aircraftHealth = aircraftInitialHealth;
    }
}

matrix[coordinates[0], coordinates[1]] = 'J';

if (aircraftHealth <= 0)
{
    Console.WriteLine($"Mission failed, your jetfighter was shot down! Last coordinates [{coordinates[0]}, {coordinates[1]}]!");
}

if (enemyAircrafts <= 0)
{
    Console.WriteLine("Mission accomplished, you neutralized the aerial threat!");
}

for (int row = 0; row < rows; row++)
{
    for (int col = 0; col < rows; col++)
    {
        Console.Write(matrix[row, col]);
    }
    Console.WriteLine();
}