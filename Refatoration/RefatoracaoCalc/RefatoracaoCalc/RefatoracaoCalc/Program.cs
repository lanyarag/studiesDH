namespace RefatoracaoCalc
{
    public class Program
    {
        public static void Main()
        {
            RefatoracaoCalc calculadoraComum = new RefatoracaoCalc();

            while (true)
            {
                calculadoraComum.EscolherOperacao();
                calculadoraComum.OpcaoDoUser();
                calculadoraComum.ImprimirResultado();
            }
        }
    }
}

