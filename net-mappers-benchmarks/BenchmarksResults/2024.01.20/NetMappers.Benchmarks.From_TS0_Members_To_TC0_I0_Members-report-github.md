```

BenchmarkDotNet v0.13.12, Windows 10 (10.0.14393.6614/1607/AnniversaryUpdate/Redstone1) (Hyper-V)
Intel Xeon CPU E5-2699 v3 2.30GHz, 1 CPU, 28 logical and 28 physical cores
.NET SDK 8.0.101
  [Host] : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=InProcess  Toolchain=InProcessEmitToolchain  

```
| Method           | Mean        | Error      | StdDev     | Median      |
|----------------- |------------:|-----------:|-----------:|------------:|
| ExpressMapperMap |   569.12 ns |   4.595 ns |   4.073 ns |   569.24 ns |
| AutoMapperMap    |   129.37 ns |   0.701 ns |   0.585 ns |   129.38 ns |
| MapsterMap       |    70.40 ns |   1.030 ns |   1.409 ns |    70.12 ns |
| StaticsMapperMap |    32.45 ns |   0.374 ns |   0.332 ns |    32.33 ns |
| FastMapperMap    |          NA |         NA |         NA |          NA |
| ValueInjecterMap | 3,675.33 ns | 236.619 ns | 697.676 ns | 4,021.21 ns |

Benchmarks with issues:
  From_TS0_Members_To_TC0_I0_Members.FastMapperMap: InProcess(Toolchain=InProcessEmitToolchain)
