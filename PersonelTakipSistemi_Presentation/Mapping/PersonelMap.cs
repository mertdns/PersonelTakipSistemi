using AutoMapper;
using PersonelTakipSistemi_DTO.DTOs.Personel;
using PersonelTakipSistemi_Entites.Model;

namespace PersonelTakipSistemi_Business.Mapping
{
    public class PersonelMap : Profile
    {
        public PersonelMap()
        {
            CreateMap<Personel, PersonelEkleDTO>().ReverseMap();
            CreateMap<Personel, PersonelListDTO>()
                .ForMember(dest => dest.BolumAd, opt => opt.MapFrom(src => src.Bolum.BolumAd))
                .ReverseMap()
                .ForMember(dest => dest.Bolum, opt => opt.Ignore()); // Ters dönüşümde Bolum nesnesini boş bırakır        }
        }
    }
}
