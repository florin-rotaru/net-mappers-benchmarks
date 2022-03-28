``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.14393.5006 (1607/AnniversaryUpdate/Redstone1)
Intel Xeon CPU E5-2695 v3 2.30GHz, 1 CPU, 16 logical and 16 physical cores
.NET SDK=6.0.201
  [Host] : .NET 6.0.3 (6.0.322.12309), X64 RyuJIT

Job=InProcess  Toolchain=InProcessEmitToolchain  

```
|           Method |        Mean |     Error |    StdDev |
|----------------- |------------:|----------:|----------:|
| ExpressMapperMap |   871.33 ns |  6.167 ns |  5.467 ns |
|   AgileMapperMap |   574.35 ns |  7.559 ns |  6.312 ns |
|    TinyMapperMap |          NA |        NA |        NA |
|    AutoMapperMap |   412.41 ns |  2.429 ns |  2.028 ns |
|       MapsterMap |   107.07 ns |  2.105 ns |  1.866 ns |
| StaticsMapperMap |    61.76 ns |  1.326 ns |  1.240 ns |
|    FastMapperMap |          NA |        NA |        NA |
| ValueInjecterMap | 8,339.47 ns | 73.555 ns | 68.803 ns |

Benchmarks with issues:
  From_TS0_Members_To_TC0_I1_Members.TinyMapperMap: InProcess(Toolchain=InProcessEmitToolchain)
  From_TS0_Members_To_TC0_I1_Members.FastMapperMap: InProcess(Toolchain=InProcessEmitToolchain)
