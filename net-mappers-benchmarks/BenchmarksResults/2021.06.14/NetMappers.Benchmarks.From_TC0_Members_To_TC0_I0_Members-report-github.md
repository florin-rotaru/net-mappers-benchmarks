``` ini

BenchmarkDotNet=v0.13.0, OS=Windows 10.0.19042.1052 (20H2/October2020Update)
Intel Core i7-6820HQ CPU 2.70GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET SDK=5.0.301
  [Host] : .NET 5.0.7 (5.0.721.25508), X64 RyuJIT

Job=InProcess  Toolchain=InProcessEmitToolchain  

```
|           Method |        Mean |     Error |    StdDev |      Median |
|----------------- |------------:|----------:|----------:|------------:|
| ExpressMapperMap |   139.17 ns |  1.143 ns |  1.014 ns |   138.98 ns |
|   AgileMapperMap |   210.82 ns |  2.512 ns |  2.350 ns |   211.50 ns |
|    TinyMapperMap |    48.27 ns |  0.441 ns |  0.412 ns |    48.45 ns |
|    AutoMapperMap |   123.20 ns |  2.201 ns |  2.059 ns |   123.79 ns |
|       MapsterMap |    47.48 ns |  0.968 ns |  2.568 ns |    46.24 ns |
| StaticsMapperMap |    19.21 ns |  0.163 ns |  0.153 ns |    19.17 ns |
|    FastMapperMap |   392.47 ns |  1.973 ns |  1.541 ns |   392.64 ns |
| ValueInjecterMap | 5,894.19 ns | 79.481 ns | 74.347 ns | 5,926.75 ns |
|    SafeMapperMap |   189.38 ns |  0.568 ns |  0.532 ns |   189.21 ns |
