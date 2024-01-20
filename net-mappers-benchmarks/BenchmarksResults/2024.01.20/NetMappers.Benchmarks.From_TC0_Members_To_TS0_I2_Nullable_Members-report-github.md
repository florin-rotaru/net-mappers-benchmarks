```

BenchmarkDotNet v0.13.12, Windows 10 (10.0.14393.6614/1607/AnniversaryUpdate/Redstone1) (Hyper-V)
Intel Xeon CPU E5-2699 v3 2.30GHz, 1 CPU, 28 logical and 28 physical cores
.NET SDK 8.0.101
  [Host] : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=InProcess  Toolchain=InProcessEmitToolchain  

```
| Method           | Mean        | Error     | StdDev    |
|----------------- |------------:|----------:|----------:|
| ExpressMapperMap | 3,662.23 ns | 42.796 ns | 37.937 ns |
| AutoMapperMap    |   169.60 ns |  1.520 ns |  1.269 ns |
| MapsterMap       |   101.61 ns |  0.988 ns |  0.825 ns |
| StaticsMapperMap |    59.25 ns |  0.521 ns |  0.462 ns |
| FastMapperMap    |          NA |        NA |        NA |
| ValueInjecterMap | 1,248.60 ns | 19.653 ns | 16.411 ns |

Benchmarks with issues:
  From_TC0_Members_To_TS0_I2_Nullable_Members.FastMapperMap: InProcess(Toolchain=InProcessEmitToolchain)
