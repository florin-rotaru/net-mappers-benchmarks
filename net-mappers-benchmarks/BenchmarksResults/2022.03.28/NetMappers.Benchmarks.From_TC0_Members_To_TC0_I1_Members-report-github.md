``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.14393.5006 (1607/AnniversaryUpdate/Redstone1)
Intel Xeon CPU E5-2695 v3 2.30GHz, 1 CPU, 16 logical and 16 physical cores
.NET SDK=6.0.201
  [Host] : .NET 6.0.3 (6.0.322.12309), X64 RyuJIT

Job=InProcess  Toolchain=InProcessEmitToolchain  

```
|           Method |        Mean |      Error |     StdDev |
|----------------- |------------:|-----------:|-----------:|
| ExpressMapperMap |   187.35 ns |   2.295 ns |   2.035 ns |
|   AgileMapperMap |   298.89 ns |   2.998 ns |   2.657 ns |
|    TinyMapperMap |   152.90 ns |   1.356 ns |   1.132 ns |
|    AutoMapperMap |   156.96 ns |   0.837 ns |   0.699 ns |
|       MapsterMap |    65.29 ns |   1.079 ns |   1.010 ns |
| StaticsMapperMap |    32.81 ns |   0.186 ns |   0.156 ns |
|    FastMapperMap |          NA |         NA |         NA |
| ValueInjecterMap | 7,868.59 ns | 120.156 ns | 112.394 ns |

Benchmarks with issues:
  From_TC0_Members_To_TC0_I1_Members.FastMapperMap: InProcess(Toolchain=InProcessEmitToolchain)
