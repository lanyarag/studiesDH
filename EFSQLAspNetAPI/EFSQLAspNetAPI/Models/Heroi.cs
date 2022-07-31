namespace EFSQLAspNetAPI.Models
{
    public class Heroi
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        //relacionamento 1:1:
        public IdentidadeSecreta Identidade { get; set; }
        
        //relacionamento n:n
        public List<HeroiBatalha> HeroisBatalhas { get; set; }

        //relacionamento 1:n 
        public List<Arma> Armas { get; set; }
    }
}
