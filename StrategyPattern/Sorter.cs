namespace StrategyPattern;

public class Sorter
{
    private ISortAlgorithm _sortingStrategy;

    public Sorter(ISortAlgorithm sortingStrategy)
    {
        _sortingStrategy = sortingStrategy;
    }

    public void Sort<T>(IList<T> array) where T: ISpanFormattable, IComparable
    {
        _sortingStrategy.ExecuteAlgorithm(array);
    }

}