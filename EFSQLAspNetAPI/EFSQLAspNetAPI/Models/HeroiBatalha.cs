namespace EFSQLAspNetAPI.Models
{
    //Criação de uma classe para representar a tabela que intermedia a relação N:N entre heróis e batalhas
    public class HeroiBatalha
    {
        public int HeroiId { get; set; }
        public int Batalha { get; set; }
        public Heroi Heroi { get; set; }
        public Batalha BatalhaId { get; set; }
    }
}
