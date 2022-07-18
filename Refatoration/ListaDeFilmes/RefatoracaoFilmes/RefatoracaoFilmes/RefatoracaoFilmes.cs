
namespace RefatoracaoFilmes
{
    public class RefatoracaoFilmes
    {
        public String[] ListaDeFilmes;

        //Precisa de um construtor - classe letra maiúscula, instância letra minúscula
        public RefatoracaoFilmes(String[] listaDeFilmes)
        {
            ListaDeFilmes = listaDeFilmes;
        }
        public string apresentaTodosOsFilmesSeparadosPorPontoVirgula()
        {
            //Usa letra maiúscula porque o da instância não existe aqui
            return string.Join("; ", ListaDeFilmes);
        }

        public int quantidadeTotalDeFilmes()
        {
            return ListaDeFilmes.Length;
        }

        public string buscarNomeDoFilmePeloIndice(int indiceDoFilme)
        {
            return ListaDeFilmes[indiceDoFilme];
        }
        public String[] adicionaUmNovoFilmePeloSeuNome(string nomeDoFilme)
        {
            ListaDeFilmes = ListaDeFilmes.Append(nomeDoFilme).ToArray();
            return ListaDeFilmes;
        }

        public String[] atualizarUmFilmePeloSeuIndice(int indiceDoFilme, string nomeDoFilme)
        {
            ListaDeFilmes[indiceDoFilme] = nomeDoFilme;
            return ListaDeFilmes;
        }

        public String[] listarTodosOsFilmesComSeuIndiceNaLista()
        {
            for (int i = 0; i < ListaDeFilmes.Length; i++)
            {
                Console.WriteLine($"O filme {ListaDeFilmes[i]} está na posição {i}");
            }
            return ListaDeFilmes;
        }
    }
}
