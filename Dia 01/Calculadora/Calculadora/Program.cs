using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Olá, qual operação você deseja fazer? \n");
                Console.WriteLine("1) +");  
                Console.WriteLine("2) -");
                Console.WriteLine("3) *");
                Console.WriteLine("4) /");

                int operacao = int.Parse(Console.ReadLine());

                if (operacao < 1 || operacao > 4)
                {
                    Console.WriteLine("Opção inválida.");
                    return;
                }

                Console.WriteLine("Entre com o primeiro valor: \n");
                int primeiroValor = int.Parse(Console.ReadLine());

                Console.WriteLine("Entre com o segundo valor: \n");
                int segundoValor = int.Parse(Console.ReadLine());

                int resultado;

                switch (operacao)
                {
                    case 1:
                        resultado = primeiroValor + segundoValor;
                        Console.WriteLine("O resultado é: " + resultado);
                        break;
                    case 2:
                        resultado = primeiroValor - segundoValor;
                        Console.WriteLine("O resultado é: " + resultado);
                        break;
                    case 3:
                        resultado = primeiroValor * segundoValor;
                        Console.WriteLine("O resultado é: " + resultado);
                        break;
                    case 4:
                        if (segundoValor == 0)
                        {
                            Console.WriteLine("Erro: Divisão por zero não é permitida.");
                        }
                        else
                        {
                            resultado = primeiroValor / segundoValor;
                            Console.WriteLine("O resultado é: " + resultado);
                        }
                        break;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Erro: Entrada inválida. Por favor, insira números inteiros.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
            }
        }
    }
}
