string retornarDiagnosticoDoUsuario(double alturaDoUsuario, double pesoDoUsuario)
{
    double imc = pesoDoUsuario / (alturaDoUsuario * alturaDoUsuario);

    if (imc < 18.5)
    {
        string diagnostico = "";
        diagnostico = "anêmico";
        return diagnostico;
    }
    else if (imc < 24.9)
    {
        string diagnostico = "";
        diagnostico = "normal";
        return diagnostico;
    }
    else if (imc < 29.9)
    {
        string diagnostico = "";
        diagnostico = "sobrepeso";
        return diagnostico;
    }
    else if (imc < 40)
    {
        string diagnostico = "";
        diagnostico = "obeso";
        return diagnostico;
    }
    else
    {
        string diagnostico = "";
        diagnostico = "muito obeso";
        return diagnostico;
    }
}

Console.WriteLine($"Seu diagnóstico é {retornarDiagnosticoDoUsuario(1.7, 105)}");
