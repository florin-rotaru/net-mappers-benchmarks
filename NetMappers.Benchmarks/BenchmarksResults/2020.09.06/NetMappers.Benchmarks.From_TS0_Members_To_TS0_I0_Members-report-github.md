``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1016 (1909/November2018Update/19H2)
Intel Core i7-6820HQ CPU 2.70GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.1.401
  [Host] : .NET Core 3.1.7 (CoreCLR 4.700.20.36602, CoreFX 4.700.20.37001), X64 RyuJIT

Job=InProcess  Toolchain=InProcessEmitToolchain  

```
|           Method |        Mean |     Error |    StdDev |
|----------------- |------------:|----------:|----------:|
| ExpressMapperMap | 2,794.93 ns | 38.150 ns | 35.686 ns |
|   AgileMapperMap |   549.99 ns |  0.666 ns |  0.591 ns |
|    TinyMapperMap |          NA |        NA |        NA |
|    AutoMapperMap |   399.09 ns |  6.780 ns |  6.342 ns |
|       MapsterMap |   104.23 ns |  1.652 ns |  1.545 ns |
|     AirMapperMap |    44.28 ns |  0.511 ns |  0.453 ns |
| HigLaboMapperMap |   173.40 ns |  3.097 ns |  2.897 ns |
|    FastMapperMap |          NA |        NA |        NA |

Benchmarks with issues:
  From_TS0_Members_To_TS0_I0_Members.TinyMapperMap: InProcess(Toolchain=InProcessEmitToolchain)
  From_TS0_Members_To_TS0_I0_Members.FastMapperMap: InProcess(Toolchain=InProcessEmitToolchain)
