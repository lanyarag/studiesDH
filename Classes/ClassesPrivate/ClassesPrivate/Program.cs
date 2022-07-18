namespace ClassesPrivate
{
    public class Program
    {
        public static void Main()
        {
            MudandoAsClasses calculadoraComum = new MudandoAsClasses();

            while (true)
            {
                calculadoraComum.EscolherOperacao();
                calculadoraComum.OpcaoDoUser();
                calculadoraComum.ImprimirResultado();
            }
        }
    }
}
