
int rows = int.Parse(Console.ReadLine());
int[][] matrix = new int[rows][];

for (int i = 0; i < rows; i++)
{
    matrix[i] = Console.ReadLine().Split().Select(int.Parse).ToArray();
}

while (true)
{
    string input = Console.ReadLine();
    if (input == "END")
    {
        break;
    }
    string[] split = input.Split();
    string command = split[0];
    int row = int.Parse(split[1]), col = int.Parse(split[2]);
    int value = int.Parse(split[3]);

    try
    {
        if (command == "Subtract")
        {
            value = -value;
        }
        matrix[row][col] += value;
    }
    catch
    {
        Console.WriteLine("Invalid coordinates");
    }
}

foreach (int[] array in matrix)
{
    Console.WriteLine(string.Join(" ", array));
}