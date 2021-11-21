``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19043.1348 (21H1/May2021Update)
11th Gen Intel Core i5-1135G7 2.40GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.100
  [Host] : .NET 6.0.0 (6.0.21.52210), X64 RyuJIT

Job=InProcess  Toolchain=InProcessEmitToolchain  

```
|           Method |        Mean |     Error |    StdDev |
|----------------- |------------:|----------:|----------:|
| ExpressMapperMap | 2,225.44 ns | 44.231 ns | 79.758 ns |
|   AgileMapperMap |   282.75 ns |  5.493 ns |  5.641 ns |
|    TinyMapperMap |          NA |        NA |        NA |
|    AutoMapperMap |   123.51 ns |  2.393 ns |  2.457 ns |
|       MapsterMap |    52.50 ns |  0.816 ns |  0.682 ns |
| StaticsMapperMap |    24.82 ns |  0.508 ns |  0.475 ns |
|    FastMapperMap |          NA |        NA |        NA |
| ValueInjecterMap | 4,577.78 ns | 63.755 ns | 53.238 ns |

Benchmarks with issues:
  From_TC0_Members_To_TS0_I1_Members.TinyMapperMap: InProcess(Toolchain=InProcessEmitToolchain)
  From_TC0_Members_To_TS0_I1_Members.FastMapperMap: InProcess(Toolchain=InProcessEmitToolchain)
