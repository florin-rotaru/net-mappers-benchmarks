```

BenchmarkDotNet v0.13.12, Windows 10 (10.0.14393.6614/1607/AnniversaryUpdate/Redstone1) (Hyper-V)
Intel Xeon CPU E5-2699 v3 2.30GHz, 1 CPU, 28 logical and 28 physical cores
.NET SDK 8.0.101
  [Host] : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=InProcess  Toolchain=InProcessEmitToolchain  

```
| Method           | Mean        | Error     | StdDev     | Median      |
|----------------- |------------:|----------:|-----------:|------------:|
| ExpressMapperMap |   154.46 ns |  3.173 ns |   3.527 ns |   152.65 ns |
| AutoMapperMap    |   115.63 ns |  0.740 ns |   0.578 ns |   115.72 ns |
| MapsterMap       |    61.88 ns |  0.940 ns |   0.785 ns |    61.51 ns |
| StaticsMapperMap |    51.26 ns |  1.035 ns |   0.968 ns |    50.94 ns |
| FastMapperMap    |          NA |        NA |         NA |          NA |
| ValueInjecterMap | 1,333.88 ns | 66.605 ns | 177.783 ns | 1,253.26 ns |

Benchmarks with issues:
  From_TC0_Members_To_TC0_I2_Nullable_Members.FastMapperMap: InProcess(Toolchain=InProcessEmitToolchain)
