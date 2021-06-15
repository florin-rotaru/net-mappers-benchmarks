``` ini

BenchmarkDotNet=v0.13.0, OS=Windows 10.0.19042.1052 (20H2/October2020Update)
Intel Core i7-6820HQ CPU 2.70GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET SDK=5.0.301
  [Host] : .NET 5.0.7 (5.0.721.25508), X64 RyuJIT

Job=InProcess  Toolchain=InProcessEmitToolchain  

```
|           Method |       Mean |    Error |   StdDev |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|----------------- |-----------:|---------:|---------:|-------:|------:|------:|----------:|
| ExpressMapperMap | 2,115.6 ns | 20.92 ns | 19.57 ns | 0.9499 |     - |     - |   3,985 B |
|   AgileMapperMap | 1,018.3 ns | 11.28 ns | 10.56 ns | 0.8221 |     - |     - |   3,440 B |
|    TinyMapperMap | 3,985.2 ns | 15.35 ns | 12.82 ns | 0.8240 |     - |     - |   3,464 B |
|    AutoMapperMap | 2,282.1 ns | 14.77 ns | 13.82 ns | 0.7706 |     - |     - |   3,224 B |
|       MapsterMap |   723.7 ns | 10.58 ns |  9.38 ns | 0.7362 |     - |     - |   3,080 B |
| StaticsMapperMap |   678.2 ns |  9.83 ns |  8.71 ns | 0.7362 |     - |     - |   3,080 B |
|    FastMapperMap | 5,712.2 ns | 37.14 ns | 34.74 ns | 1.9608 |     - |     - |   8,216 B |
| ValueInjecterMap | 4,774.0 ns | 46.09 ns | 43.11 ns | 0.1984 |     - |     - |     840 B |
|    SafeMapperMap | 1,199.8 ns |  5.87 ns |  5.21 ns | 0.9174 |     - |     - |   3,840 B |
