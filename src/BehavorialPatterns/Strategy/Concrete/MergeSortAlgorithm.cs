using Strategy.Interface;

namespace Strategy.Concrete;

// Concrete strategy C
public class MergeSortAlgorithm : IAlghorithmSort
{
    public void Sort(int[] numbers)
    {
        Console.WriteLine($"Before MergeSort implementation:");

        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }

        Console.WriteLine("After MergeSort implementation:");

        MergeSort(numbers);

        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }

    private static void Merge(int[] arr, int[] left, int[] right)
    {
        int i = 0, j = 0, k = 0;

        while (i < left.Length && j < right.Length)
        {
            if (left[i] <= right[j])
            {
                arr[k++] = left[i++];
            }
            else
            {
                arr[k++] = right[j++];
            }
        }

        while (i < left.Length)
        {
            arr[k++] = left[i++];
        }

        while (j < right.Length)
        {
            arr[k++] = right[j++];
        }
    }

    public static void MergeSort(int[] arr)
    {
        if (arr.Length <= 1)
        {
            return;
        }

        int mid = arr.Length / 2;

        int[] left = new int[mid];
        int[] right = new int[arr.Length - mid];

        for (int i = 0; i < mid; i++)
        {
            left[i] = arr[i];
        }

        for (int i = mid; i < arr.Length; i++)
        {
            right[i - mid] = arr[i];
        }

        MergeSort(left);
        MergeSort(right);

        Merge(arr, left, right);
    }
}