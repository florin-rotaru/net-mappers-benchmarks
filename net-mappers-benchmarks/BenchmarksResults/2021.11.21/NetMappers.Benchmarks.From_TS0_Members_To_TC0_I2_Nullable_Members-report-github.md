``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19043.1348 (21H1/May2021Update)
11th Gen Intel Core i5-1135G7 2.40GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.100
  [Host] : .NET 6.0.0 (6.0.21.52210), X64 RyuJIT

Job=InProcess  Toolchain=InProcessEmitToolchain  

```
|           Method |        Mean |     Error |    StdDev |      Median |
|----------------- |------------:|----------:|----------:|------------:|
| ExpressMapperMap |   563.46 ns |  7.504 ns |  7.019 ns |   562.81 ns |
|   AgileMapperMap |   385.15 ns | 14.321 ns | 42.225 ns |   355.76 ns |
|    TinyMapperMap |          NA |        NA |        NA |          NA |
|    AutoMapperMap |   314.78 ns |  1.591 ns |  1.488 ns |   314.64 ns |
|       MapsterMap |    83.99 ns |  0.949 ns |  0.842 ns |    84.07 ns |
| StaticsMapperMap |    60.39 ns |  0.394 ns |  0.350 ns |    60.54 ns |
|    FastMapperMap |          NA |        NA |        NA |          NA |
| ValueInjecterMap | 1,330.88 ns | 21.811 ns | 20.402 ns | 1,332.20 ns |

Benchmarks with issues:
  From_TS0_Members_To_TC0_I2_Nullable_Members.TinyMapperMap: InProcess(Toolchain=InProcessEmitToolchain)
  From_TS0_Members_To_TC0_I2_Nullable_Members.FastMapperMap: InProcess(Toolchain=InProcessEmitToolchain)
