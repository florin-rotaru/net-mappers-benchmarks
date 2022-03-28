``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.14393.5006 (1607/AnniversaryUpdate/Redstone1)
Intel Xeon CPU E5-2695 v3 2.30GHz, 1 CPU, 16 logical and 16 physical cores
.NET SDK=6.0.201
  [Host] : .NET 6.0.3 (6.0.322.12309), X64 RyuJIT

Job=InProcess  Toolchain=InProcessEmitToolchain  

```
|           Method |        Mean |     Error |    StdDev |
|----------------- |------------:|----------:|----------:|
| ExpressMapperMap | 2,879.43 ns | 36.880 ns | 32.694 ns |
|   AgileMapperMap |   407.59 ns |  4.640 ns |  4.113 ns |
|    TinyMapperMap |          NA |        NA |        NA |
|    AutoMapperMap |   185.26 ns |  3.451 ns |  3.228 ns |
|       MapsterMap |    71.43 ns |  0.458 ns |  0.406 ns |
| StaticsMapperMap |    28.90 ns |  0.422 ns |  0.395 ns |
|    FastMapperMap |          NA |        NA |        NA |
| ValueInjecterMap | 5,867.17 ns | 54.045 ns | 50.554 ns |

Benchmarks with issues:
  From_TC0_Members_To_TS0_I0_Members.TinyMapperMap: InProcess(Toolchain=InProcessEmitToolchain)
  From_TC0_Members_To_TS0_I0_Members.FastMapperMap: InProcess(Toolchain=InProcessEmitToolchain)
