namespace ConversaoMoedas
{
    public class Moeda
    {
        string nome;
        Dictionary<string, decimal> valorCotacao = new Dictionary<string, decimal>();


        public Moeda()
        {
            valorCotacao.Add("dolar", 4.65m);
            valorCotacao.Add("euro", 6.20m);
            valorCotacao.Add("iene", 0.052m);
            valorCotacao.Add("libra", 6.95m);

        }

        

        public void ConversaoMoeda(string moeda, decimal valorEmReal) 
        {
            decimal cotacao = valorCotacao[moeda];

            decimal valor = valorEmReal / cotacao;

            Console.WriteLine($"O valor convertido é {valor}");

        }


    }
}
