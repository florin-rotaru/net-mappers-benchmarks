```

BenchmarkDotNet v0.13.12, Windows 10 (10.0.14393.6614/1607/AnniversaryUpdate/Redstone1) (Hyper-V)
Intel Xeon CPU E5-2699 v3 2.30GHz, 1 CPU, 28 logical and 28 physical cores
.NET SDK 8.0.101
  [Host] : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=InProcess  Toolchain=InProcessEmitToolchain  

```
| Method           | Mean     | Error    | StdDev   |
|----------------- |---------:|---------:|---------:|
| ExpressMapperMap | 390.9 ns | 17.28 ns | 50.94 ns |
| AutoMapperMap    | 292.3 ns |  1.77 ns |  1.38 ns |
| MapsterMap       | 231.6 ns |  1.69 ns |  1.32 ns |
| StaticsMapperMap | 137.1 ns |  0.26 ns |  0.22 ns |
| FastMapperMap    |       NA |       NA |       NA |
| ValueInjecterMap | 262.9 ns |  0.78 ns |  0.65 ns |

Benchmarks with issues:
  From_TS1_To_TC1_0.FastMapperMap: InProcess(Toolchain=InProcessEmitToolchain)
