```

BenchmarkDotNet v0.13.12, Windows 10 (10.0.14393.6614/1607/AnniversaryUpdate/Redstone1) (Hyper-V)
Intel Xeon CPU E5-2699 v3 2.30GHz, 1 CPU, 28 logical and 28 physical cores
.NET SDK 8.0.101
  [Host] : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=InProcess  Toolchain=InProcessEmitToolchain  

```
| Method           | Mean     | Error   | StdDev  |
|----------------- |---------:|--------:|--------:|
| ExpressMapperMap | 207.7 ns | 1.96 ns | 1.53 ns |
| AutoMapperMap    | 249.1 ns | 0.56 ns | 0.43 ns |
| MapsterMap       | 189.5 ns | 0.35 ns | 0.29 ns |
| StaticsMapperMap | 122.0 ns | 0.30 ns | 0.27 ns |
| FastMapperMap    |       NA |      NA |      NA |
| ValueInjecterMap | 271.4 ns | 1.82 ns | 2.02 ns |

Benchmarks with issues:
  From_TC1_To_TS1_0.FastMapperMap: InProcess(Toolchain=InProcessEmitToolchain)
