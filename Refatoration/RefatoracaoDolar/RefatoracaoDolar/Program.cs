namespace RefatoracaoDolar
{
    public class Program
    {
        public static void Main()
        {
            RefatoracaoDolar compra = new RefatoracaoDolar(1500, 4.97);
            Console.WriteLine(compra.mensagem());
            Console.WriteLine("Insira o valor da compra: ");
            double compraEmReais = Double.Parse(Console.ReadLine());
            double cotacao = 4.97;
            RefatoracaoDolar compra2 = new RefatoracaoDolar(compraEmReais, cotacao);
            Console.WriteLine(compra2.mensagem());
        }
    }
}