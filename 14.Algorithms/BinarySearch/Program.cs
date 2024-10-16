
int[] array = Console.ReadLine().Split(" ", 
    StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

int num = int.Parse(Console.ReadLine());

Console.WriteLine(BinarySearch(array, 0, array.Length - 1, num));

int BinarySearch(int[] array, int start, int end, int element)
{
    if (start > end)
    {
        return -1;
    }

    int middle = start + (end - start) / 2;
    int middleElement = array[middle];

    if (element == middleElement)
    {
        return middle;
    }
    else if (element > middleElement)
    {
        return BinarySearch(array, middle + 1, end, element);
    }
    else
    {
        return BinarySearch(array, start, middle - 1, element);
    }
}