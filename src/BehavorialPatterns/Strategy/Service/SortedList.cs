using Strategy.Interface;

namespace Strategy.Service;

// Context concrete
public class SortedList(List<int> numbers, IAlghorithmSort alghorithm)
{
    private readonly IAlghorithmSort _alghorithm = alghorithm;

    public void Sort()
    {
        _alghorithm.Sort([.. numbers]); // ToArray() in collection expressions
    }
}
