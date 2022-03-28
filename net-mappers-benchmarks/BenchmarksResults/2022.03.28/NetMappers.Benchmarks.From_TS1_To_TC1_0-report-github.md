``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.14393.5006 (1607/AnniversaryUpdate/Redstone1)
Intel Xeon CPU E5-2695 v3 2.30GHz, 1 CPU, 16 logical and 16 physical cores
.NET SDK=6.0.201
  [Host] : .NET 6.0.3 (6.0.322.12309), X64 RyuJIT

Job=InProcess  Toolchain=InProcessEmitToolchain  

```
|           Method |       Mean |    Error |   StdDev |
|----------------- |-----------:|---------:|---------:|
| ExpressMapperMap |   436.5 ns |  4.84 ns |  4.52 ns |
|   AgileMapperMap | 1,389.7 ns | 10.23 ns |  9.57 ns |
|    TinyMapperMap |         NA |       NA |       NA |
|    AutoMapperMap | 1,373.2 ns | 14.12 ns | 12.52 ns |
|       MapsterMap |   917.3 ns |  6.40 ns |  5.67 ns |
| StaticsMapperMap |   179.1 ns |  1.54 ns |  1.37 ns |
|    FastMapperMap |         NA |       NA |       NA |
| ValueInjecterMap |   403.8 ns |  2.59 ns |  2.16 ns |

Benchmarks with issues:
  From_TS1_To_TC1_0.TinyMapperMap: InProcess(Toolchain=InProcessEmitToolchain)
  From_TS1_To_TC1_0.FastMapperMap: InProcess(Toolchain=InProcessEmitToolchain)
