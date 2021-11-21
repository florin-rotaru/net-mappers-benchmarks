using AutoFixture;
using AutoMapper;
using BenchmarkDotNet.Attributes;
using Mapster;
using Models;
using System.Linq;

namespace NetMappers.Benchmarks
{
    [InProcess]
    public class FromToN1<S, D>
        where D : new()
    {
        private readonly S _source;
        private readonly IMapper _autoMapper;
        private readonly Fixture _fixture;
        //private readonly RoslynMapper.IMapEngine _roslynMapper;

        S NewSource() =>
            Statics.Mapper.Mapper<TC1, S>.Map(_fixture.Create<TC1>());

        public FromToN1()
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

            });
            _autoMapper = mapperConfig.CreateMapper();

            Nelibur.ObjectMapper.TinyMapper.Bind<S, D>();

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

            ExpressMapper.Mapper.Register<S, D>();

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

            //_roslynMapper = RoslynMapper.MapEngine.DefaultInstance;
            //_roslynMapper.SetMapper<S, D>();

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
        public D StaticsMapperMap() => Statics.Mapper.Mapper<S, D>.Map(_source);

        //[Benchmark]
        //public D HigLaboMapperMap() => HigLabo.Core.ObjectMapper.Default.Map(_source, new D());

        [Benchmark]
        public D FastMapperMap() => FastMapper.NetCore.TypeAdapter.Adapt<S, D>(_source);

        [Benchmark]
        public D ValueInjecterMap() => Omu.ValueInjecter.Mapper.Map<S, D>(_source);

        //[Benchmark]
        //public D PowerMapperMap() => PowerMapper.Mapper.Map<S, D>(_source);

        //[Benchmark]
        //public D SafeMapperMap() => SafeMap.Convert<S, D>(_source);

        //[Benchmark]
        //public D RoslynMapperMap() => _roslynMapper.Map<S, D>(_source);
    }
}
