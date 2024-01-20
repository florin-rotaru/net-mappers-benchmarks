```

BenchmarkDotNet v0.13.12, Windows 10 (10.0.14393.6614/1607/AnniversaryUpdate/Redstone1) (Hyper-V)
Intel Xeon CPU E5-2699 v3 2.30GHz, 1 CPU, 28 logical and 28 physical cores
.NET SDK 8.0.101
  [Host] : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=InProcess  Toolchain=InProcessEmitToolchain  

```
| Method           | Mean        | Error     | StdDev    |
|----------------- |------------:|----------:|----------:|
| ExpressMapperMap | 3,283.48 ns | 54.625 ns | 45.615 ns |
| AutoMapperMap    |   122.00 ns |  1.412 ns |  1.252 ns |
| MapsterMap       |    56.49 ns |  0.850 ns |  0.795 ns |
| StaticsMapperMap |    32.29 ns |  0.689 ns |  0.708 ns |
| FastMapperMap    |          NA |        NA |        NA |
| ValueInjecterMap | 2,336.88 ns | 12.511 ns | 10.447 ns |

Benchmarks with issues:
  From_TC0_Members_To_TS0_I1_Members.FastMapperMap: InProcess(Toolchain=InProcessEmitToolchain)
