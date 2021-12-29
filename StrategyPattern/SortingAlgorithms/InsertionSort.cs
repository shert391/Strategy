namespace StrategyPattern.SortingAlgorithms;

public class InsertionSort : ISortAlgorithm
{
    public void ExecuteAlgorithm<T>(IList<T> array) where T : ISpanFormattable, IComparable
    {
        for (var i = 1; i < array.Count; i++)
        {
            var j = i;

            while (j > 0 && array[i].CompareTo(array[i - 1]) == -1)
            {
                array[j] = array[j - 1];
                j--;
            }

            array[j] = array[i];
        }
    }
}