``` ini

BenchmarkDotNet=v0.13.0, OS=Windows 10.0.19042.1052 (20H2/October2020Update)
Intel Core i7-6820HQ CPU 2.70GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET SDK=5.0.301
  [Host] : .NET 5.0.7 (5.0.721.25508), X64 RyuJIT

Job=InProcess  Toolchain=InProcessEmitToolchain  

```
|           Method |        Mean |    Error |   StdDev |
|----------------- |------------:|---------:|---------:|
| ExpressMapperMap |   456.06 ns | 3.934 ns | 3.680 ns |
|   AgileMapperMap |   449.69 ns | 1.459 ns | 1.293 ns |
|    TinyMapperMap | 1,246.85 ns | 2.081 ns | 1.947 ns |
|    AutoMapperMap |   832.49 ns | 6.890 ns | 5.754 ns |
|       MapsterMap |   130.77 ns | 0.833 ns | 0.779 ns |
| StaticsMapperMap |    97.56 ns | 0.467 ns | 0.437 ns |
|    FastMapperMap |          NA |       NA |       NA |
| ValueInjecterMap |   418.97 ns | 3.286 ns | 2.913 ns |
|    SafeMapperMap |   237.07 ns | 0.591 ns | 0.553 ns |

Benchmarks with issues:
  From_TC1_To_TC1_0.FastMapperMap: InProcess(Toolchain=InProcessEmitToolchain)
