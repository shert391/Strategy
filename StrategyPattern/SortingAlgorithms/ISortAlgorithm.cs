namespace StrategyPattern.SortingAlgorithms;

public interface ISortAlgorithm
{
    void ExecuteAlgorithm<T>(IList<T> array) where T : ISpanFormattable, IComparable;
}