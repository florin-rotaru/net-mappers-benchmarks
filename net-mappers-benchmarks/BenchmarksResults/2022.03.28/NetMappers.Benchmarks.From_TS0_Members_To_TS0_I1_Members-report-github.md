``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.14393.5006 (1607/AnniversaryUpdate/Redstone1)
Intel Xeon CPU E5-2695 v3 2.30GHz, 1 CPU, 16 logical and 16 physical cores
.NET SDK=6.0.201
  [Host] : .NET 6.0.3 (6.0.322.12309), X64 RyuJIT

Job=InProcess  Toolchain=InProcessEmitToolchain  

```
|           Method |        Mean |     Error |    StdDev |
|----------------- |------------:|----------:|----------:|
| ExpressMapperMap | 4,678.96 ns | 56.183 ns | 52.554 ns |
|   AgileMapperMap |   507.99 ns |  4.723 ns |  4.187 ns |
|    TinyMapperMap |          NA |        NA |        NA |
|    AutoMapperMap |   452.15 ns |  3.491 ns |  3.266 ns |
|       MapsterMap |    99.60 ns |  0.954 ns |  0.797 ns |
| StaticsMapperMap |    43.74 ns |  0.383 ns |  0.339 ns |
|    FastMapperMap |          NA |        NA |        NA |
| ValueInjecterMap | 8,337.72 ns | 69.825 ns | 58.307 ns |

Benchmarks with issues:
  From_TS0_Members_To_TS0_I1_Members.TinyMapperMap: InProcess(Toolchain=InProcessEmitToolchain)
  From_TS0_Members_To_TS0_I1_Members.FastMapperMap: InProcess(Toolchain=InProcessEmitToolchain)
