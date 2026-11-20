using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace PersonelTakipSistemi_Entites.Model
{
    public class Personel
    {
        [Key]
        public Guid PersonelId { get; set; }

        [StringLength(50)]
        public string PersonelAd { get; set; }

        [StringLength(50)]
        public string PersonelSoyad { get; set; }

        public decimal PersonelMaas { get; set; }

        public string? PersonelAdres { get; set; }

        public Guid BolumId { get; set; }


        [ForeignKey(nameof(BolumId))]
        public Bolum Bolum { get; set; }
    }
}
