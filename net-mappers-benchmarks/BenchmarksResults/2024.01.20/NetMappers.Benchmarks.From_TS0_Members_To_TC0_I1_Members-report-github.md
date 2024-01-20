```

BenchmarkDotNet v0.13.12, Windows 10 (10.0.14393.6614/1607/AnniversaryUpdate/Redstone1) (Hyper-V)
Intel Xeon CPU E5-2699 v3 2.30GHz, 1 CPU, 28 logical and 28 physical cores
.NET SDK 8.0.101
  [Host] : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=InProcess  Toolchain=InProcessEmitToolchain  

```
| Method           | Mean        | Error     | StdDev    |
|----------------- |------------:|----------:|----------:|
| ExpressMapperMap |   582.60 ns |  4.258 ns |  3.983 ns |
| AutoMapperMap    |   142.33 ns |  2.596 ns |  2.885 ns |
| MapsterMap       |    78.29 ns |  1.628 ns |  1.875 ns |
| StaticsMapperMap |    38.01 ns |  0.245 ns |  0.205 ns |
| FastMapperMap    |          NA |        NA |        NA |
| ValueInjecterMap | 2,583.07 ns | 40.859 ns | 34.119 ns |

Benchmarks with issues:
  From_TS0_Members_To_TC0_I1_Members.FastMapperMap: InProcess(Toolchain=InProcessEmitToolchain)
