

int[] array = Console.ReadLine().Split(" ",
    StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

MergeSort(array);

Console.WriteLine(string.Join(" ", array));


void MergeSort(int[] arr)
{
    if (arr.Length <= 1)
        return;

    int mid = arr.Length / 2;
    int[] left = new int[mid];
    int[] right = new int[arr.Length - mid];

    Array.Copy(arr, 0, left, 0, mid);
    Array.Copy(arr, mid, right, 0, arr.Length - mid);

    MergeSort(left);
    MergeSort(right);

    Merge(arr, left, right);
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



