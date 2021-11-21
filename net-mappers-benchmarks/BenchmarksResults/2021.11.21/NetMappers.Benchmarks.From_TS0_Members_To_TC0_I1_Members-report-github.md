``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19043.1348 (21H1/May2021Update)
11th Gen Intel Core i5-1135G7 2.40GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.100
  [Host] : .NET 6.0.0 (6.0.21.52210), X64 RyuJIT

Job=InProcess  Toolchain=InProcessEmitToolchain  

```
|           Method |        Mean |     Error |    StdDev |      Median |
|----------------- |------------:|----------:|----------:|------------:|
| ExpressMapperMap |   487.11 ns |  9.301 ns |  8.700 ns |   488.80 ns |
|   AgileMapperMap |   317.61 ns |  1.957 ns |  1.831 ns |   317.52 ns |
|    TinyMapperMap |          NA |        NA |        NA |          NA |
|    AutoMapperMap |   282.09 ns |  5.436 ns |  4.539 ns |   280.53 ns |
|       MapsterMap |    69.96 ns |  0.798 ns |  0.707 ns |    69.98 ns |
| StaticsMapperMap |    39.26 ns |  1.297 ns |  3.823 ns |    38.06 ns |
|    FastMapperMap |          NA |        NA |        NA |          NA |
| ValueInjecterMap | 4,677.63 ns | 37.013 ns | 34.622 ns | 4,670.60 ns |

Benchmarks with issues:
  From_TS0_Members_To_TC0_I1_Members.TinyMapperMap: InProcess(Toolchain=InProcessEmitToolchain)
  From_TS0_Members_To_TC0_I1_Members.FastMapperMap: InProcess(Toolchain=InProcessEmitToolchain)
