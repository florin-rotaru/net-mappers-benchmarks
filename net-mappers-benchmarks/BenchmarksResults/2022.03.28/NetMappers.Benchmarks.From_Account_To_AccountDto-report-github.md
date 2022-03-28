``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.14393.5006 (1607/AnniversaryUpdate/Redstone1)
Intel Xeon CPU E5-2695 v3 2.30GHz, 1 CPU, 16 logical and 16 physical cores
.NET SDK=6.0.201
  [Host] : .NET 6.0.3 (6.0.322.12309), X64 RyuJIT

Job=InProcess  Toolchain=InProcessEmitToolchain  

```
|           Method |       Mean |    Error |   StdDev |  Gen 0 |  Gen 1 | Allocated |
|----------------- |-----------:|---------:|---------:|-------:|-------:|----------:|
| ExpressMapperMap | 2,417.8 ns | 24.81 ns | 22.00 ns | 0.2174 | 0.0038 |   3,984 B |
|   AgileMapperMap | 1,316.9 ns | 14.52 ns | 13.58 ns | 0.1869 | 0.0038 |   3,440 B |
|    TinyMapperMap | 4,941.7 ns | 45.30 ns | 42.37 ns | 0.1831 |      - |   3,464 B |
|    AutoMapperMap | 2,396.9 ns | 35.76 ns | 31.70 ns | 0.1755 | 0.0038 |   3,224 B |
|       MapsterMap |   929.5 ns | 14.38 ns | 12.74 ns | 0.1678 | 0.0038 |   3,080 B |
| StaticsMapperMap |   848.7 ns | 13.97 ns | 13.07 ns | 0.1678 | 0.0029 |   3,080 B |
|    FastMapperMap | 6,735.1 ns | 52.42 ns | 49.03 ns | 0.4425 | 0.0076 |   8,216 B |
| ValueInjecterMap | 4,507.1 ns | 70.66 ns | 66.10 ns | 0.0305 |      - |     584 B |
