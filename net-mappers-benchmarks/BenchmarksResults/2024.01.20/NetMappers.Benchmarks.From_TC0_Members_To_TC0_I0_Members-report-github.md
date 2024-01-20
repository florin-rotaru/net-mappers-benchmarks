```

BenchmarkDotNet v0.13.12, Windows 10 (10.0.14393.6614/1607/AnniversaryUpdate/Redstone1) (Hyper-V)
Intel Xeon CPU E5-2699 v3 2.30GHz, 1 CPU, 28 logical and 28 physical cores
.NET SDK 8.0.101
  [Host] : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=InProcess  Toolchain=InProcessEmitToolchain  

```
| Method           | Mean        | Error    | StdDev   |
|----------------- |------------:|---------:|---------:|
| ExpressMapperMap |   120.78 ns | 1.710 ns | 1.335 ns |
| AutoMapperMap    |    96.12 ns | 1.207 ns | 1.070 ns |
| MapsterMap       |    38.82 ns | 0.586 ns | 0.490 ns |
| StaticsMapperMap |    22.39 ns | 0.108 ns | 0.084 ns |
| FastMapperMap    |   353.57 ns | 3.556 ns | 4.367 ns |
| ValueInjecterMap | 1,833.47 ns | 8.159 ns | 6.813 ns |
