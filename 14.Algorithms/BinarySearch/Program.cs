
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

    int middleIndex = start + (end - start) / 2; ;
    int middleElement = array[middleIndex];

    if (middleElement == element)
    {
        return middleIndex;
    }
    else if (element > middleElement)
    {
        return BinarySearch(array, middleIndex + 1, end, element);
    }
    else
    {
        return BinarySearch(array, start, middleIndex - 1, element);
    }
}

