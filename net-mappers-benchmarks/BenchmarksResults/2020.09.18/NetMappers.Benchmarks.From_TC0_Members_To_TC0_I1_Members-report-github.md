``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1082 (1909/November2018Update/19H2)
Intel Core i7-6820HQ CPU 2.70GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.1.402
  [Host] : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT

Job=InProcess  Toolchain=InProcessEmitToolchain  

```
|           Method |        Mean |     Error |    StdDev |
|----------------- |------------:|----------:|----------:|
| ExpressMapperMap |   181.08 ns |  3.047 ns |  2.850 ns |
|   AgileMapperMap |   223.88 ns |  3.846 ns |  3.597 ns |
|    TinyMapperMap |   123.78 ns |  2.468 ns |  2.743 ns |
|    AutoMapperMap |   169.90 ns |  3.376 ns |  2.992 ns |
|       MapsterMap |    60.54 ns |  0.359 ns |  0.300 ns |
|     StaticsMapperMap |    25.37 ns |  0.588 ns |  0.824 ns |
| HigLaboMapperMap |    91.83 ns |  0.109 ns |  0.091 ns |
|    FastMapperMap |          NA |        NA |        NA |
| ValueInjecterMap | 8,377.83 ns | 89.230 ns | 79.100 ns |
|   PowerMapperMap |    77.93 ns |  1.409 ns |  1.318 ns |
|    SafeMapperMap |   191.05 ns |  2.603 ns |  2.307 ns |

Benchmarks with issues:
  From_TC0_Members_To_TC0_I1_Members.FastMapperMap: InProcess(Toolchain=InProcessEmitToolchain)
