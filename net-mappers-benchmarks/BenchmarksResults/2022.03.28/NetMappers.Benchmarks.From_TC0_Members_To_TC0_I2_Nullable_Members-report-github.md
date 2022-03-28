``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.14393.5006 (1607/AnniversaryUpdate/Redstone1)
Intel Xeon CPU E5-2695 v3 2.30GHz, 1 CPU, 16 logical and 16 physical cores
.NET SDK=6.0.201
  [Host] : .NET 6.0.3 (6.0.322.12309), X64 RyuJIT

Job=InProcess  Toolchain=InProcessEmitToolchain  

```
|           Method |        Mean |     Error |    StdDev |
|----------------- |------------:|----------:|----------:|
| ExpressMapperMap |   289.78 ns |  3.012 ns |  2.818 ns |
|   AgileMapperMap |   351.37 ns |  4.168 ns |  3.899 ns |
|    TinyMapperMap | 1,275.56 ns |  8.151 ns |  7.225 ns |
|    AutoMapperMap |   268.55 ns |  1.889 ns |  1.675 ns |
|       MapsterMap |   109.47 ns |  0.708 ns |  0.628 ns |
| StaticsMapperMap |    79.81 ns |  0.996 ns |  0.932 ns |
|    FastMapperMap |          NA |        NA |        NA |
| ValueInjecterMap | 2,135.18 ns | 19.088 ns | 17.855 ns |

Benchmarks with issues:
  From_TC0_Members_To_TC0_I2_Nullable_Members.FastMapperMap: InProcess(Toolchain=InProcessEmitToolchain)
