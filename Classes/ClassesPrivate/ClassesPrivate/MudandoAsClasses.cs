using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesPrivate
{
    public class MudandoAsClasses
    {
        public double Resultado;

        public MudandoAsClasses()
        {
            Resultado = 0;
        }

        public void EscolherOperacao()
        {
            Console.WriteLine("Escolha a operação que deseja realizar: ");
            Console.WriteLine("1 - Somar");
            Console.WriteLine("2 - Subtrair");
            Console.WriteLine("3 - Multiplicar");
            Console.WriteLine("4 - Dividir");
            Console.WriteLine("5 - Zerar calculadora");
        }
        public void OpcaoDoUser()
        {
            string Opcao = Console.ReadLine();
            switch (Opcao)
            {
                case "1":
                    Console.WriteLine("Você escolheu a operação: Soma");
                    Resultado = Somar();
                    break;
                case "2":
                    Console.WriteLine("Você escolheu a operação: Subtração");
                    Resultado = Subtrair();
                    break;
                case "3":
                    Console.WriteLine("Você escolheu a operação: Multiplicação");
                    Resultado = Multiplicar();
                    break;
                case "4":
                    Console.WriteLine("Você escolheu a operação: Divisão");
                    Resultado = Dividir();
                    break;
                case "5":
                    Console.WriteLine("Zerando calculadora");
                    Resultado = Zerar();
                    break;
                default:
                    Console.WriteLine("CodError002 - O usuário não pode inserir qualquer valor além de números.");
                    break;
            }
        }
        private double Somar()
        {
            Console.WriteLine("Qual valor você deseja somar?");
            double valor = Double.Parse(Console.ReadLine());

            try
            {
                double soma = valor + Resultado;
                return soma;
            }
            catch
            {
                Erro();
                return 0;
            }
        }
        private double Subtrair()
        {
            Console.WriteLine("Qual valor você deseja subtrair?");


            try
            {
                double valor = Double.Parse(Console.ReadLine());
                double subtracao = Resultado - valor;
                return subtracao;
            }
            catch
            {
                Erro();
                return 0;
            }

        }
        private double Multiplicar()
        {
            Console.WriteLine("Qual valor você deseja multiplicar?");
            double valor = Double.Parse(Console.ReadLine());

            try
            {
                double mult = Resultado * valor;
                return mult;
            }
            catch
            {
                Erro();
                return 0;
            }

        }
        private double Dividir()
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
                    double divisao = Resultado / valor;
                    return divisao;
                }

            }
            catch (FormatException erro)
            {
                Erro();
                return 0;
            }
            catch (DivideByZeroException erro)
            {
                Console.WriteLine("CodError001 - Divisão por 0 não é possível.");
                Console.WriteLine(erro.GetType());
                return 0;
            }

        }
        private double Zerar()
        {
            Console.WriteLine("A calculadora foi reiniciada");
            return Resultado = 0;
        }
        private double PegarResultadoDaUltimaOperacao()
        {
            return Resultado;
        }

        private void DefinirResultadoDaUltimaOperacaoMatematica(double resultadoDaOperacao)
        {
            Resultado = resultadoDaOperacao;
        }
        private void Erro()
        {
            Console.WriteLine("CodError002 - O usuário não pode inserir qualquer valor além de números.");
            Console.WriteLine("Localização do erro." + Environment.NewLine);
            Console.WriteLine("Por favor, digite um numero." + Environment.NewLine);
        }
        public void ImprimirResultado()
        {
            Console.WriteLine($"O resultado é {Resultado}");
        }
    }

}