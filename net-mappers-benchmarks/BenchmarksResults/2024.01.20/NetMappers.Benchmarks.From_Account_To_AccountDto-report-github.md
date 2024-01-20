```

BenchmarkDotNet v0.13.12, Windows 10 (10.0.14393.6614/1607/AnniversaryUpdate/Redstone1) (Hyper-V)
Intel Xeon CPU E5-2699 v3 2.30GHz, 1 CPU, 28 logical and 28 physical cores
.NET SDK 8.0.101
  [Host] : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=InProcess  Toolchain=InProcessEmitToolchain  

```
| Method           | Mean       | Error    | StdDev   | Gen0   | Gen1   | Allocated |
|----------------- |-----------:|---------:|---------:|-------:|-------:|----------:|
| ExpressMapperMap | 1,599.1 ns | 30.05 ns | 42.12 ns | 0.1678 |      - |    3984 B |
| AutoMapperMap    |   978.4 ns | 19.52 ns | 32.08 ns | 0.1354 |      - |    3224 B |
| MapsterMap       |   706.7 ns |  8.11 ns |  6.33 ns | 0.1307 | 0.0010 |    3080 B |
| StaticsMapperMap |   638.5 ns | 12.13 ns | 10.75 ns | 0.1307 | 0.0010 |    3080 B |
| FastMapperMap    | 4,890.4 ns | 51.35 ns | 45.52 ns | 0.3433 |      - |    8216 B |
| ValueInjecterMap | 2,406.8 ns | 46.51 ns | 71.03 ns | 0.0229 |      - |     584 B |
