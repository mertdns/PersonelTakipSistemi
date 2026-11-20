using AutoMapper;
using PersonelTakipSistemi_DTO.DTOs.Bolum;
using PersonelTakipSistemi_Entites.Model;

namespace PersonelTakipSistemi_Business.Mapping
{
    public class BolumMap : Profile
    {
        public BolumMap()
        {
            CreateMap<Bolum, BolumListDTO>().ReverseMap();
            CreateMap<Bolum, BolumEkleDTO>().ReverseMap();
            CreateMap<BolumListDTO, BolumEkleDTO>().ReverseMap();
        }
    }
}