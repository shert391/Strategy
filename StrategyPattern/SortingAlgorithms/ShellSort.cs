namespace StrategyPattern.SortingAlgorithms;

public class ShellSort : ISortAlgorithm
{
    public void ExecuteAlgorithm<T>(IList<T> array) where T : ISpanFormattable, IComparable
    {
        var step = array.Count / 2;
        while (step > 0)
        {
            int i;
            for (i = step; i < array.Count; i++)
            {
                var value = array[i];
                int j;
                for (j = i - step; (j >= 0) && (array[j].CompareTo(value) == 1); j -= step)
                    array[j + step] = array[j];
                array[j + step] = value;
            }
            step /= 2;
        }
    }
}