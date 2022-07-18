namespace RefatoracaoNomeIdade
{
    internal class RefatoracaoNomeIdade
    {
        string NomeDoUsuario;
        int IdadeDoUsuario;
        int AnoAtual;

    public RefatoracaoNomeIdade(string nomeDoUsuario, int idadeDoUsuario, int anoAtual)
        {
            NomeDoUsuario = nomeDoUsuario;
            IdadeDoUsuario = idadeDoUsuario;
            AnoAtual = anoAtual;
        }

        public string RetornaNomeIdade ()
        {
            string mensagem = $"Olá {NomeDoUsuario}, você nasceu em {AnoAtual - IdadeDoUsuario}";
            return mensagem;
        }
    }
}
