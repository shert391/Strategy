int[] dataOne = new int[3] {10, 2, 3};

Sorter sorter = new Sorter(new DefaultNetSort());

sorter.Sort(dataOne);

Console.WriteLine(string.Join(" ", dataOne));