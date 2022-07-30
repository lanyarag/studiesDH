using Microsoft.EntityFrameworkCore;

namespace CatalogoInMemory.Models
{
    public class CatalogContext : DbContext
    {
        public CatalogContext(DbContextOptions<CatalogContext> options) : base(options)
        { }

        //Add tables in Db
        public DbSet<ActorModel> Actors { get; set; }
        public DbSet<MovieModel> Movies { get; set; }
    }
}
