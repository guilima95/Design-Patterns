using Strategy.Interface;

namespace Strategy.Concrete;

// Concrete strategy B
public class ShellSortAlgorithm : IAlghorithmSort
{
    public void Sort(int[] numbers)
    {

        Console.WriteLine($"Before ShellSort implementation:");

        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }

        Console.WriteLine("After ShellSort implementation:");

        ShellSort(numbers);

        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }

    private static int[] ShellSort(int[] numbers)
    {
        // distance between elements that are compared
        int distance = numbers.Length / 2;
        while (distance >= 1)
        {
            for (int i = distance; i < numbers.Length; i++)
            {
                int j = i;
                while ((j >= distance) && (numbers[j - distance] > numbers[j]))
                {
                    Swap(ref numbers[j], ref numbers[j - distance]);
                    j = j - distance;
                }
            }

            distance = distance / 2;
        }

        return numbers;
    }

    private static void Swap(ref int a, ref int b)
    {
        (b, a) = (a, b);
    }
}
