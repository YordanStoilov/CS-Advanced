

int[] array = Console.ReadLine().Split(" ",
    StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

MergeSort(array);

Console.WriteLine(string.Join(" ", array));


void MergeSort(int[] array)
{
    if (array.Length <= 1)
        return;

    int mid = array.Length / 2;
    int[] left = new int[mid];
    int[] right = new int[array.Length - mid];

    Array.Copy(array, 0, left, 0, mid);
    Array.Copy(array, mid, right, 0, array.Length - mid);

    MergeSort(left);
    MergeSort(right);

    Merge(array, left, right);
}

void Merge(int[] array, int[] left, int[] right)
{
    int leftIndex = 0, rightIndex = 0, mergedIndex = 0;

    while (leftIndex < left.Length && rightIndex < right.Length)
    {
        if (left[leftIndex] <= right[rightIndex])
        {
            array[mergedIndex] = left[leftIndex];
            leftIndex++;
        }
        else
        {
            array[mergedIndex] = right[rightIndex];
            rightIndex++;
        }
        mergedIndex++;
    }

    while (leftIndex < left.Length)
    {
        array[mergedIndex] = left[leftIndex];
        leftIndex++;
        mergedIndex++;
    }

    while (rightIndex < right.Length)
    {
        array[mergedIndex] = right[rightIndex];
        rightIndex++;
        mergedIndex++;
    }
}



