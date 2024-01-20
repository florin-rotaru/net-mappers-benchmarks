```

BenchmarkDotNet v0.13.12, Windows 10 (10.0.14393.6614/1607/AnniversaryUpdate/Redstone1) (Hyper-V)
Intel Xeon CPU E5-2699 v3 2.30GHz, 1 CPU, 28 logical and 28 physical cores
.NET SDK 8.0.101
  [Host] : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=InProcess  Toolchain=InProcessEmitToolchain  

```
| Method           | Mean      | Error    | StdDev   |
|----------------- |----------:|---------:|---------:|
| ExpressMapperMap | 206.90 ns | 0.474 ns | 0.420 ns |
| AutoMapperMap    | 161.20 ns | 1.520 ns | 1.347 ns |
| MapsterMap       |  98.50 ns | 0.441 ns | 0.368 ns |
| StaticsMapperMap |  87.13 ns | 0.210 ns | 0.175 ns |
| FastMapperMap    |        NA |       NA |       NA |
| ValueInjecterMap | 245.41 ns | 0.870 ns | 0.726 ns |

Benchmarks with issues:
  From_TC1_To_TC1_0.FastMapperMap: InProcess(Toolchain=InProcessEmitToolchain)
