``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.14393.5006 (1607/AnniversaryUpdate/Redstone1)
Intel Xeon CPU E5-2695 v3 2.30GHz, 1 CPU, 16 logical and 16 physical cores
.NET SDK=6.0.201
  [Host] : .NET 6.0.3 (6.0.322.12309), X64 RyuJIT

Job=InProcess  Toolchain=InProcessEmitToolchain  

```
|           Method |       Mean |    Error |   StdDev |
|----------------- |-----------:|---------:|---------:|
| ExpressMapperMap |   396.5 ns |  5.24 ns |  4.90 ns |
|   AgileMapperMap |   577.5 ns |  6.88 ns |  6.44 ns |
|    TinyMapperMap | 1,496.4 ns | 17.11 ns | 16.00 ns |
|    AutoMapperMap |   787.3 ns |  5.41 ns |  5.06 ns |
|       MapsterMap |   162.8 ns |  1.49 ns |  1.39 ns |
| StaticsMapperMap |   128.2 ns |  2.31 ns |  1.93 ns |
|    FastMapperMap |         NA |       NA |       NA |
| ValueInjecterMap |   380.0 ns |  3.44 ns |  3.21 ns |

Benchmarks with issues:
  From_TC1_To_TC1_0.FastMapperMap: InProcess(Toolchain=InProcessEmitToolchain)
