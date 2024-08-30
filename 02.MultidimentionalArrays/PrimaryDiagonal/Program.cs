
int rows = int.Parse(Console.ReadLine());
int sum = 0;

for (int row = 0; row < rows; row++)
{
    int[] line = Console.ReadLine().Split().Select(int.Parse).ToArray();
    for (int col = 0; col < rows; col++)
    {
        if (row == col)
        {
            sum += line[col];
        }
    }
}
Console.WriteLine(sum);