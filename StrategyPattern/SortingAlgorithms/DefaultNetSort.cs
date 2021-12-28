namespace StrategyPattern.SortingAlgorithms;

public class DefaultNetSort : ISortAlgorithm
{
    public void ExecuteAlgorithm<T>(IList<T> array) where T : ISpanFormattable, IComparable
    {
        array.Sort();
    }
}