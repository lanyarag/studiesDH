namespace RevisaoAPI.Model
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public List<Residencia>? Residencias { get; set; }
    }
}
