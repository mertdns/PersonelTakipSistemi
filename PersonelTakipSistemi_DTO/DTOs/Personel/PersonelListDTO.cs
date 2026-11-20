using System;
using System.Collections.Generic;
using System.Text;

namespace PersonelTakipSistemi_DTO.DTOs.Personel
{
    public class PersonelListDTO
    {
        public string PersonelAd { get; set; }
        public string PersonelSoyad { get; set; }
        public decimal PersonelMaas { get; set; }
        public string? PersonelAdres { get; set; }
        public string BolumAd { get; set; }
    }
}
