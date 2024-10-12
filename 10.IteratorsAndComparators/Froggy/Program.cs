namespace Froggy;

public class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = Console.ReadLine().Split(", ", 
            StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

        Lake newLake = new Lake(numbers);

        List<int> steps = new();

        foreach (int step in newLake)
        {
            steps.Add(step);
        }

        Console.WriteLine(string.Join(", ", steps));
    }
}