using AutoMapper;

namespace Application.MapperSetup
{
    public static class AutoMapperConfig
    {
        public static MapperConfiguration RegisterMappings()
        {
            return new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new DtoToModel());
                cfg.AddProfile(new ModelToDto());
            });
        }
    }
}
