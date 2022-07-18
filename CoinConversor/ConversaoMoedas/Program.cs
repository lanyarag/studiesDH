namespace ConversaoMoedas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Moeda conversaoDaCompra = new Moeda();

            Console.WriteLine("Qual valor em real você deseja converter?");
            decimal valorEmReal = decimal.Parse (Console.ReadLine());

            Console.WriteLine("Para qual moeda?");
            string moeda = Console.ReadLine();


            conversaoDaCompra.ConversaoMoeda(moeda, valorEmReal);


        }
    }
}