namespace RefatoracaoFilmes
{
    public class Program
    {
        public static void Main()
        {
            String[] listaDeFilmes = { "Clube dos Cinco", "A Hora do Pesadelo", "Karatê Kid", "Rocky IV", "Conan, o Bárbaro", "Highlander" };
            
            //cria uma nova instância e coloca como parâmetro o que você colocou no construtor, para ela conseguir associar nos métodos da classe
            RefatoracaoFilmes filmes = new RefatoracaoFilmes(listaDeFilmes);

            Console.WriteLine("1.1. Apresenta todos os filmes da lista separados por ponto e vírgula");
            Console.WriteLine(filmes.apresentaTodosOsFilmesSeparadosPorPontoVirgula());

            Console.WriteLine("1.2.Apresentar quantidade de filmes da lista");
            Console.WriteLine(filmes.quantidadeTotalDeFilmes());


            Console.WriteLine("1.3.Buscar o nome do filme de acordo com seu índice");
            Console.WriteLine(filmes.buscarNomeDoFilmePeloIndice(3));

            Console.WriteLine("1.4.Adiciona um novo filme a lista pelo seu nome");
            filmes.adicionaUmNovoFilmePeloSeuNome("Black Orpheus");
            Console.WriteLine(filmes.apresentaTodosOsFilmesSeparadosPorPontoVirgula());

            Console.WriteLine("1.5. Atualiza um filme a partir do seu índice na lista");
            filmes.atualizarUmFilmePeloSeuIndice(3, "A Wonderful Life");
            Console.WriteLine(filmes.apresentaTodosOsFilmesSeparadosPorPontoVirgula());


            Console.WriteLine("1.6.Listar todos os filmes com seu índice/posição na lista");
            filmes.listarTodosOsFilmesComSeuIndiceNaLista();

        }

    }
}
