using EFSQLAspNetAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace EFSQLAspNetAPI.Data
{
    public class HeroiContext: DbContext
    {
        public DbSet<Heroi> Herois { get; set; }
        public DbSet<Batalha> Batalhas { get; set; }
        public DbSet<Arma> Armas { get; set; }
        public DbSet<HeroiBatalha> HeroisBatalhas { get; set; }
        public DbSet<IdentidadeSecreta> IdentidadesSecretas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = @"Data Source=(LocalDb)\MSSQLLocalDB;Initial Catalog=HeroApp;Integrated Security=True";

            optionsBuilder.UseSqlServer(connectionString);
        }

        //Criando a chave composta 
        protected override void OnModelCreating(ModelBuilder modelBuider)
        {
            modelBuider.Entity<HeroiBatalha>(entity =>
            {
                //A entidade tem uma chave composta pela chave de Batalha e de Heroi
                entity.HasKey(e => new { e.BatalhaId, e.HeroiId });
            });
        }
    }
}
