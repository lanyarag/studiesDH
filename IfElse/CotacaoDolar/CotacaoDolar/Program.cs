// Cotação do dólar no dia 3 de maio de 2022.
double cotacaoDoDolarHoje = 4.97;
const double VALOR_MINIMO_DE_COMPRA_EM_DOLAR = 100;
const double VALOR_MAXIMO_DE_COMPRA_EM_DOLAR = 2500;
string converterRealParaDolar(double valorDaCompraEmReais)
{
    double valorDaCompra = valorDaCompraEmReais / cotacaoDoDolarHoje;
    if (valorDaCompra < 100)
    {
        string mensagem = "";
        return mensagem = ($"A compra mínima permitida é de $ {VALOR_MINIMO_DE_COMPRA_EM_DOLAR}");
    }
    else if (valorDaCompra > 2500)
    {
        string mensagem = "";
        return mensagem = ($"A compra máxima permitida é de $ {VALOR_MAXIMO_DE_COMPRA_EM_DOLAR}");
    }
    else
    {
        string mensagem = "";
        return mensagem = ($"Você pode comprar {valorDaCompra}");
    }
}

Console.WriteLine(converterRealParaDolar(1500));
Console.WriteLine(converterRealParaDolar(300));
Console.WriteLine(converterRealParaDolar(1500000));
