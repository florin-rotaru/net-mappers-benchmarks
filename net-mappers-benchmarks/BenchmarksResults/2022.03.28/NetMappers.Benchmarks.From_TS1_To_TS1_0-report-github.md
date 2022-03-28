``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.14393.5006 (1607/AnniversaryUpdate/Redstone1)
Intel Xeon CPU E5-2695 v3 2.30GHz, 1 CPU, 16 logical and 16 physical cores
.NET SDK=6.0.201
  [Host] : .NET 6.0.3 (6.0.322.12309), X64 RyuJIT

Job=InProcess  Toolchain=InProcessEmitToolchain  

```
|           Method |       Mean |    Error |   StdDev |
|----------------- |-----------:|---------:|---------:|
| ExpressMapperMap |   540.1 ns |  6.36 ns |  5.95 ns |
|   AgileMapperMap | 1,470.1 ns | 14.73 ns | 13.06 ns |
|    TinyMapperMap |         NA |       NA |       NA |
|    AutoMapperMap | 1,532.6 ns |  7.78 ns |  6.89 ns |
|       MapsterMap | 1,005.4 ns | 10.90 ns |  9.66 ns |
| StaticsMapperMap |   253.2 ns |  4.99 ns |  5.54 ns |
|    FastMapperMap |         NA |       NA |       NA |
| ValueInjecterMap |   430.2 ns |  5.20 ns |  4.61 ns |

Benchmarks with issues:
  From_TS1_To_TS1_0.TinyMapperMap: InProcess(Toolchain=InProcessEmitToolchain)
  From_TS1_To_TS1_0.FastMapperMap: InProcess(Toolchain=InProcessEmitToolchain)
