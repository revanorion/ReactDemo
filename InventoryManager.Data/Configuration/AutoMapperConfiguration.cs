using AutoMapper;

namespace InventoryManager.Data.Configuration
{
    public static class AutoMapperConfiguration
    {
        private static bool isConfigured;
        public static IMapper Mapper;
        public static IConfigurationProvider Provider;

        public static void Configure()
        {
            if (isConfigured) return;

            Provider = new MapperConfiguration(cfg =>
            {              

                cfg.CreateMap<Entities.Request, Entities.Request>().ForMember(x => x.RequestItems, opt=>opt.Ignore());               
              
            });

            Mapper = Provider.CreateMapper();
            isConfigured = true;
        }
    }
}
