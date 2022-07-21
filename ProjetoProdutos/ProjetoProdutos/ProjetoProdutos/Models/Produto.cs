namespace ProjetoProdutos.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string NomeProduto { get; set; }
        public string Descricao { get; set; }
        public string Categoria { get; set; }
        public int Quantidade { get; set; }
        public double Preco { get; set; }
        public Produto() { }
        public Produto(int id, string nomeProduto, string descricao, string categoria, int quantidade, double preco)
        {
            Id = id;
            NomeProduto = nomeProduto;
            Descricao = descricao;
            Categoria = categoria;
            Quantidade = quantidade;
            Preco = preco;
        }
    }
}
