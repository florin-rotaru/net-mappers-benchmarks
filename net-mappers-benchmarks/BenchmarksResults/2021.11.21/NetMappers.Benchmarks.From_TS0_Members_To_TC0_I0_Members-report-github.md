``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19043.1348 (21H1/May2021Update)
11th Gen Intel Core i5-1135G7 2.40GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.100
  [Host] : .NET 6.0.0 (6.0.21.52210), X64 RyuJIT

Job=InProcess  Toolchain=InProcessEmitToolchain  

```
|           Method |        Mean |     Error |    StdDev |
|----------------- |------------:|----------:|----------:|
| ExpressMapperMap |   461.48 ns |  2.631 ns |  2.461 ns |
|   AgileMapperMap |   298.85 ns |  0.736 ns |  0.614 ns |
|    TinyMapperMap |          NA |        NA |        NA |
|    AutoMapperMap |   230.45 ns |  0.447 ns |  0.373 ns |
|       MapsterMap |    61.52 ns |  0.266 ns |  0.249 ns |
| StaticsMapperMap |    31.03 ns |  0.150 ns |  0.140 ns |
|    FastMapperMap |          NA |        NA |        NA |
| ValueInjecterMap | 3,258.78 ns | 38.912 ns | 36.399 ns |

Benchmarks with issues:
  From_TS0_Members_To_TC0_I0_Members.TinyMapperMap: InProcess(Toolchain=InProcessEmitToolchain)
  From_TS0_Members_To_TC0_I0_Members.FastMapperMap: InProcess(Toolchain=InProcessEmitToolchain)
