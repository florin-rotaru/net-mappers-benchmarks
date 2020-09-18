# NetMappers.Benchmarks
 
``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1082 (1909/November2018Update/19H2)
Intel Core i7-6820HQ CPU 2.70GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.1.402
  [Host] : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT

Job=InProcess  Toolchain=InProcessEmitToolchain  

```
|           Method |       Mean |     Error |    StdDev |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|----------------- |-----------:|----------:|----------:|-------:|------:|------:|----------:|
| ExpressMapperMap | 2,019.3 ns |  11.62 ns |   9.08 ns | 0.9499 |     - |     - |    3985 B |
|   AgileMapperMap |   992.3 ns |  18.30 ns |  21.78 ns | 0.8221 |     - |     - |    3441 B |
|    TinyMapperMap | 3,824.6 ns |  73.86 ns |  57.66 ns | 0.8240 |     - |     - |    3465 B |
|    AutoMapperMap | 2,161.0 ns |  27.41 ns |  25.64 ns | 0.7706 |     - |     - |    3225 B |
|       MapsterMap |   723.7 ns |   9.69 ns |   9.06 ns | 0.7362 |     - |     - |    3080 B |
|     AirMapperMap |   655.9 ns |  12.61 ns |  18.49 ns | 0.7362 |     - |     - |    3080 B |
| HigLaboMapperMap |   527.8 ns |  10.05 ns |   9.40 ns | 0.3977 |     - |     - |    1664 B |
|    FastMapperMap | 5,553.0 ns | 112.82 ns |  88.08 ns | 1.9608 |     - |     - |    8208 B |
| ValueInjecterMap | 4,914.3 ns |  93.43 ns | 107.59 ns | 0.1984 |     - |     - |     840 B |
|   PowerMapperMap |   109.2 ns |   2.11 ns |   1.98 ns | 0.0324 |     - |     - |     136 B |
|    SafeMapperMap | 1,235.2 ns |  16.33 ns |  13.64 ns | 0.9174 |     - |     - |    3840 B |

### More benchmark results
https://github.com/florin-rotaru/NetMappers.Benchmarks/tree/master/NetMappers.Benchmarks/BenchmarksResults/2020.09.18

### Benchmark results summary
|Library             |Passed                  |Failed                  
|--------------------|------------------------|------------------------
|ExpressMapper       |16                      |0                       
|AgileMapper         |16                      |0                       
|TinyMapper          |4                       |12                      
|AutoMapper          |16                      |0                       
|Mapster             |16                      |0                       
|AirMapper           |16                      |0                       
|HigLaboObjectMapper |13                      |3                       
|FastMapper          |1                       |15                      
|ValueInjecter       |8                       |8                       
|PowerMapper         |12                      |4                       
|SafeMapper          |8                       |8                       

- passed: no exception thrown nor differences between source and destination members
- failed: exception thrown or differences found between source and destination members
  - [exceptions](https://github.com/florin-rotaru/NetMappers.Benchmarks/blob/master/NetMappers.Benchmarks/BenchmarksResults/2020.09.18/Failed.Exceptions.md)
  - [diffs](https://github.com/florin-rotaru/NetMappers.Benchmarks/blob/master/NetMappers.Benchmarks/BenchmarksResults/2020.09.18/Failed.Diffs.md)
