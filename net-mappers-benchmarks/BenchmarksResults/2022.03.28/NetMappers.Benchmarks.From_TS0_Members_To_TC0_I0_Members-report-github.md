``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.14393.5006 (1607/AnniversaryUpdate/Redstone1)
Intel Xeon CPU E5-2695 v3 2.30GHz, 1 CPU, 16 logical and 16 physical cores
.NET SDK=6.0.201
  [Host] : .NET 6.0.3 (6.0.322.12309), X64 RyuJIT

Job=InProcess  Toolchain=InProcessEmitToolchain  

```
|           Method |        Mean |     Error |    StdDev |
|----------------- |------------:|----------:|----------:|
| ExpressMapperMap |   849.09 ns |  5.776 ns |  5.403 ns |
|   AgileMapperMap |   541.70 ns |  6.745 ns |  6.309 ns |
|    TinyMapperMap |          NA |        NA |        NA |
|    AutoMapperMap |   354.71 ns |  2.748 ns |  2.571 ns |
|       MapsterMap |    93.97 ns |  0.735 ns |  0.687 ns |
| StaticsMapperMap |    51.00 ns |  0.412 ns |  0.386 ns |
|    FastMapperMap |          NA |        NA |        NA |
| ValueInjecterMap | 6,184.32 ns | 49.684 ns | 44.043 ns |

Benchmarks with issues:
  From_TS0_Members_To_TC0_I0_Members.TinyMapperMap: InProcess(Toolchain=InProcessEmitToolchain)
  From_TS0_Members_To_TC0_I0_Members.FastMapperMap: InProcess(Toolchain=InProcessEmitToolchain)
