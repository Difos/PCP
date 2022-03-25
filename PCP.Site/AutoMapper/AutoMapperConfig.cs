using AutoMapper;

namespace PCP.Site.AutoMapper
{
    public class AutoMapperConfig
    {
        public static IMapper Mapper { get; set; }

        public static void RegisterMappings()
        {
            var mapperConfiguration = new MapperConfiguration(
               config =>
               {
                   config.AddProfile<AutoMapperProfiles>();
               });

            Mapper = mapperConfiguration.CreateMapper();
        }
    }
}