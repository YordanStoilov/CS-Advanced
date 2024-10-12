
namespace CustomComparator;

public class Program
{
    static void Main(string[] args)
    {
        int[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse).ToArray();

        Array.Sort(numbers, new NumbersComparator());

        Console.WriteLine(string.Join(" ", numbers));
    }
}