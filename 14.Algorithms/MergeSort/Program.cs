

int[] array = Console.ReadLine().Split(" ", 
    StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

MergeSort(array);

Console.WriteLine(string.Join(" ", array));


 void MergeSort(int[] array)
    {
        // Base case: if the array has 1 or 0 elements, it's already sorted.
        if (array.Length <= 1)
            return;

        // Split the array into two halves.
        int mid = array.Length / 2;
        int[] left = new int[mid];
        int[] right = new int[array.Length - mid];

        // Copy the left half elements into 'left' array.
        Array.Copy(array, 0, left, 0, mid);
        // Copy the right half elements into 'right' array.
        Array.Copy(array, mid, right, 0, array.Length - mid);

        // Recursively sort both halves.
        MergeSort(left);
        MergeSort(right);

        // Merge the sorted halves back into the original array.
        Merge(array, left, right);
    }

void Merge(int[] array, int[] left, int[] right)
    {
        int leftIndex = 0, rightIndex = 0, mergedIndex = 0;

        // Compare elements from 'left' and 'right' arrays and merge them in sorted order.
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

        // Copy any remaining elements from the 'left' array.
        while (leftIndex < left.Length)
        {
            array[mergedIndex] = left[leftIndex];
            leftIndex++;
            mergedIndex++;
        }

        // Copy any remaining elements from the 'right' array.
        while (rightIndex < right.Length)
        {
            array[mergedIndex] = right[rightIndex];
            rightIndex++;
            mergedIndex++;
        }
    }



