``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.14393.5006 (1607/AnniversaryUpdate/Redstone1)
Intel Xeon CPU E5-2695 v3 2.30GHz, 1 CPU, 16 logical and 16 physical cores
.NET SDK=6.0.201
  [Host] : .NET 6.0.3 (6.0.322.12309), X64 RyuJIT

Job=InProcess  Toolchain=InProcessEmitToolchain  

```
|           Method |        Mean |     Error |    StdDev |
|----------------- |------------:|----------:|----------:|
| ExpressMapperMap | 3,415.23 ns | 29.290 ns | 27.398 ns |
|   AgileMapperMap |   488.33 ns |  6.594 ns |  6.168 ns |
|    TinyMapperMap |          NA |        NA |        NA |
|    AutoMapperMap |   357.05 ns |  2.822 ns |  2.640 ns |
|       MapsterMap |    97.41 ns |  0.837 ns |  0.783 ns |
| StaticsMapperMap |    39.42 ns |  0.311 ns |  0.291 ns |
|    FastMapperMap |          NA |        NA |        NA |
| ValueInjecterMap | 6,254.73 ns | 92.932 ns | 86.929 ns |

Benchmarks with issues:
  From_TS0_Members_To_TS0_I0_Members.TinyMapperMap: InProcess(Toolchain=InProcessEmitToolchain)
  From_TS0_Members_To_TS0_I0_Members.FastMapperMap: InProcess(Toolchain=InProcessEmitToolchain)
