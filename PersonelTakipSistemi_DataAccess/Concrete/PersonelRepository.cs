using Microsoft.EntityFrameworkCore;
using PersonelTakipSistemi_DataAccess.Context;
using PersonelTakipSistemi_DataAccess.Repoistory;
using PersonelTakipSistemi_Entites.Model;

namespace PersonelTakipSistemi_DataAccess.Concrete
{
    public class PersonelRepository : GenericRepository<Personel>, IPersonelRepository
    {
        public async Task<List<Personel>> GetPersonellerWithBolumAsync()
        {
            using (PersonelDbContext context = new PersonelDbContext())
            {
                return await context.Personeller.Include(x => x.Bolum).ToListAsync();
            }
        }
    }
}
