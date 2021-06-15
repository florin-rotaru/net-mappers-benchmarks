``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1379 (1909/November2018Update/19H2)
Intel Core i7-6820HQ CPU 2.70GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=5.0.103
  [Host] : .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT

Job=InProcess  Toolchain=InProcessEmitToolchain  

```
|           Method |        Mean |     Error |    StdDev |
|----------------- |------------:|----------:|----------:|
| ExpressMapperMap |   131.30 ns |  1.005 ns |  0.840 ns |
|   AgileMapperMap |   206.22 ns |  3.023 ns |  2.680 ns |
|    TinyMapperMap |    46.20 ns |  0.189 ns |  0.177 ns |
|    AutoMapperMap |   120.37 ns |  1.000 ns |  0.935 ns |
|       MapsterMap |    46.70 ns |  0.192 ns |  0.293 ns |
|     StaticsMapperMap |    25.15 ns |  0.344 ns |  0.305 ns |
|    FastMapperMap |   378.51 ns |  2.567 ns |  2.276 ns |
| ValueInjecterMap | 5,806.31 ns | 84.998 ns | 75.349 ns |
|    SafeMapperMap |   179.73 ns |  1.397 ns |  1.239 ns |
