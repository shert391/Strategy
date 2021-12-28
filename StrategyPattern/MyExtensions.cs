namespace StrategyPattern;

public static class MyExtensions
{
    public static void Swap<T>(this IList<T> array, int a, int b)
    {
        (array[a], array[b]) = (array[b], array[a]);
    }

    public static void Sort<T>(this IList<T> array)
    {
        ArrayList.Adapter((IList)array).Sort();
    }

}