```

BenchmarkDotNet v0.13.12, Windows 10 (10.0.14393.6614/1607/AnniversaryUpdate/Redstone1) (Hyper-V)
Intel Xeon CPU E5-2699 v3 2.30GHz, 1 CPU, 28 logical and 28 physical cores
.NET SDK 8.0.101
  [Host] : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=InProcess  Toolchain=InProcessEmitToolchain  

```
| Method           | Mean        | Error     | StdDev    |
|----------------- |------------:|----------:|----------:|
| ExpressMapperMap | 3,697.70 ns | 37.172 ns | 34.770 ns |
| AutoMapperMap    |   135.53 ns |  0.286 ns |  0.239 ns |
| MapsterMap       |    74.80 ns |  0.185 ns |  0.145 ns |
| StaticsMapperMap |    24.10 ns |  0.302 ns |  0.236 ns |
| FastMapperMap    |          NA |        NA |        NA |
| ValueInjecterMap | 2,588.78 ns | 21.305 ns | 17.790 ns |

Benchmarks with issues:
  From_TS0_Members_To_TS0_I1_Members.FastMapperMap: InProcess(Toolchain=InProcessEmitToolchain)
