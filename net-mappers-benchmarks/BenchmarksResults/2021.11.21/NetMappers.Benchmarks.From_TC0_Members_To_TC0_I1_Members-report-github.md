``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19043.1348 (21H1/May2021Update)
11th Gen Intel Core i5-1135G7 2.40GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.100
  [Host] : .NET 6.0.0 (6.0.21.52210), X64 RyuJIT

Job=InProcess  Toolchain=InProcessEmitToolchain  

```
|           Method |        Mean |     Error |    StdDev |
|----------------- |------------:|----------:|----------:|
| ExpressMapperMap |   104.22 ns |  0.533 ns |  0.472 ns |
|   AgileMapperMap |   198.69 ns |  4.003 ns |  3.549 ns |
|    TinyMapperMap |    85.37 ns |  0.922 ns |  0.863 ns |
|    AutoMapperMap |    82.46 ns |  1.312 ns |  1.095 ns |
|       MapsterMap |    39.09 ns |  0.699 ns |  0.620 ns |
| StaticsMapperMap |    19.39 ns |  0.311 ns |  0.291 ns |
|    FastMapperMap |          NA |        NA |        NA |
| ValueInjecterMap | 4,352.35 ns | 74.296 ns | 58.005 ns |

Benchmarks with issues:
  From_TC0_Members_To_TC0_I1_Members.FastMapperMap: InProcess(Toolchain=InProcessEmitToolchain)
