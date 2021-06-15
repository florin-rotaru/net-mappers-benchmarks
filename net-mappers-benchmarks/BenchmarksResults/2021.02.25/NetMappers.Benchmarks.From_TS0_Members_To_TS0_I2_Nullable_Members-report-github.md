``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1379 (1909/November2018Update/19H2)
Intel Core i7-6820HQ CPU 2.70GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=5.0.103
  [Host] : .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT

Job=InProcess  Toolchain=InProcessEmitToolchain  

```
|           Method |        Mean |     Error |    StdDev |
|----------------- |------------:|----------:|----------:|
| ExpressMapperMap | 4,200.39 ns | 13.048 ns | 12.205 ns |
|   AgileMapperMap |   558.80 ns |  5.572 ns |  5.212 ns |
|    TinyMapperMap |          NA |        NA |        NA |
|    AutoMapperMap |   654.25 ns |  1.424 ns |  1.332 ns |
|       MapsterMap |   128.29 ns |  0.301 ns |  0.251 ns |
|     StaticsMapperMap |    82.33 ns |  0.258 ns |  0.216 ns |
|    FastMapperMap |          NA |        NA |        NA |
| ValueInjecterMap | 2,409.33 ns | 11.128 ns | 10.409 ns |
|    SafeMapperMap |   255.88 ns |  0.868 ns |  0.812 ns |

Benchmarks with issues:
  From_TS0_Members_To_TS0_I2_Nullable_Members.TinyMapperMap: InProcess(Toolchain=InProcessEmitToolchain)
  From_TS0_Members_To_TS0_I2_Nullable_Members.FastMapperMap: InProcess(Toolchain=InProcessEmitToolchain)
