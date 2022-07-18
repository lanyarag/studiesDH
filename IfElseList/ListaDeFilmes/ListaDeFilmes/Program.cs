// Essa é a lista de filmes disponibilizada pelo professor inicialmente.
String[] listaDeFilmes = {"Clube dos Cinco", "A Hora do Pesadelo","Karatê Kid", "Rocky IV", "Conan, o Bárbaro", "Highlander"};

Console.WriteLine("1.1. Apresenta todos os filmes da lista separados por ponto e vírgula");

string apresentaTodosOsFilmesSeparadosPorPontoVirgula()
{
        return string.Join("; ", listaDeFilmes);
}
Console.WriteLine(apresentaTodosOsFilmesSeparadosPorPontoVirgula());

Console.WriteLine("1.2.Apresentar quantidade de filmes da lista");

int quantidadeTotalDeFilmes()
{
    return listaDeFilmes.Length;
}
Console.WriteLine(quantidadeTotalDeFilmes());

Console.WriteLine("1.3.Buscar o nome do filme de acordo com seu índice");

string buscarNomeDoFilmePeloIndice(int indiceDoFilme)
{
    return listaDeFilmes[indiceDoFilme];
}
Console.WriteLine(buscarNomeDoFilmePeloIndice(3));

Console.WriteLine("1.4.Adiciona um novo filme a lista pelo seu nome");

String [] adicionaUmNovoFilmePeloSeuNome(string nomeDoFilme)
{
    listaDeFilmes = listaDeFilmes.Append(nomeDoFilme).ToArray();
    return listaDeFilmes;  
}

adicionaUmNovoFilmePeloSeuNome("Black Orpheus");
Console.WriteLine(apresentaTodosOsFilmesSeparadosPorPontoVirgula());

Console.WriteLine("1.5. Atualiza um filme a partir do seu índice na lista");

String[] atualizarUmFilmePeloSeuIndice(int indiceDoFilme, string nomeDoFilme)
{
    listaDeFilmes[indiceDoFilme] = nomeDoFilme;
    return listaDeFilmes;
}
atualizarUmFilmePeloSeuIndice(3, "A Wonderful Life");
Console.WriteLine(apresentaTodosOsFilmesSeparadosPorPontoVirgula());

Console.WriteLine("1.6.Listar todos os filmes com seu índice/posição na lista");

String[] listarTodosOsFilmesComSeuIndiceNaLista()
{
   for (int i = 0; i < listaDeFilmes.Length; i++)
    {
        Console.WriteLine($"O filme {listaDeFilmes[i]} está na posição {i}");
    }
   return listaDeFilmes;
}
listarTodosOsFilmesComSeuIndiceNaLista();
