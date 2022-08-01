using Microsoft.EntityFrameworkCore;

namespace RevisaoAPI.Model
{
    public class SistemaContext: DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Residencia> Residencias { get; set; }

        protected override void OnModelCreating(ModelBuilder Modelagem)
        {
            Modelagem.Entity<Usuario>(Tabela =>
            {
                Tabela.HasKey(Propriedade => Propriedade.Id);
                Tabela.HasMany(Propriedade => Propriedade.Residencias);
            });

            Modelagem.Entity<Residencia>(Tabela =>
            {
                Tabela.HasKey(Propriedade => Propriedade.Id);
            });
        }
        protected override void OnConfiguring(DbContextOptionsBuilder Configurar)
        {
            string conecstring = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            Configurar.UseSqlServer(conecstring);
        }
    }
}
