``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19043.1348 (21H1/May2021Update)
11th Gen Intel Core i5-1135G7 2.40GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.100
  [Host] : .NET 6.0.0 (6.0.21.52210), X64 RyuJIT

Job=InProcess  Toolchain=InProcessEmitToolchain  

```
|           Method |        Mean |     Error |    StdDev |
|----------------- |------------:|----------:|----------:|
| ExpressMapperMap | 2,564.82 ns | 25.993 ns | 24.314 ns |
|   AgileMapperMap |   312.08 ns |  0.764 ns |  0.677 ns |
|    TinyMapperMap |          NA |        NA |        NA |
|    AutoMapperMap |   303.30 ns |  0.677 ns |  0.565 ns |
|       MapsterMap |    70.06 ns |  0.228 ns |  0.213 ns |
| StaticsMapperMap |    30.94 ns |  0.077 ns |  0.072 ns |
|    FastMapperMap |          NA |        NA |        NA |
| ValueInjecterMap | 4,289.81 ns | 14.597 ns | 13.654 ns |

Benchmarks with issues:
  From_TS0_Members_To_TS0_I1_Members.TinyMapperMap: InProcess(Toolchain=InProcessEmitToolchain)
  From_TS0_Members_To_TS0_I1_Members.FastMapperMap: InProcess(Toolchain=InProcessEmitToolchain)
