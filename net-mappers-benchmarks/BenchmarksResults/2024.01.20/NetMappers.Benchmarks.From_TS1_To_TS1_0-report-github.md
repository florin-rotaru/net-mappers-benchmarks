```

BenchmarkDotNet v0.13.12, Windows 10 (10.0.14393.6614/1607/AnniversaryUpdate/Redstone1) (Hyper-V)
Intel Xeon CPU E5-2699 v3 2.30GHz, 1 CPU, 28 logical and 28 physical cores
.NET SDK 8.0.101
  [Host] : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=InProcess  Toolchain=InProcessEmitToolchain  

```
| Method           | Mean     | Error   | StdDev  |
|----------------- |---------:|--------:|--------:|
| ExpressMapperMap | 205.0 ns | 1.61 ns | 1.34 ns |
| AutoMapperMap    | 316.0 ns | 1.68 ns | 1.49 ns |
| MapsterMap       | 268.0 ns | 3.99 ns | 3.54 ns |
| StaticsMapperMap | 159.6 ns | 0.73 ns | 0.65 ns |
| FastMapperMap    |       NA |      NA |      NA |
| ValueInjecterMap | 285.7 ns | 1.26 ns | 1.12 ns |

Benchmarks with issues:
  From_TS1_To_TS1_0.FastMapperMap: InProcess(Toolchain=InProcessEmitToolchain)
