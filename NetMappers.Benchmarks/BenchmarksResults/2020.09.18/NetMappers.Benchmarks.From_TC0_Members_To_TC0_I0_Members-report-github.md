``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1082 (1909/November2018Update/19H2)
Intel Core i7-6820HQ CPU 2.70GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.1.402
  [Host] : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT

Job=InProcess  Toolchain=InProcessEmitToolchain  

```
|           Method |        Mean |      Error |    StdDev |
|----------------- |------------:|-----------:|----------:|
| ExpressMapperMap |   157.61 ns |   1.915 ns |  1.698 ns |
|   AgileMapperMap |   234.06 ns |   4.702 ns |  8.358 ns |
|    TinyMapperMap |    51.35 ns |   0.990 ns |  0.926 ns |
|    AutoMapperMap |   165.75 ns |   1.974 ns |  1.750 ns |
|       MapsterMap |    51.81 ns |   1.064 ns |  1.093 ns |
|     AirMapperMap |    18.79 ns |   0.368 ns |  0.344 ns |
| HigLaboMapperMap |    86.34 ns |   1.339 ns |  1.187 ns |
|    FastMapperMap |   401.67 ns |   4.080 ns |  3.407 ns |
| ValueInjecterMap | 6,191.96 ns | 103.131 ns | 96.469 ns |
|   PowerMapperMap |    63.55 ns |   0.765 ns |  0.678 ns |
|    SafeMapperMap |   190.18 ns |   3.807 ns |  4.231 ns |
