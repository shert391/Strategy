namespace StrategyPattern;

[RankColumn()]
public class MySortBenchmark
{
    private int[] _testData;

    [Params(1000)]
    public int Number;

    [GlobalSetup]
    public void Initialization()
    {
        var random = new Random();
        _testData = new int[Number];
        for (var i = 0; i < _testData.Length; i++)
            _testData[i] = random.Next(1, 1000);
    }

    private void Sort(ISortAlgorithm sortingStrategy, int[] array)
    {
        var sorter = new Sorter(sortingStrategy);
        sorter.Sort(array);
    }

    [Benchmark]
    public void TestBubbleSort() => Sort(new BubbleSort(), _testData);

    [Benchmark]
    public void TestDefaultNetSort() => Sort(new DefaultNetSort(), _testData);

    [Benchmark]
    public void TestInsertionSort() => Sort(new InsertionSort(), _testData);

    [Benchmark]
    public void TestShakerSort() => Sort(new ShakerSort(), _testData);

    [Benchmark]
    public void TestShellSort() => Sort(new ShellSort(), _testData);
}