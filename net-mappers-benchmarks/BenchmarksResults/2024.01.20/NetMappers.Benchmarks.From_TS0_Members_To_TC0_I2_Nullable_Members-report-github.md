```

BenchmarkDotNet v0.13.12, Windows 10 (10.0.14393.6614/1607/AnniversaryUpdate/Redstone1) (Hyper-V)
Intel Xeon CPU E5-2699 v3 2.30GHz, 1 CPU, 28 logical and 28 physical cores
.NET SDK 8.0.101
  [Host] : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=InProcess  Toolchain=InProcessEmitToolchain  

```
| Method           | Mean        | Error     | StdDev    |
|----------------- |------------:|----------:|----------:|
| ExpressMapperMap |   609.77 ns |  5.770 ns |  5.115 ns |
| AutoMapperMap    |   160.33 ns |  1.914 ns |  1.598 ns |
| MapsterMap       |    99.80 ns |  0.940 ns |  0.880 ns |
| StaticsMapperMap |    63.96 ns |  0.957 ns |  0.848 ns |
| FastMapperMap    |          NA |        NA |        NA |
| ValueInjecterMap | 1,447.97 ns | 14.353 ns | 11.986 ns |

Benchmarks with issues:
  From_TS0_Members_To_TC0_I2_Nullable_Members.FastMapperMap: InProcess(Toolchain=InProcessEmitToolchain)
