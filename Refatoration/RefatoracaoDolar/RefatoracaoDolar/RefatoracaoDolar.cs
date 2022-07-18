namespace RefatoracaoDolar
{
    public class RefatoracaoDolar
    {
        public double CotacaoDoDolarHoje;
        public const double VALOR_MINIMO_DE_COMPRA_EM_DOLAR = 100;
        public const double VALOR_MAXIMO_DE_COMPRA_EM_DOLAR = 2500;
        public double ValorDaCompraEmReais;
        public double ValorConvertido;

        public RefatoracaoDolar(double valorDaCompraEmReais, double cotacao)
        {
            ValorDaCompraEmReais = valorDaCompraEmReais;
            CotacaoDoDolarHoje = cotacao;
            ValorConvertido = ValorDaCompraEmReais / CotacaoDoDolarHoje;
        }

        public string mensagem()
        {
            
            if (ValorConvertido < VALOR_MINIMO_DE_COMPRA_EM_DOLAR)
            {
                return $"A compra mínima permitida é de $ {VALOR_MINIMO_DE_COMPRA_EM_DOLAR}";
            }
            else if (ValorConvertido > VALOR_MAXIMO_DE_COMPRA_EM_DOLAR)
            {
                return $"A compra máxima permitida é de $ {VALOR_MAXIMO_DE_COMPRA_EM_DOLAR}";
            }
            else
            {
                return $"Você pode comprar {ValorConvertido}";
            }
        }


    }
}
