namespace EFSQLAspNetAPI.Models
{
    public class IdentidadeSecreta
    {
        public int Id { get; set; }
        public int NomeReal { get; set; }
        public string HeroiId { get; set; }
        public Heroi Heroi { get; set; }
    }
}
