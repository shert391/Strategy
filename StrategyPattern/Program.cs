int[] dataOne = new int[2] {10, 2};

Sorter sorter = new Sorter(new DefaultNetSort());

sorter.Sort(dataOne);

Console.WriteLine(string.Join(" ", dataOne));