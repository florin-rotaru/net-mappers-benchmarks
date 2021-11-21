``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19043.1348 (21H1/May2021Update)
11th Gen Intel Core i5-1135G7 2.40GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.100
  [Host] : .NET 6.0.0 (6.0.21.52210), X64 RyuJIT

Job=InProcess  Toolchain=InProcessEmitToolchain  

```
|           Method |      Mean |     Error |    StdDev |
|----------------- |----------:|----------:|----------:|
| ExpressMapperMap | 218.31 ns |  1.499 ns |  1.328 ns |
|   AgileMapperMap | 318.82 ns |  0.950 ns |  0.889 ns |
|    TinyMapperMap | 897.25 ns | 17.260 ns | 18.468 ns |
|    AutoMapperMap | 530.33 ns |  2.977 ns |  2.486 ns |
|       MapsterMap |  97.41 ns |  0.237 ns |  0.198 ns |
| StaticsMapperMap |  72.26 ns |  0.334 ns |  0.296 ns |
|    FastMapperMap |        NA |        NA |        NA |
| ValueInjecterMap | 193.31 ns |  1.966 ns |  1.743 ns |

Benchmarks with issues:
  From_TC1_To_TC1_0.FastMapperMap: InProcess(Toolchain=InProcessEmitToolchain)
