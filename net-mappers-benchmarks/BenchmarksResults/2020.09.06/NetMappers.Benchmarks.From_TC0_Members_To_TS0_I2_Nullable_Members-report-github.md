``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1016 (1909/November2018Update/19H2)
Intel Core i7-6820HQ CPU 2.70GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.1.401
  [Host] : .NET Core 3.1.7 (CoreCLR 4.700.20.36602, CoreFX 4.700.20.37001), X64 RyuJIT

Job=InProcess  Toolchain=InProcessEmitToolchain  

```
|           Method |        Mean |     Error |    StdDev |
|----------------- |------------:|----------:|----------:|
| ExpressMapperMap | 4,031.23 ns | 38.008 ns | 35.553 ns |
|   AgileMapperMap |   549.25 ns |  9.851 ns |  9.214 ns |
|    TinyMapperMap |          NA |        NA |        NA |
|    AutoMapperMap |   541.88 ns |  8.161 ns |  7.634 ns |
|       MapsterMap |   129.53 ns |  2.399 ns |  2.244 ns |
|     StaticsMapperMap |    88.97 ns |  1.132 ns |  1.003 ns |
| HigLaboMapperMap |   575.44 ns |  7.115 ns |  5.941 ns |
|    FastMapperMap |          NA |        NA |        NA |

Benchmarks with issues:
  From_TC0_Members_To_TS0_I2_Nullable_Members.TinyMapperMap: InProcess(Toolchain=InProcessEmitToolchain)
  From_TC0_Members_To_TS0_I2_Nullable_Members.FastMapperMap: InProcess(Toolchain=InProcessEmitToolchain)
