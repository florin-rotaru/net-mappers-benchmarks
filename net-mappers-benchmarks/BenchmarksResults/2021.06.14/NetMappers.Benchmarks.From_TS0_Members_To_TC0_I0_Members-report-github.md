``` ini

BenchmarkDotNet=v0.13.0, OS=Windows 10.0.19042.1052 (20H2/October2020Update)
Intel Core i7-6820HQ CPU 2.70GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET SDK=5.0.301
  [Host] : .NET 5.0.7 (5.0.721.25508), X64 RyuJIT

Job=InProcess  Toolchain=InProcessEmitToolchain  

```
|           Method |        Mean |     Error |    StdDev |
|----------------- |------------:|----------:|----------:|
| ExpressMapperMap |   723.55 ns |  2.773 ns |  2.594 ns |
|   AgileMapperMap |   457.80 ns |  6.378 ns |  5.654 ns |
|    TinyMapperMap |          NA |        NA |        NA |
|    AutoMapperMap |   322.64 ns |  2.660 ns |  2.358 ns |
|       MapsterMap |    81.67 ns |  0.966 ns |  0.856 ns |
| StaticsMapperMap |    43.66 ns |  0.244 ns |  0.229 ns |
|    FastMapperMap |          NA |        NA |        NA |
| ValueInjecterMap | 6,624.95 ns | 18.459 ns | 17.266 ns |
|    SafeMapperMap |   213.39 ns |  0.459 ns |  0.407 ns |

Benchmarks with issues:
  From_TS0_Members_To_TC0_I0_Members.TinyMapperMap: InProcess(Toolchain=InProcessEmitToolchain)
  From_TS0_Members_To_TC0_I0_Members.FastMapperMap: InProcess(Toolchain=InProcessEmitToolchain)
