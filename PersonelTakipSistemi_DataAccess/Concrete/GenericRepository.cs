using Microsoft.EntityFrameworkCore;
using PersonelTakipSistemi_DataAccess.Context;
using PersonelTakipSistemi_DataAccess.Repoistory;

namespace PersonelTakipSistemi_DataAccess.Concrete
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        public readonly PersonelDbContext context = new();
        private readonly DbSet<T> Table;

        public GenericRepository()
        {
            this.Table = context.Set<T>();
        }

        public async Task<T> EKle(T p)
        {
            await Table.AddAsync(p);
            await context.SaveChangesAsync();
            return p;
        }

        public async Task<T> Guncelle(T p)
        {
            Table.Update(p);
            await context.SaveChangesAsync();
            return p;
        }

        public async Task<T> Id(Guid id)
        {
            return await Table.FindAsync(id);
        }

        public async Task<List<T>> Listele()
        {
            return await Table.ToListAsync();
        }

        public async Task Sil(Guid id)
        {
            var entity = await Table.FindAsync(id);
            Table.Remove(entity);
            await context.SaveChangesAsync();
        }
    }
}
