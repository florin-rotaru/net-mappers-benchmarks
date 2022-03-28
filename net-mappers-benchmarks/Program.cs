using AgileObjects.AgileMapper.Extensions;
using AutoFixture;
using AutoMapper;
using BenchmarkDotNet.Running;
using Mapster;
using Models;
using Statics.Compare;
using Statics.Mapper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace NetMappers.Benchmarks
{
    public class Program
    {
        private static Fixture _fixture;
        private static IMapper _autoMapper;
        //private static RoslynMapper.IMapEngine _roslynMapper;

        static internal string GetProjectPath()
            => Directory.GetCurrentDirectory();
       
        static internal string GetBenchmarksResultsPath() 
            => Path.Combine(GetProjectPath(), "BenchmarksResults");

        static void CopyDirectory(string sourceDir, string destinationDir, bool recursive)
        {
            // Get information about the source directory
            var dir = new DirectoryInfo(sourceDir);

            // Check if the source directory exists
            if (!dir.Exists)
                throw new DirectoryNotFoundException($"Source directory not found: {dir.FullName}");

            // Cache directories before we start copying
            DirectoryInfo[] dirs = dir.GetDirectories();

            // Create the destination directory
            Directory.CreateDirectory(destinationDir);

            // Get the files in the source directory and copy to the destination directory
            foreach (FileInfo file in dir.GetFiles())
            {
                string targetFilePath = Path.Combine(destinationDir, file.Name);
                file.CopyTo(targetFilePath);
            }

            // If recursive and copying subdirectories, recursively call this method
            if (recursive)
            {
                foreach (DirectoryInfo subDir in dirs)
                {
                    string newDestinationDir = Path.Combine(destinationDir, subDir.Name);
                    CopyDirectory(subDir.FullName, newDestinationDir, true);
                }
            }
        }

        private static void Main(string[] args)
        {
            //ManualConfig config = ManualConfig
            //.Create(DefaultConfig.Instance)
            //.WithOptions(ConfigOptions.DisableOptimizationsValidator);


            BenchmarkRunner.Run<From_Account_To_AccountDto>();

            BenchmarkRunner.Run<From_TC0_Members_To_TC0_I0_Members>();

            BenchmarkRunner.Run<From_TC0_Members_To_TC0_I1_Members>();
            BenchmarkRunner.Run<From_TC0_Members_To_TC0_I2_Nullable_Members>();

            BenchmarkRunner.Run<From_TC0_Members_To_TS0_I0_Members>();
            BenchmarkRunner.Run<From_TC0_Members_To_TS0_I1_Members>();
            BenchmarkRunner.Run<From_TC0_Members_To_TS0_I2_Nullable_Members>();

            BenchmarkRunner.Run<From_TS0_Members_To_TC0_I0_Members>();
            BenchmarkRunner.Run<From_TS0_Members_To_TC0_I1_Members>();
            BenchmarkRunner.Run<From_TS0_Members_To_TC0_I2_Nullable_Members>();

            BenchmarkRunner.Run<From_TS0_Members_To_TS0_I0_Members>();
            BenchmarkRunner.Run<From_TS0_Members_To_TS0_I1_Members>();
            BenchmarkRunner.Run<From_TS0_Members_To_TS0_I2_Nullable_Members>();

            BenchmarkRunner.Run<From_TC1_To_TC1_0>();
            BenchmarkRunner.Run<From_TC1_To_TS1_0>();

            BenchmarkRunner.Run<From_TS1_To_TC1_0>();
            BenchmarkRunner.Run<From_TS1_To_TS1_0>();

            var currentResultsPath = Path.Combine(GetProjectPath(), "BenchmarkDotNet.Artifacts", "results");
            var benchmarksResultsPath = Path.Combine(GetBenchmarksResultsPath(), DateTime.Now.ToString("yyyy.MM.dd"));

            if (Directory.Exists(benchmarksResultsPath))
                Directory.Delete(benchmarksResultsPath, true);

            CopyDirectory(currentResultsPath, benchmarksResultsPath, true);

            ConfigureMappers();
            
            WriteTestResults(
                benchmarksResultsPath,
                GetTestResults<Account, AccountDto>(_fixture.Create<Account>())
                .Concat(GetTestResults<TC0_Members, TC0_I0_Members>(_fixture.Create<TC0_Members>()))
                .Concat(GetTestResults<TC0_Members, TC0_I1_Members>(_fixture.Create<TC0_Members>()))
                .Concat(GetTestResults<TC0_Members, TC0_I2_Nullable_Members>(_fixture.Create<TC0_Members>()))

                .Concat(GetTestResults<TC0_Members, TS0_I0_Members>(_fixture.Create<TC0_Members>()))
                .Concat(GetTestResults<TC0_Members, TS0_I1_Members>(_fixture.Create<TC0_Members>()))
                .Concat(GetTestResults<TC0_Members, TS0_I2_Nullable_Members>(_fixture.Create<TC0_Members>()))

                .Concat(GetTestResults<TS0_Members, TC0_I0_Members>(Mapper<TC0_Members, TS0_Members>.Map(_fixture.Create<TC0_Members>())))
                .Concat(GetTestResults<TS0_Members, TC0_I1_Members>(Mapper<TC0_Members, TS0_Members>.Map(_fixture.Create<TC0_Members>())))
                .Concat(GetTestResults<TS0_Members, TC0_I2_Nullable_Members>(Mapper<TC0_Members, TS0_Members>.Map(_fixture.Create<TC0_Members>())))

                .Concat(GetTestResults<TS0_Members, TS0_I0_Members>(Mapper<TC0_Members, TS0_Members>.Map(_fixture.Create<TC0_Members>())))
                .Concat(GetTestResults<TS0_Members, TS0_I1_Members>(Mapper<TC0_Members, TS0_Members>.Map(_fixture.Create<TC0_Members>())))
                .Concat(GetTestResults<TS0_Members, TS0_I2_Nullable_Members>(Mapper<TC0_Members, TS0_Members>.Map(_fixture.Create<TC0_Members>())))

                .Concat(GetTestResults<TC1, TC1_0>(_fixture.Create<TC1>()))
                .Concat(GetTestResults<TC1, TS1_0>(_fixture.Create<TC1>()))

                .Concat(GetTestResults<TS1, TC1_0>(Mapper<TC1, TS1>.Map(_fixture.Create<TC1>())))
                .Concat(GetTestResults<TS1, TS1_0>(Mapper<TC1, TS1>.Map(_fixture.Create<TC1>())))
                );

            Console.ReadLine();
        }

        private static void ConfigureMappers()
        {
            _fixture = new Fixture();

            var mapperConfig = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Address, AddressDto>();
                cfg.CreateMap<Product, ProductDto>();
                cfg.CreateMap<OrderItem, OrderItemDto>();
                cfg.CreateMap<Order, OrderDto>();
                cfg.CreateMap<Account, AccountDto>();

                cfg.CreateMap<TC0_Members, TC0_I0_Members>();
                cfg.CreateMap<TC0_Members, TC0_I1_Members>();
                cfg.CreateMap<TC0_Members, TC0_I2_Nullable_Members>();

                cfg.CreateMap<TC0_Members, TS0_I0_Members>();
                cfg.CreateMap<TC0_Members, TS0_I1_Members>();
                cfg.CreateMap<TC0_Members, TS0_I2_Nullable_Members>();

                cfg.CreateMap<TS0_Members, TC0_I0_Members>();
                cfg.CreateMap<TS0_Members, TC0_I1_Members>();
                cfg.CreateMap<TS0_Members, TC0_I2_Nullable_Members>();

                cfg.CreateMap<TS0_Members, TS0_I0_Members>();
                cfg.CreateMap<TS0_Members, TS0_I1_Members>();
                cfg.CreateMap<TS0_Members, TS0_I2_Nullable_Members>();

                cfg.CreateMap<TC1, TC1_0>();
                cfg.CreateMap<TC1, TS1_0>();

                cfg.CreateMap<TS1, TC1_0>();
                cfg.CreateMap<TS1, TS1_0>();

            });
            _autoMapper = mapperConfig.CreateMapper();

            Nelibur.ObjectMapper.TinyMapper.Bind<Address, AddressDto>();
            Nelibur.ObjectMapper.TinyMapper.Bind<Product, ProductDto>();
            Nelibur.ObjectMapper.TinyMapper.Bind<OrderItem, OrderItemDto>();
            Nelibur.ObjectMapper.TinyMapper.Bind<Order, OrderDto>();
            Nelibur.ObjectMapper.TinyMapper.Bind<Account, AccountDto>();

            Nelibur.ObjectMapper.TinyMapper.Bind<TC0_Members, TC0_I0_Members>();
            Nelibur.ObjectMapper.TinyMapper.Bind<TC0_Members, TC0_I1_Members>();
            Nelibur.ObjectMapper.TinyMapper.Bind<TC0_Members, TC0_I2_Nullable_Members>();

            Nelibur.ObjectMapper.TinyMapper.Bind<TC0_Members, TS0_I0_Members>();
            Nelibur.ObjectMapper.TinyMapper.Bind<TC0_Members, TS0_I1_Members>();
            Nelibur.ObjectMapper.TinyMapper.Bind<TC0_Members, TS0_I2_Nullable_Members>();

            Nelibur.ObjectMapper.TinyMapper.Bind<TS0_Members, TC0_I0_Members>();
            Nelibur.ObjectMapper.TinyMapper.Bind<TS0_Members, TC0_I1_Members>();
            Nelibur.ObjectMapper.TinyMapper.Bind<TS0_Members, TC0_I2_Nullable_Members>();

            Nelibur.ObjectMapper.TinyMapper.Bind<TS0_Members, TS0_I0_Members>();
            Nelibur.ObjectMapper.TinyMapper.Bind<TS0_Members, TS0_I1_Members>();
            Nelibur.ObjectMapper.TinyMapper.Bind<TS0_Members, TS0_I2_Nullable_Members>();

            Nelibur.ObjectMapper.TinyMapper.Bind<TC1, TC1_0>();
            Nelibur.ObjectMapper.TinyMapper.Bind<TC1, TS1_0>();

            Nelibur.ObjectMapper.TinyMapper.Bind<TS1, TC1_0>();
            Nelibur.ObjectMapper.TinyMapper.Bind<TS1, TS1_0>();


            ExpressMapper.Mapper.Register<Address, AddressDto>();
            ExpressMapper.Mapper.Register<Product, ProductDto>();
            ExpressMapper.Mapper.Register<OrderItem, OrderItemDto>();
            ExpressMapper.Mapper.Register<Order, OrderDto>();
            ExpressMapper.Mapper.Register<Account, AccountDto>();

            ExpressMapper.Mapper.Register<TC0_Members, TC0_I0_Members>();
            ExpressMapper.Mapper.Register<TC0_Members, TC0_I1_Members>();
            ExpressMapper.Mapper.Register<TC0_Members, TC0_I2_Nullable_Members>();

            ExpressMapper.Mapper.Register<TC0_Members, TS0_I0_Members>();
            ExpressMapper.Mapper.Register<TC0_Members, TS0_I1_Members>();
            ExpressMapper.Mapper.Register<TC0_Members, TS0_I2_Nullable_Members>();

            ExpressMapper.Mapper.Register<TS0_Members, TC0_I0_Members>();
            ExpressMapper.Mapper.Register<TS0_Members, TC0_I1_Members>();
            ExpressMapper.Mapper.Register<TS0_Members, TC0_I2_Nullable_Members>();

            ExpressMapper.Mapper.Register<TS0_Members, TS0_I0_Members>();
            ExpressMapper.Mapper.Register<TS0_Members, TS0_I1_Members>();
            ExpressMapper.Mapper.Register<TS0_Members, TS0_I2_Nullable_Members>();

            ExpressMapper.Mapper.Register<TC1, TC1_0>();
            ExpressMapper.Mapper.Register<TC1, TS1_0>();

            ExpressMapper.Mapper.Register<TS1, TC1_0>();
            ExpressMapper.Mapper.Register<TS1, TS1_0>();

            //_roslynMapper = RoslynMapper.MapEngine.DefaultInstance;
            //_roslynMapper.SetMapper<Address, AddressDto>();
            //_roslynMapper.SetMapper<Product, ProductDto>();
            //_roslynMapper.SetMapper<OrderItem, OrderItemDto>();
            //_roslynMapper.SetMapper<Order, OrderDto>();
            //_roslynMapper.SetMapper<Account, AccountDto>();

            //_roslynMapper.SetMapper<TC0_Members, TC0_I0_Members>();
            //_roslynMapper.SetMapper<TC0_Members, TC0_I1_Members>();
            //_roslynMapper.SetMapper<TC0_Members, TC0_I2_Nullable_Members>();

            //_roslynMapper.SetMapper<TC0_Members, TS0_I0_Members>();
            //_roslynMapper.SetMapper<TC0_Members, TS0_I1_Members>();
            //_roslynMapper.SetMapper<TC0_Members, TS0_I2_Nullable_Members>();

            //_roslynMapper.SetMapper<TS0_Members, TC0_I0_Members>();
            //_roslynMapper.SetMapper<TS0_Members, TC0_I1_Members>();
            //_roslynMapper.SetMapper<TS0_Members, TC0_I2_Nullable_Members>();

            //_roslynMapper.SetMapper<TS0_Members, TS0_I0_Members>();
            //_roslynMapper.SetMapper<TS0_Members, TS0_I1_Members>();
            //_roslynMapper.SetMapper<TS0_Members, TS0_I2_Nullable_Members>();

            //_roslynMapper.SetMapper<TC1, TC1_0>();
            //_roslynMapper.SetMapper<TC1, TS1_0>();

            //_roslynMapper.SetMapper<TS1, TC1_0>();
            //_roslynMapper.SetMapper<TS1, TS1_0>();

            //_roslynMapper.Build();
        }

        class TestResult
        {
            public string Library { get; set; }
            public Type SourceType { get; set; }
            public Type DestinationType { get; set; }
            public bool Err { get; set; }
            public IEnumerable<MemberDiff> Diffs { get; set; }
        }

        private static IEnumerable<TestResult> GetTestResults<S, D>(S source) where D : new()
        {
            List<TestResult> testResults = new();

            new Dictionary<string, Func<D>>
            {
                { nameof(ExpressMapper), () => ExpressMapper.Mapper.Map<S, D>(source) },
                { nameof(AgileObjects.AgileMapper), () => AgileObjects.AgileMapper.Mapper.Map(source).ToANew<D>() },
                //{ nameof(Nelibur.ObjectMapper.TinyMapper), () => Nelibur.ObjectMapper.TinyMapper.Map<D>(source) },
                { nameof(AutoMapper), () => _autoMapper.Map<D>(source) },
                { nameof(Mapster), () => source.Adapt<D>() },
                { $"{nameof(Statics)}{nameof(Statics.Mapper)}", () => Mapper<S, D>.Map(source) },
                { $"{nameof(HigLabo)}{nameof(HigLabo.Core.ObjectMapper)}", () => HigLabo.Core.ObjectMapper.Default.Map(source, new D()) },
                { nameof(FastMapper), () => FastMapper.NetCore.TypeAdapter.Adapt<S, D>(source) },
                { nameof(Omu.ValueInjecter), () => Omu.ValueInjecter.Mapper.Map<S, D>(source) },
                { nameof(PowerMapper), () => PowerMapper.Mapper.Map<S, D>(source) }
                //{ nameof(SafeMapper), () => SafeMap.Convert<S, D>(source) }
                //{ nameof(RoslynMapper), () => _roslynMapper.Map<S, D>(source) }
            }.ForEach(test =>
            {
                var testResult = new TestResult
                {
                    Library = test.Key,
                    SourceType = typeof(S),
                    DestinationType = typeof(D)
                };

                try
                {
                    var destination = test.Value();
                    Members.CompareEquals(
                        source,
                        destination,
                        out IEnumerable<MemberDiff> memberDiffs,
                        evaluateChildNodes: true);

                    testResult.Diffs = memberDiffs;
                }
                catch
                {
                    testResult.Err = true;
                }

                testResults.Add(testResult);
            });

            return testResults;
        }

        private static void WriteTestResults(string resultsPath, IEnumerable<TestResult> testResults)
        {
            if (File.Exists(Path.Combine(resultsPath, "Summary.md")))
                File.Delete(Path.Combine(resultsPath, "Summary.md"));

            using (StreamWriter summary = new(Path.Combine(resultsPath, "Summary.md")))
            {
                Console.WriteLine("Results");
                summary.WriteLine("# Results");

                Console.WriteLine("|{0,-20}|{1,-24}|{2,-24}",
                    "Library",
                    "Passed",
                    "Failed");
                summary.WriteLine("|{0,-20}|{1,-24}|{2,-24}",
                    "Library",
                    "Passed",
                    "Failed");
                summary.WriteLine($"|{new string('-', 20)}|{new string('-', 24)}|{new string('-', 24)}");

                testResults
                    .GroupBy(g => g.Library)
                    .Select(grp => new
                    {
                        library = $"{grp.Key}",
                        passed = $"{grp.Count(r => !r.Err && !r.Diffs.Any())}",
                        failed = $"{grp.Count(r => r.Err || r.Diffs.Any())}"
                    })
                .ForEach(r =>
                    {
                        Console.WriteLine("|{0,-20}|{1,-24}|{2,-24}",
                            r.library,
                            r.passed,
                            r.failed);
                        summary.WriteLine("|{0,-20}|{1,-24}|{2,-24}",
                            r.library,
                            r.passed,
                            r.failed);

                    });
            }

            Console.WriteLine();
            Console.WriteLine();

            if (File.Exists(Path.Combine(resultsPath, "Failed.Exceptions.md")))
                File.Delete(Path.Combine(resultsPath, "Failed.Exceptions.md"));

            using (StreamWriter failedExceptions = new(Path.Combine(resultsPath, "Failed.Exceptions.md")))
            {
                Console.WriteLine("Failed - Exceptions");
                failedExceptions.WriteLine("# Failed - Exceptions");

                Console.WriteLine("|{0,-20}|{1,-24}|{2,-24}",
                    "Library",
                    "Source",
                    "Destination");
                failedExceptions.WriteLine("|{0,-20}|{1,-24}|{2,-24}",
                    "Library",
                    "Source",
                    "Destination");
                failedExceptions.WriteLine($"|{new string('-', 20)}|{new string('-', 24)}|{new string('-', 24)}");

                testResults
                    .Where(r => r.Err)
                    .OrderBy(r => r.Library)
                    .ForEach(r =>
                        {
                            Console.WriteLine("|{0,-20}|{1,-24}|{2,-24}",
                                r.Library,
                                r.SourceType.Name,
                                r.DestinationType.Name);
                            failedExceptions.WriteLine("|{0,-20}|{1,-24}|{2,-24}",
                                r.Library,
                                r.SourceType.Name,
                                r.DestinationType.Name);
                        });
            }

            Console.WriteLine();
            Console.WriteLine();

            if (File.Exists(Path.Combine(resultsPath, "Failed.Diffs.md")))
                File.Delete(Path.Combine(resultsPath, "Failed.Diffs.md"));

            using (StreamWriter failedDiffs = new(Path.Combine(resultsPath, "Failed.Diffs.md")))
            {
                Console.WriteLine("Failed - Diffs");
                failedDiffs.WriteLine("# Failed - Exceptions");

                Console.WriteLine("|{0,-20}|{1,-24}|{2,-24}|{3,-26}|{4,-26}|{5,-128}",
                    "Library",
                    "Source",
                    "Destination",
                    "Source Member",
                    "Destination Member",
                    "Details");
                failedDiffs.WriteLine("|{0,-20}|{1,-24}|{2,-24}|{3,-26}|{4,-26}|{5,-128}",
                    "Library",
                    "Source",
                    "Destination",
                    "Source Member",
                    "Destination Member",
                    "Details");
                failedDiffs.WriteLine($"|{new string('-', 20)}|{new string('-', 24)}|{new string('-', 24)}|{new string('-', 26)}|{new string('-', 26)}|{new string('-', 128)}");

                testResults
                    .Where(r => r.Diffs != null && r.Diffs.Any())
                    .OrderBy(r => r.Library)
                    .ForEach(r =>
                        r.Diffs.ForEach(d =>
                        {
                            Console.WriteLine("|{0,-20}|{1,-24}|{2,-24}|{3,-26}|{4,-26}|{5,-128}",
                                r.Library,
                                r.SourceType.Name,
                                r.DestinationType.Name,
                                d.LeftMember,
                                d.RightMember,
                                d.Details);
                            failedDiffs.WriteLine("|{0,-20}|{1,-24}|{2,-24}|{3,-26}|{4,-26}|{5,-128}",
                                r.Library,
                                r.SourceType.Name,
                                r.DestinationType.Name,
                                d.LeftMember,
                                d.RightMember,
                                d.Details);
                        }));
            }
        }
    }
}
