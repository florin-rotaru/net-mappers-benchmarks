using AutoFixture;
using AutoMapper;
using BenchmarkDotNet.Attributes;
using Mapster;
using Models;
using System.Linq;

namespace NetMappers.Benchmarks
{
    [InProcess]
    [MemoryDiagnoser]
    public class From_Account_To_AccountDto
    {
        private readonly Account _source;
        private readonly IMapper _autoMapper;
        private readonly Fixture _fixture;

        public From_Account_To_AccountDto()
        {
            _fixture = new Fixture();
            _fixture.Behaviors.OfType<ThrowingRecursionBehavior>().ToList()
                .ForEach(b => _fixture.Behaviors.Remove(b));
            _fixture.Behaviors.Add(new OmitOnRecursionBehavior());

            var customization = new SupportMutableValueTypesCustomization();
            customization.Customize(_fixture);

            _source = _fixture.Create<Account>();

            var mapperConfig = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Address, AddressDto>();
                cfg.CreateMap<Product, ProductDto>();
                cfg.CreateMap<OrderItem, OrderItemDto>();
                cfg.CreateMap<Order, OrderDto>();
                cfg.CreateMap<Account, AccountDto>();
            });
            _autoMapper = mapperConfig.CreateMapper();

            Nelibur.ObjectMapper.TinyMapper.Bind<Address, AddressDto>();
            Nelibur.ObjectMapper.TinyMapper.Bind<Product, ProductDto>();
            Nelibur.ObjectMapper.TinyMapper.Bind<OrderItem, OrderItemDto>();
            Nelibur.ObjectMapper.TinyMapper.Bind<Order, OrderDto>();
            Nelibur.ObjectMapper.TinyMapper.Bind<Account, AccountDto>();

            ExpressMapper.Mapper.Register<Address, AddressDto>();
            ExpressMapper.Mapper.Register<Product, ProductDto>();
            ExpressMapper.Mapper.Register<OrderItem, OrderItemDto>();
            ExpressMapper.Mapper.Register<Order, OrderDto>();
            ExpressMapper.Mapper.Register<Account, AccountDto>();
        }

        [Benchmark]
        public AccountDto ExpressMapperMap() => ExpressMapper.Mapper.Map<Account, AccountDto>(_source);

        [Benchmark]
        public AccountDto AgileMapperMap() => AgileObjects.AgileMapper.Mapper.Map(_source).ToANew<AccountDto>();

        [Benchmark]
        public AccountDto TinyMapperMap() => Nelibur.ObjectMapper.TinyMapper.Map<AccountDto>(_source);

        [Benchmark]
        public AccountDto AutoMapperMap() => _autoMapper.Map<AccountDto>(_source);

        [Benchmark]
        public AccountDto MapsterMap() => _source.Adapt<AccountDto>();

        [Benchmark]
        public AccountDto AirMapperMap() => Air.Mapper.Mapper<Account, AccountDto>.Map(_source);

        [Benchmark]
        public AccountDto HigLaboMapperMap() => HigLabo.Core.ObjectMapper.Default.Map(_source, new AccountDto());

        [Benchmark]
        public AccountDto FastMapperMap() => FastMapper.NetCore.TypeAdapter.Adapt<Account, AccountDto>(_source);
    }
}
