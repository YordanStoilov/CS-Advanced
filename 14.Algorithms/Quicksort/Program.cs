

List<int> array = Console.ReadLine().Split(" ", StringSplitOptions
    .RemoveEmptyEntries).Select(int.Parse).ToList();

Console.WriteLine(string.Join(" ", QuickSort(array)));

List<int> QuickSort(List<int> array)
{

    List<int> left = new();
    List<int> right = new();
    List<int> equal = new();

    if (array.Count <= 1)
    {
        return array;
    }

    int pivot = array[array.Count / 2];

    for (int i = 0; i < array.Count; i++)
    {
        if (array[i] < pivot)
        {
            left.Add(array[i]);
        }
        else if (array[i] > pivot)
        {
            right.Add(array[i]);
        }
        else
        {
            equal.Add(array[i]);
        }
    }

    List<int> sortedLeft = QuickSort(left);
    List<int> sortedRight = QuickSort(right);

    return sortedLeft.Concat(equal).Concat(sortedRight).ToList();
}