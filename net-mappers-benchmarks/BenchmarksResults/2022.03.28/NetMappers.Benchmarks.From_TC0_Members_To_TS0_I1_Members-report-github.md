``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.14393.5006 (1607/AnniversaryUpdate/Redstone1)
Intel Xeon CPU E5-2695 v3 2.30GHz, 1 CPU, 16 logical and 16 physical cores
.NET SDK=6.0.201
  [Host] : .NET 6.0.3 (6.0.322.12309), X64 RyuJIT

Job=InProcess  Toolchain=InProcessEmitToolchain  

```
|           Method |        Mean |     Error |    StdDev |
|----------------- |------------:|----------:|----------:|
| ExpressMapperMap | 4,004.11 ns | 40.865 ns | 36.226 ns |
|   AgileMapperMap |   446.30 ns |  4.930 ns |  4.117 ns |
|    TinyMapperMap |          NA |        NA |        NA |
|    AutoMapperMap |   203.89 ns |  1.753 ns |  1.554 ns |
|       MapsterMap |    77.98 ns |  1.576 ns |  1.474 ns |
| StaticsMapperMap |    35.88 ns |  0.368 ns |  0.344 ns |
|    FastMapperMap |          NA |        NA |        NA |
| ValueInjecterMap | 7,962.69 ns | 57.530 ns | 50.999 ns |

Benchmarks with issues:
  From_TC0_Members_To_TS0_I1_Members.TinyMapperMap: InProcess(Toolchain=InProcessEmitToolchain)
  From_TC0_Members_To_TS0_I1_Members.FastMapperMap: InProcess(Toolchain=InProcessEmitToolchain)
