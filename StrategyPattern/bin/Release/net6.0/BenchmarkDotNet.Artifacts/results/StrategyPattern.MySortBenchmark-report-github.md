``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19043.1415 (21H1/May2021Update)
Intel Core i5-3470 CPU 3.20GHz (Ivy Bridge), 1 CPU, 4 logical and 4 physical cores
.NET SDK=6.0.101
  [Host]     : .NET 6.0.1 (6.0.121.56705), X64 RyuJIT
  DefaultJob : .NET 6.0.1 (6.0.121.56705), X64 RyuJIT


```
|             Method | Number |         Mean |      Error |     StdDev | Rank |
|------------------- |------- |-------------:|-----------:|-----------:|-----:|
|     TestBubbleSort |   1000 | 11,536.22 μs | 228.535 μs | 297.160 μs |    5 |
| TestDefaultNetSort |   1000 |    220.47 μs |   3.483 μs |   3.258 μs |    4 |
|  TestInsertionSort |   1000 |     26.69 μs |   0.380 μs |   0.355 μs |    1 |
|     TestShakerSort |   1000 |     43.98 μs |   0.855 μs |   0.800 μs |    2 |
|      TestShellSort |   1000 |    182.49 μs |   1.486 μs |   1.318 μs |    3 |
