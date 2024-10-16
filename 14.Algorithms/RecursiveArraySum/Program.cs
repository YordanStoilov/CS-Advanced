

using System.Runtime.CompilerServices;

int[] nums = Console.ReadLine().Split(" ", 
    StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

int Sum(int[] array)
{
    if (array.Length == 1)
    {
        return array[0];
    }
    return array[0] + Sum(array.Skip(1).ToArray());
}

Console.WriteLine(Sum(nums));