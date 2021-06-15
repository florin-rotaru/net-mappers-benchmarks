``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1016 (1909/November2018Update/19H2)
Intel Core i7-6820HQ CPU 2.70GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.1.401
  [Host] : .NET Core 3.1.7 (CoreCLR 4.700.20.36602, CoreFX 4.700.20.37001), X64 RyuJIT

Job=InProcess  Toolchain=InProcessEmitToolchain  

```
|           Method |      Mean |    Error |   StdDev |
|----------------- |----------:|---------:|---------:|
| ExpressMapperMap | 164.72 ns | 2.602 ns | 2.434 ns |
|   AgileMapperMap | 208.07 ns | 4.018 ns | 3.946 ns |
|    TinyMapperMap |  48.88 ns | 0.673 ns | 0.630 ns |
|    AutoMapperMap | 152.03 ns | 2.983 ns | 2.491 ns |
|       MapsterMap |  50.95 ns | 1.006 ns | 0.892 ns |
|     StaticsMapperMap |  28.13 ns | 0.620 ns | 0.580 ns |
| HigLaboMapperMap |  91.30 ns | 1.778 ns | 1.388 ns |
|    FastMapperMap | 382.57 ns | 3.617 ns | 3.207 ns |
