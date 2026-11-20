using PersonelTakipSistemi_Business.Abstract;
using PersonelTakipSistemi_Business.Config;
using PersonelTakipSistemi_DataAccess.Concrete;
using PersonelTakipSistemi_DataAccess.Repoistory;
using PersonelTakipSistemi_DTO.DTOs.Bolum;
using PersonelTakipSistemi_Entites.Model;
using System.ComponentModel.DataAnnotations;

namespace PersonelTakipSistemi_Business.Concrete
{
    public class BolumService : GenericService<Bolum>, IBolumService
    {
        private readonly IBolumRepository bolumRepository = new BolumRepository();

        public async Task<BolumListDTO> SEKle(BolumEkleDTO p)
        {
            if (string.IsNullOrWhiteSpace(p.BolumAd))
            {
                throw new ValidationException("Lütfen bölüm adını boş bırakmayın.");
            }

            var bolum = await bolumRepository.EKle(MapperConfig.Mapper.Map<Bolum>(p));
            return MapperConfig.Mapper.Map<BolumListDTO>(bolum);
        }

        public async Task<List<BolumListDTO>> SListele()
        {
            var bolumler = await bolumRepository.Listele();
            return MapperConfig.Mapper.Map<List<BolumListDTO>>(bolumler);
        }
    }
}
