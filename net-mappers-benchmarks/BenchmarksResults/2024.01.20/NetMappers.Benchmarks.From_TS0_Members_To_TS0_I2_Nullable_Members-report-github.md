```

BenchmarkDotNet v0.13.12, Windows 10 (10.0.14393.6614/1607/AnniversaryUpdate/Redstone1) (Hyper-V)
Intel Xeon CPU E5-2699 v3 2.30GHz, 1 CPU, 28 logical and 28 physical cores
.NET SDK 8.0.101
  [Host] : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=InProcess  Toolchain=InProcessEmitToolchain  

```
| Method           | Mean        | Error    | StdDev   |
|----------------- |------------:|---------:|---------:|
| ExpressMapperMap | 3,968.56 ns | 9.542 ns | 8.458 ns |
| AutoMapperMap    |   155.64 ns | 0.700 ns | 0.621 ns |
| MapsterMap       |   111.24 ns | 0.247 ns | 0.219 ns |
| StaticsMapperMap |    52.64 ns | 0.569 ns | 0.444 ns |
| FastMapperMap    |          NA |       NA |       NA |
| ValueInjecterMap | 1,385.50 ns | 2.816 ns | 2.351 ns |

Benchmarks with issues:
  From_TS0_Members_To_TS0_I2_Nullable_Members.FastMapperMap: InProcess(Toolchain=InProcessEmitToolchain)
