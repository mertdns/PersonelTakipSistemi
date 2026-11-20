using PersonelTakipSistemi_DTO.DTOs.Bolum;
using PersonelTakipSistemi_Entites.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonelTakipSistemi_Business.Abstract
{
    public interface IBolumService : IGenericService<Bolum>
    {
        Task<BolumListDTO> SEKle(BolumEkleDTO p);
        Task<List<BolumListDTO>> SListele();
    }
}
