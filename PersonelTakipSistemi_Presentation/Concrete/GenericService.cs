using PersonelTakipSistemi_Business.Abstract;
using PersonelTakipSistemi_DataAccess.Concrete;
using PersonelTakipSistemi_DataAccess.Repoistory;
using PersonelTakipSistemi_Entites.Model;

namespace PersonelTakipSistemi_Business.Concrete
{
    public class GenericService<T> : IGenericService<T> where T : class
    {
        private readonly IGenericRepository<T> repository = new GenericRepository<T>();

        public async Task<T> SEKle(T p)
        {
            return await repository.EKle(p);
        }

        public async Task<T> SGuncelle(T p)
        {
            return await repository.Guncelle(p);
        }

        public async Task<T> SId(Guid id)
        {
            return await repository.Id(id);
        }

        public async Task<List<T>> SListele()
        {
            return await repository.Listele();
        }

        public async Task SSil(Guid id)
        {
            await repository.Sil(id);
        }
    }
}
