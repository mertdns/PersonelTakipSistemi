using AutoMapper;
using Microsoft.Extensions.Logging.Abstractions;

namespace PersonelTakipSistemi_Business.Config
{
    public static class MapperConfig
    {
        public static IMapper Mapper { get; private set; }

        static MapperConfig()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddMaps(typeof(MapperConfig).Assembly);
            }, NullLoggerFactory.Instance);

            Mapper = config.CreateMapper();
        }

    }
}
