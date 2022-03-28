``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.14393.5006 (1607/AnniversaryUpdate/Redstone1)
Intel Xeon CPU E5-2695 v3 2.30GHz, 1 CPU, 16 logical and 16 physical cores
.NET SDK=6.0.201
  [Host] : .NET 6.0.3 (6.0.322.12309), X64 RyuJIT

Job=InProcess  Toolchain=InProcessEmitToolchain  

```
|           Method |     Mean |    Error |   StdDev |
|----------------- |---------:|---------:|---------:|
| ExpressMapperMap | 499.2 ns |  5.60 ns |  4.97 ns |
|   AgileMapperMap | 706.2 ns | 11.68 ns | 10.93 ns |
|    TinyMapperMap |       NA |       NA |       NA |
|    AutoMapperMap | 967.0 ns |  7.33 ns |  6.12 ns |
|       MapsterMap | 262.4 ns |  2.30 ns |  1.92 ns |
| StaticsMapperMap | 212.2 ns |  1.46 ns |  1.22 ns |
|    FastMapperMap |       NA |       NA |       NA |
| ValueInjecterMap | 432.7 ns |  4.88 ns |  4.07 ns |

Benchmarks with issues:
  From_TC1_To_TS1_0.TinyMapperMap: InProcess(Toolchain=InProcessEmitToolchain)
  From_TC1_To_TS1_0.FastMapperMap: InProcess(Toolchain=InProcessEmitToolchain)
