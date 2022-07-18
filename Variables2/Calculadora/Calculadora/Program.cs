double resultado = 0;
resultado = pegarResultadoDaUltimaOperacaoMatematica();

while (true)
{
    Opcao();
    Calcular();
    Console.WriteLine($"Resultado = {resultado}");
}

double somarvalor()
{
    Console.WriteLine("Qual valor você deseja somar?");
    double valor = Double.Parse(Console.ReadLine());

    try
    {
        double soma = valor + resultado;
        return soma;
    }
    catch
    {
        Erro2();
        return 0;
    }
}

double subtrairValor()
{
    Console.WriteLine("Qual valor você deseja subtrair?");


    try
    {
        double valor = Double.Parse(Console.ReadLine());
        double subtracao = resultado - valor;
        return subtracao;
    }
    catch
    {
        Erro2();
        return 0;
    }

}

double dividirValor()
{
    Console.WriteLine("Qual valor você deseja dividir?");

    try
    {
        double valor = Double.Parse(Console.ReadLine());
        if (valor == 0)
        {
            throw new DivideByZeroException();
        }
        else
        {
            double divisao = resultado / valor;
            return divisao;
        }

    }
    catch (FormatException erro)
    {
        Erro2();
        return 0;
    }
    catch (DivideByZeroException erro)
    {
        Console.WriteLine("CodError001 - Divisão por 0 não é possível.");
        Console.WriteLine(erro.GetType());
        return 0;
    }

}

    double multiplicarValor()
    {
        Console.WriteLine("Qual valor você deseja multiplicar?");
        double valor = Double.Parse(Console.ReadLine());

        try
        {
            double mult = resultado * valor;
            return mult;
        }
        catch
        {
            Erro2();
            return 0;
        }

    }

    double zerarResultado()
    {
        Console.WriteLine("A calculadora foi reiniciada");
        return resultado = 0;
    }

    double pegarResultadoDaUltimaOperacaoMatematica()
    {
        return resultado;
    }

    void definirResultadoDaUltimaOperacaoMatematica(double resultadoDaOperacao)
    {
        resultado = resultadoDaOperacao;
    }

    void Opcao()
    {
        Console.WriteLine("Escolha qual operação deseja realizar:");
        Console.WriteLine("1 - Somar");
        Console.WriteLine("2 - Subtrair");
        Console.WriteLine("3 - Multiplicar");
        Console.WriteLine("4 - Dividir");
        Console.WriteLine("5 - Zerar calculadora");
    }

    void Calcular()
    {
        string opcao = Console.ReadLine();
        double result;

        switch (opcao)
        {
            case "1":
                result = somarvalor();
                definirResultadoDaUltimaOperacaoMatematica(result);
                break;
            case "2":
                result = subtrairValor();
                definirResultadoDaUltimaOperacaoMatematica(result);
                break;
            case "3":
                result = multiplicarValor();
                definirResultadoDaUltimaOperacaoMatematica(result);
                break;
            case "4":
                result = dividirValor();
                definirResultadoDaUltimaOperacaoMatematica(result);
                break;

            case "5":
                result = zerarResultado();
                definirResultadoDaUltimaOperacaoMatematica(result);
                break;

            default:
                Console.WriteLine(Environment.NewLine + "CodError002 - O usuário não pode inserir qualquer valor além de números.");
                //    Console.WriteLine(erro.GetType());
                Console.WriteLine("Localização do erro." + Environment.NewLine);
                Console.WriteLine("Por favor, digite um numero." + Environment.NewLine);
                break;
        }

    }

    void Erro2()
    {
        Console.WriteLine("CodError002 - O usuário não pode inserir qualquer valor além de números.");
        Console.WriteLine("Localização do erro." + Environment.NewLine);
        Console.WriteLine("Por favor, digite um numero." + Environment.NewLine);
    }







