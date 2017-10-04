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
            
            isConfigured = true;
        }
    }
}
