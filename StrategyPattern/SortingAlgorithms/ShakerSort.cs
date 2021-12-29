namespace StrategyPattern.SortingAlgorithms;

public class ShakerSort : ISortAlgorithm
{
    public void ExecuteAlgorithm<T>(IList<T> array) where T : ISpanFormattable, IComparable
    {
        for (var i = 0; i < array.Count / 2; i++)
        {
            var swapFlag = false;

            for (var j = i; j < array.Count - i - 1; j++)
            {
                if (array[j].CompareTo(array[j + 1]) != 1) continue;
                array.Swap(j, j + 1);
                swapFlag = true;
            }

            for (var j = array.Count - 2 - i; j > i; j--)
            {
                if (array[j - 1].CompareTo(array[j]) != 1) continue;
                array.Swap(j - 1, j);
                swapFlag = true;
            }

            if (!swapFlag) break;
        }
    }
}

