``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1016 (1909/November2018Update/19H2)
Intel Core i7-6820HQ CPU 2.70GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.1.401
  [Host] : .NET Core 3.1.7 (CoreCLR 4.700.20.36602, CoreFX 4.700.20.37001), X64 RyuJIT

Job=InProcess  Toolchain=InProcessEmitToolchain  

```
|           Method |        Mean |     Error |    StdDev |
|----------------- |------------:|----------:|----------:|
| ExpressMapperMap |   338.23 ns |  2.553 ns |  2.838 ns |
|   AgileMapperMap |   270.62 ns |  5.425 ns |  8.446 ns |
|    TinyMapperMap | 1,055.96 ns | 20.886 ns | 22.348 ns |
|    AutoMapperMap |   437.66 ns |  6.015 ns |  6.177 ns |
|       MapsterMap |   100.77 ns |  1.810 ns |  1.693 ns |
|     AirMapperMap |    58.75 ns |  0.884 ns |  0.738 ns |
| HigLaboMapperMap |   501.75 ns |  9.816 ns |  9.641 ns |
|    FastMapperMap |          NA |        NA |        NA |

Benchmarks with issues:
  From_TC0_Members_To_TC0_I2_Nullable_Members.FastMapperMap: InProcess(Toolchain=InProcessEmitToolchain)
