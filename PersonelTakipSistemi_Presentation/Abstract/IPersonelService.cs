using PersonelTakipSistemi_DTO.DTOs.Personel;
using PersonelTakipSistemi_Entites.Model;

namespace PersonelTakipSistemi_Business.Abstract
{
    public interface IPersonelService : IGenericService<Personel>
    {
        Task<List<PersonelListDTO>> SGetPersonellerWithBolumAsync();
        Task<PersonelListDTO> SEKle(PersonelEkleDTO p);

    }
}
