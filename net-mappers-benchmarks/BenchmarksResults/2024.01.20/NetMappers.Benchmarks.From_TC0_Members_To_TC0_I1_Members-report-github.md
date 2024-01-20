```

BenchmarkDotNet v0.13.12, Windows 10 (10.0.14393.6614/1607/AnniversaryUpdate/Redstone1) (Hyper-V)
Intel Xeon CPU E5-2699 v3 2.30GHz, 1 CPU, 28 logical and 28 physical cores
.NET SDK 8.0.101
  [Host] : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=InProcess  Toolchain=InProcessEmitToolchain  

```
| Method           | Mean        | Error     | StdDev    |
|----------------- |------------:|----------:|----------:|
| ExpressMapperMap |   123.15 ns |  2.113 ns |  2.075 ns |
| AutoMapperMap    |   100.25 ns |  1.262 ns |  0.985 ns |
| MapsterMap       |    40.73 ns |  0.275 ns |  0.243 ns |
| StaticsMapperMap |    26.59 ns |  0.305 ns |  0.271 ns |
| FastMapperMap    |          NA |        NA |        NA |
| ValueInjecterMap | 2,296.11 ns | 26.948 ns | 22.503 ns |

Benchmarks with issues:
  From_TC0_Members_To_TC0_I1_Members.FastMapperMap: InProcess(Toolchain=InProcessEmitToolchain)
