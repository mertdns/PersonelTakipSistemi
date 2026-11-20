using PersonelTakipSistemi_Business.Abstract;
using PersonelTakipSistemi_Business.Config;
using PersonelTakipSistemi_DataAccess.Concrete;
using PersonelTakipSistemi_DataAccess.Repoistory;
using PersonelTakipSistemi_DTO.DTOs.Personel;
using PersonelTakipSistemi_Entites.Model;
using System.ComponentModel.DataAnnotations;


namespace PersonelTakipSistemi_Business.Concrete
{
    public class PersonelService : GenericService<Personel>, IPersonelService
    {
        private readonly IPersonelRepository personelRepository = new PersonelRepository();

        public async Task<PersonelListDTO> SEKle(PersonelEkleDTO p)
        {
            if(string.IsNullOrWhiteSpace(p.PersonelAd) || string.IsNullOrWhiteSpace(p.PersonelSoyad))
            {
                throw new ValidationException("Personel adı ve soyadı boş olamaz.");
            }

            if (p.PersonelMaas == null || p.PersonelMaas <= 0)
            {
                throw new ValidationException("Maaş sıfırdan büyük ve doğru formatta olmalıdır.");
            }

            if(p.BolumId == null || p.BolumId == Guid.Empty)
            {
                throw new ValidationException("Personel bölümünü seçiniz.");
            }

            var personel = await personelRepository.EKle(MapperConfig.Mapper.Map<Personel>(p));
            return MapperConfig.Mapper.Map<PersonelListDTO>(personel);
        }

        public async Task<List<PersonelListDTO>> SGetPersonellerWithBolumAsync()
        {
            var personeller = await personelRepository.GetPersonellerWithBolumAsync();
            return MapperConfig.Mapper.Map<List<PersonelListDTO>>(personeller);
        }
    }
}
