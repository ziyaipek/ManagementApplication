using System.Collections.Generic;
using AutoMapper;
using Business.Utilities.Mapping.Interface;

namespace Business.Utilities.Mapping
{
    public class MapperHelper : IMapperHelper
    {
        private readonly IMapper _mapper;

        public MapperHelper()
        {
            // AutoMapper profillerini tanımlama
            var profiles = new List<Profile>
            {
                new Profiles()
                // Buraya diğer profilleri ekleyebilirsiniz
            };

            // Mapper konfigürasyonunu oluşturma
            var config = new MapperConfiguration(cfg =>
            {
                foreach (var profile in profiles)
                {
                    cfg.AddProfile(profile);
                }
            });

            _mapper = config.CreateMapper();
        }

        // Tekil nesne haritalama
        public TDestination Map<TDestination>(object? source)
        {
            return _mapper.Map<TDestination>(source);
        }

        // Var olan nesneleri haritalama
        public void Map(object? source, object? destination)
        {
            _mapper.Map(source, destination);
        }

        // Liste haritalama
        public IList<TDestination> MapList<TSource, TDestination>(IList<TSource> source)
        {
            return _mapper.Map<IList<TDestination>>(source);
        }
    }
}
