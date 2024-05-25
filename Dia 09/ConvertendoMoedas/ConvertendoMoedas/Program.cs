using System;

namespace ConvertendoMoedas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Para qual moeda você deseja fazer a conversão:\n");
            Console.WriteLine("1) Dólar");
            Console.WriteLine("2) Euro\n");

            int escolhaMoeda;
            double taxaEuro = 0.18;
            double taxaDolar = 0.19;

            if (!int.TryParse(Console.ReadLine(), out escolhaMoeda))
            {
                Console.WriteLine("Escolha uma opção válida (1 ou 2):");
                return;
            }

            if (escolhaMoeda == 1)
            {
                Console.WriteLine("\nQuantos reais você deseja converter para dólares: ");
                double valorEmReais;
                if (!double.TryParse(Console.ReadLine(), out valorEmReais))
                {
                    Console.WriteLine("Insira um valor numérico válido.");
                    return;
                }

                double valorConvertido = valorEmReais * taxaDolar;
                Console.WriteLine($"\nOk, você converteu R${valorEmReais} para ${valorConvertido} dólares.");
            }
            else if (escolhaMoeda == 2)
            {
                Console.WriteLine("\nQuantos euros você deseja converter para reais: ");
                double valorEmEuros;
                if (!double.TryParse(Console.ReadLine(), out valorEmEuros))
                {
                    Console.WriteLine("Insira um valor numérico válido.");
                    return;
                }

                double valorConvertido = valorEmEuros * taxaEuro;
                Console.WriteLine($"\nOk, você converteu €{valorEmEuros} para R${valorConvertido} reais.");
            }
            else
            {
                Console.WriteLine("Escolha uma opção válida (1 ou 2).");
            }
        }
    }
}
