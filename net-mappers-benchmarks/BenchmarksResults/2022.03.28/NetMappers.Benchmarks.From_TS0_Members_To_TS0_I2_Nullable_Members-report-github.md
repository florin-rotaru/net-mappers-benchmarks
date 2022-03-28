``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.14393.5006 (1607/AnniversaryUpdate/Redstone1)
Intel Xeon CPU E5-2695 v3 2.30GHz, 1 CPU, 16 logical and 16 physical cores
.NET SDK=6.0.201
  [Host] : .NET 6.0.3 (6.0.322.12309), X64 RyuJIT

Job=InProcess  Toolchain=InProcessEmitToolchain  

```
|           Method |        Mean |     Error |    StdDev |
|----------------- |------------:|----------:|----------:|
| ExpressMapperMap | 5,445.71 ns | 66.524 ns | 58.972 ns |
|   AgileMapperMap |   632.86 ns |  5.424 ns |  5.073 ns |
|    TinyMapperMap |          NA |        NA |        NA |
|    AutoMapperMap |   604.54 ns |  5.794 ns |  5.136 ns |
|       MapsterMap |   170.39 ns |  1.220 ns |  1.081 ns |
| StaticsMapperMap |    95.23 ns |  0.579 ns |  0.541 ns |
|    FastMapperMap |          NA |        NA |        NA |
| ValueInjecterMap | 2,422.45 ns | 22.015 ns | 19.516 ns |

Benchmarks with issues:
  From_TS0_Members_To_TS0_I2_Nullable_Members.TinyMapperMap: InProcess(Toolchain=InProcessEmitToolchain)
  From_TS0_Members_To_TS0_I2_Nullable_Members.FastMapperMap: InProcess(Toolchain=InProcessEmitToolchain)
