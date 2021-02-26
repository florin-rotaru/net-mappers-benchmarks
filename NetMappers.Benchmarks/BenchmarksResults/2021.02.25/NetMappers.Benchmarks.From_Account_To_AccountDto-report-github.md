``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1379 (1909/November2018Update/19H2)
Intel Core i7-6820HQ CPU 2.70GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=5.0.103
  [Host] : .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT

Job=InProcess  Toolchain=InProcessEmitToolchain  

```
|           Method |       Mean |     Error |    StdDev |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|----------------- |-----------:|----------:|----------:|-------:|------:|------:|----------:|
| ExpressMapperMap | 2,263.7 ns |  45.18 ns |  57.14 ns | 0.9499 |     - |     - |    3985 B |
|   AgileMapperMap | 1,047.8 ns |   5.91 ns |   5.53 ns | 0.8221 |     - |     - |    3441 B |
|    TinyMapperMap | 3,977.6 ns |  13.73 ns |  12.85 ns | 0.8240 |     - |     - |    3465 B |
|    AutoMapperMap | 2,178.8 ns |  23.08 ns |  20.46 ns | 0.7706 |     - |     - |    3225 B |
|       MapsterMap |   736.0 ns |   8.18 ns |   7.65 ns | 0.7362 |     - |     - |    3080 B |
|     AirMapperMap |   668.6 ns |   3.00 ns |   2.66 ns | 0.7362 |     - |     - |    3080 B |
|    FastMapperMap | 5,666.5 ns | 103.45 ns | 127.05 ns | 1.9608 |     - |     - |    8218 B |
| ValueInjecterMap | 4,784.0 ns |  17.14 ns |  15.19 ns | 0.1984 |     - |     - |     840 B |
|    SafeMapperMap | 1,276.1 ns |  16.25 ns |  13.57 ns | 0.9174 |     - |     - |    3840 B |
