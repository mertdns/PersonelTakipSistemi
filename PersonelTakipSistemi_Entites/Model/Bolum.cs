using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PersonelTakipSistemi_Entites.Model
{
    public class Bolum
    {
        [Key]
        public Guid BolumId { get; set; }

        public string BolumAd { get; set; }

        public List<Personel> Personeller { get; set; }
    }
}
