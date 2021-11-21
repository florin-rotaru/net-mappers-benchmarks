``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19043.1348 (21H1/May2021Update)
11th Gen Intel Core i5-1135G7 2.40GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.100
  [Host] : .NET 6.0.0 (6.0.21.52210), X64 RyuJIT

Job=InProcess  Toolchain=InProcessEmitToolchain  

```
|           Method |        Mean |     Error |     StdDev |
|----------------- |------------:|----------:|-----------:|
| ExpressMapperMap | 1,472.50 ns |  8.919 ns |   7.907 ns |
|   AgileMapperMap |   260.55 ns |  3.822 ns |   3.388 ns |
|    TinyMapperMap |          NA |        NA |         NA |
|    AutoMapperMap |   123.48 ns |  1.527 ns |   1.354 ns |
|       MapsterMap |    49.63 ns |  0.576 ns |   0.481 ns |
| StaticsMapperMap |    18.51 ns |  0.317 ns |   0.265 ns |
|    FastMapperMap |          NA |        NA |         NA |
| ValueInjecterMap | 3,565.94 ns | 69.939 ns | 102.516 ns |

Benchmarks with issues:
  From_TC0_Members_To_TS0_I0_Members.TinyMapperMap: InProcess(Toolchain=InProcessEmitToolchain)
  From_TC0_Members_To_TS0_I0_Members.FastMapperMap: InProcess(Toolchain=InProcessEmitToolchain)
