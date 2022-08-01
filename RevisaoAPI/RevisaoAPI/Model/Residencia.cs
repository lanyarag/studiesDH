namespace RevisaoAPI.Model
{
    public class Residencia
    {
        public int Id { get; set; }
        public string Logradouro { get; set; }
        public int Numero { get; set; }
        public int Bairro { get; set; }
        public string? Cep { get; set; }
        public Usuario? Usuario { get; set; }
    }
}
