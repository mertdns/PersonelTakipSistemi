using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using PersonelTakipSistemi_Entites.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonelTakipSistemi_DataAccess.Context
{
    public class PersonelDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=(localdb)\\MSSQLLocalDB; database=PersonelDb; Trusted_Connection=true; TrustServerCertificate=true;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("Turkish_CI_AS");

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Personel> Personeller { get; set; }
        public DbSet<Bolum> Bolumler { get; set; }
    }
}
