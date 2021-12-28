namespace StrategyPattern.SortingAlgorithms;

public class BubbleSort : ISortAlgorithm
{
    public void ExecuteAlgorithm<T>(IList<T> array) where T : ISpanFormattable, IComparable
    {
        for (var i = 1; i < array.Count; i++)
            for (var j = 0; j < array.Count - i; j++)
                if (array[j].CompareTo(array[j + 1]) == 1)
                    array.Swap(j, j + 1);
    }
}