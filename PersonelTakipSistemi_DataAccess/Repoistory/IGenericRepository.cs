using PersonelTakipSistemi_Entites.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonelTakipSistemi_DataAccess.Repoistory
{
    public interface IGenericRepository<T>
    {
        Task<T> EKle(T p);
        Task Sil(Guid id);
        Task<T> Id(Guid id);
        Task<T> Guncelle(T p);
        Task<List<T>> Listele();
    }
}
