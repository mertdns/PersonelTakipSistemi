
namespace PersonelTakipSistemi_DTO.DTOs.Personel
{
    public class PersonelEkleDTO
    {
        public string PersonelAd { get; set; }
        public string PersonelSoyad { get; set; }
        public decimal? PersonelMaas { get; set; }
        public string? PersonelAdres { get; set; }
        public Guid? BolumId { get; set; }
    }
}
