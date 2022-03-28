``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.14393.5006 (1607/AnniversaryUpdate/Redstone1)
Intel Xeon CPU E5-2695 v3 2.30GHz, 1 CPU, 16 logical and 16 physical cores
.NET SDK=6.0.201
  [Host] : .NET 6.0.3 (6.0.322.12309), X64 RyuJIT

Job=InProcess  Toolchain=InProcessEmitToolchain  

```
|           Method |       Mean |    Error |   StdDev |
|----------------- |-----------:|---------:|---------:|
| ExpressMapperMap |   984.1 ns |  9.04 ns |  8.01 ns |
|   AgileMapperMap |   633.9 ns |  2.15 ns |  1.80 ns |
|    TinyMapperMap |         NA |       NA |       NA |
|    AutoMapperMap |   521.2 ns |  5.66 ns |  5.30 ns |
|       MapsterMap |   143.1 ns |  1.42 ns |  1.33 ns |
| StaticsMapperMap |   110.3 ns |  0.87 ns |  0.78 ns |
|    FastMapperMap |         NA |       NA |       NA |
| ValueInjecterMap | 2,458.3 ns | 17.32 ns | 15.35 ns |

Benchmarks with issues:
  From_TS0_Members_To_TC0_I2_Nullable_Members.TinyMapperMap: InProcess(Toolchain=InProcessEmitToolchain)
  From_TS0_Members_To_TC0_I2_Nullable_Members.FastMapperMap: InProcess(Toolchain=InProcessEmitToolchain)
