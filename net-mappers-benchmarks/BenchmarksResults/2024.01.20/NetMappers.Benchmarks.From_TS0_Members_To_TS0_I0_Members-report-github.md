```

BenchmarkDotNet v0.13.12, Windows 10 (10.0.14393.6614/1607/AnniversaryUpdate/Redstone1) (Hyper-V)
Intel Xeon CPU E5-2699 v3 2.30GHz, 1 CPU, 28 logical and 28 physical cores
.NET SDK 8.0.101
  [Host] : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=InProcess  Toolchain=InProcessEmitToolchain  

```
| Method           | Mean        | Error     | StdDev    |
|----------------- |------------:|----------:|----------:|
| ExpressMapperMap | 2,624.22 ns | 39.605 ns | 48.639 ns |
| AutoMapperMap    |   127.37 ns |  0.955 ns |  1.973 ns |
| MapsterMap       |    72.51 ns |  0.430 ns |  0.336 ns |
| StaticsMapperMap |    23.78 ns |  0.053 ns |  0.047 ns |
| FastMapperMap    |          NA |        NA |        NA |
| ValueInjecterMap | 2,100.42 ns |  5.651 ns |  4.412 ns |

Benchmarks with issues:
  From_TS0_Members_To_TS0_I0_Members.FastMapperMap: InProcess(Toolchain=InProcessEmitToolchain)
