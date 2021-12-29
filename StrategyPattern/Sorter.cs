namespace StrategyPattern;

public class Sorter
{
    public ISortAlgorithm SortingStrategy { get; set; }

    public Sorter(ISortAlgorithm sortingStrategy)
    {
        SortingStrategy = sortingStrategy;
    }

    public void Sort<T>(IList<T> array) where T: ISpanFormattable, IComparable
    {
        SortingStrategy.ExecuteAlgorithm(array);
    }
}