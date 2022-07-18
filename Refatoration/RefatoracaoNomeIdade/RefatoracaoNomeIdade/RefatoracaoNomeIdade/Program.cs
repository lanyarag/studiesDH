namespace RefatoracaoNomeIdade
{
    public class Program
    {
        public static void Main()
        {
            RefatoracaoNomeIdade usuario = new RefatoracaoNomeIdade("João", 22, 2022);
            Console.WriteLine(usuario.RetornaNomeIdade());

            Console.WriteLine("Qual o nome do usuário?");
            string nomeDoUsuario = Console.ReadLine();
            Console.WriteLine("Qual a idade do usuário?");
            int idadeDoUsuario = Convert.ToInt32(Console.ReadLine());
            int anoAtual = 2022;
            RefatoracaoNomeIdade usuario2 = new RefatoracaoNomeIdade(nomeDoUsuario, idadeDoUsuario, anoAtual);
            Console.WriteLine(usuario2.RetornaNomeIdade());


        }
    }
}