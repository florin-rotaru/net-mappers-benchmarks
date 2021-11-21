``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19043.1348 (21H1/May2021Update)
11th Gen Intel Core i5-1135G7 2.40GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.100
  [Host] : .NET 6.0.0 (6.0.21.52210), X64 RyuJIT

Job=InProcess  Toolchain=InProcessEmitToolchain  

```
|           Method |        Mean |     Error |    StdDev |
|----------------- |------------:|----------:|----------:|
| ExpressMapperMap | 1,824.39 ns | 17.425 ns | 16.299 ns |
|   AgileMapperMap |   308.73 ns |  5.201 ns |  4.865 ns |
|    TinyMapperMap |          NA |        NA |        NA |
|    AutoMapperMap |   261.11 ns |  2.147 ns |  2.008 ns |
|       MapsterMap |    71.86 ns |  1.407 ns |  1.445 ns |
| StaticsMapperMap |    29.29 ns |  0.044 ns |  0.037 ns |
|    FastMapperMap |          NA |        NA |        NA |
| ValueInjecterMap | 3,219.46 ns | 22.759 ns | 20.175 ns |

Benchmarks with issues:
  From_TS0_Members_To_TS0_I0_Members.TinyMapperMap: InProcess(Toolchain=InProcessEmitToolchain)
  From_TS0_Members_To_TS0_I0_Members.FastMapperMap: InProcess(Toolchain=InProcessEmitToolchain)
