using AutoFixture;
using AutoMapper;
using BenchmarkDotNet.Attributes;
using Mapster;
using Models;
using SafeMapper;
using System.Linq;

namespace NetMappers.Benchmarks
{
    [InProcess]
    public class FromToN0<S, D> where D : new()
    {
        private readonly S _source;
        private readonly IMapper _autoMapper;
        private readonly Fixture _fixture;
        //private readonly RoslynMapper.IMapEngine _roslynMapper;

        S NewSource() =>
            Air.Mapper.Mapper<TC0_Members, S>.Map(_fixture.Create<TC0_Members>());

        public FromToN0()
        {
            _fixture = new Fixture();
            _fixture.Behaviors.OfType<ThrowingRecursionBehavior>().ToList()
                .ForEach(b => _fixture.Behaviors.Remove(b));
            _fixture.Behaviors.Add(new OmitOnRecursionBehavior());

            var customization = new SupportMutableValueTypesCustomization();
            customization.Customize(_fixture);

            _source = NewSource();

            var mapperConfig = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<S, D>();
            });
            _autoMapper = mapperConfig.CreateMapper();

            Nelibur.ObjectMapper.TinyMapper.Bind<S, D>();

            ExpressMapper.Mapper.Register<S, D>();

            //_roslynMapper = RoslynMapper.MapEngine.DefaultInstance;
            //_roslynMapper.SetMapper<S, D>();
            //_roslynMapper.Build();
        }

        [Benchmark]
        public D ExpressMapperMap() => ExpressMapper.Mapper.Map<S, D>(_source);

        [Benchmark]
        public D AgileMapperMap() => AgileObjects.AgileMapper.Mapper.Map(_source).ToANew<D>();

        [Benchmark]
        public D TinyMapperMap() => Nelibur.ObjectMapper.TinyMapper.Map<D>(_source);

        [Benchmark]
        public D AutoMapperMap() => _autoMapper.Map<D>(_source);

        [Benchmark]
        public D MapsterMap() => _source.Adapt<D>();

        [Benchmark]
        public D AirMapperMap() => Air.Mapper.Mapper<S, D>.Map(_source);

        [Benchmark]
        public D HigLaboMapperMap() => HigLabo.Core.ObjectMapper.Default.Map(_source, new D());

        [Benchmark]
        public D FastMapperMap() => FastMapper.NetCore.TypeAdapter.Adapt<S, D>(_source);

        [Benchmark]
        public D ValueInjecterMap() => Omu.ValueInjecter.Mapper.Map<S, D>(_source);

        [Benchmark]
        public D PowerMapperMap() => PowerMapper.Mapper.Map<S, D>(_source);

        [Benchmark]
        public D SafeMapperMap() => SafeMap.Convert<S, D>(_source);

        //[Benchmark]
        //public D RoslynMapperMap() => _roslynMapper.Map<S, D>(_source);
    }
}
