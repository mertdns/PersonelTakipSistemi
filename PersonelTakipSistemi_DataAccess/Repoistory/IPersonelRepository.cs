using PersonelTakipSistemi_Entites.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonelTakipSistemi_DataAccess.Repoistory
{
    public interface IPersonelRepository : IGenericRepository<Personel>
    {
        Task<List<Personel>> GetPersonellerWithBolumAsync();
    }
}
