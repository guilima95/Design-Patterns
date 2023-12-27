using Strategy.Concrete;
using Strategy.Service;

namespace Strategy;

internal class Program
{
    static void Main(string[] args)
    {
        SortedList context;

        List<int> numbers = [5, 7, 2, 6, 4, 1, 8, 3];

        // Three contexts following different strategies
        context = new SortedList(numbers, new QuickSortAlgorithm());
        context.Sort();

        context = new SortedList(numbers, new MergeSortAlgorithm());
        context.Sort();

        context = new SortedList(numbers, new ShellSortAlgorithm());
        context.Sort();


        // Wait for user
        Console.ReadKey();
    }
}
