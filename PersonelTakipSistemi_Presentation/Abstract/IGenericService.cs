using PersonelTakipSistemi_Entites.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonelTakipSistemi_Business.Abstract
{
    public interface IGenericService<T>
    {
        Task<T> SEKle(T p);
        Task SSil(Guid id);
        Task<T> SGuncelle(T p);
        Task<T> SId(Guid id);
        Task<List<T>> SListele();
    }
}
