```

BenchmarkDotNet v0.13.12, Windows 10 (10.0.14393.6614/1607/AnniversaryUpdate/Redstone1) (Hyper-V)
Intel Xeon CPU E5-2699 v3 2.30GHz, 1 CPU, 28 logical and 28 physical cores
.NET SDK 8.0.101
  [Host] : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=InProcess  Toolchain=InProcessEmitToolchain  

```
| Method           | Mean        | Error     | StdDev    |
|----------------- |------------:|----------:|----------:|
| ExpressMapperMap | 2,194.58 ns | 28.849 ns | 24.090 ns |
| AutoMapperMap    |   112.13 ns |  2.116 ns |  1.876 ns |
| MapsterMap       |    51.48 ns |  0.704 ns |  0.588 ns |
| StaticsMapperMap |    28.93 ns |  0.404 ns |  0.358 ns |
| FastMapperMap    |          NA |        NA |        NA |
| ValueInjecterMap | 1,900.20 ns | 18.019 ns | 17.697 ns |

Benchmarks with issues:
  From_TC0_Members_To_TS0_I0_Members.FastMapperMap: InProcess(Toolchain=InProcessEmitToolchain)
