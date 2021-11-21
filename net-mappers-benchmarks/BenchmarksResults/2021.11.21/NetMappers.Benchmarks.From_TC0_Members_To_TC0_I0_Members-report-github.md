``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19043.1348 (21H1/May2021Update)
11th Gen Intel Core i5-1135G7 2.40GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.100
  [Host] : .NET 6.0.0 (6.0.21.52210), X64 RyuJIT

Job=InProcess  Toolchain=InProcessEmitToolchain  

```
|           Method |        Mean |     Error |    StdDev |      Median |
|----------------- |------------:|----------:|----------:|------------:|
| ExpressMapperMap |    85.63 ns |  0.243 ns |  0.215 ns |    85.60 ns |
|   AgileMapperMap |   157.64 ns |  7.433 ns | 21.917 ns |   141.63 ns |
|    TinyMapperMap |    34.96 ns |  0.730 ns |  1.475 ns |    34.72 ns |
|    AutoMapperMap |    81.30 ns |  1.513 ns |  2.487 ns |    80.41 ns |
|       MapsterMap |    32.88 ns |  0.450 ns |  0.421 ns |    32.70 ns |
| StaticsMapperMap |    14.97 ns |  0.348 ns |  0.440 ns |    14.88 ns |
|    FastMapperMap |   274.85 ns |  3.950 ns |  3.299 ns |   274.46 ns |
| ValueInjecterMap | 3,243.46 ns | 57.478 ns | 50.953 ns | 3,269.24 ns |
