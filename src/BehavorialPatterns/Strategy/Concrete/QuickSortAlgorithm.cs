using Strategy.Interface;

namespace Strategy.Concrete;

// Concrete strategy A
public class QuickSortAlgorithm : IAlghorithmSort
{
    public void Sort(int[] numbers)
    {
        Console.WriteLine($"Before QuitSort implementation:");

        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }

        Console.WriteLine("After QuitSort implementation:");

        QuickSort(numbers, left: 0, right: numbers.Length - 1);

        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }

    private static void Swap(int[] numbers, int i, int j)
    {
        (numbers[j], numbers[i]) = (numbers[i], numbers[j]);
    }

    private static void QuickSort(int[] numbers, int left, int right)
    {
        int i = left;
        int j = right;

        int pivot = numbers[(left + right) / 2];

        while (i <= j)
        {
            while (numbers[i] < pivot)
            {
                i++;
            }

            while (numbers[j] > pivot)
            {
                j--;
            }

            if (i <= j)
            {
                Swap(numbers, i, j);
                i++;
                j--;
            }
        }

        if (left < j)
        {
            QuickSort(numbers, left, j);
        }


        if (i < right)
        {
            QuickSort(numbers, i, right);
        }
    }
}
