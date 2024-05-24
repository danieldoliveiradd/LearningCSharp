using System;

namespace Funcoes
{
    class Program
    {
        static void Main(string[] args)
        {
            MercadinhoDesenvolvedor();
        }

        static void MercadinhoDesenvolvedor()
        {
            Console.WriteLine("Olá, seja bem vindo ao Mercadinho do Desenvolvedor");
            Console.WriteLine("Para visualizar a tabela de preços, digite 'Sim'. Para fechar a tabela de preços, digite 'Não'. \n");

            string opcaoUsuario = Console.ReadLine().Trim();
            Console.WriteLine("");

            if(opcaoUsuario.Equals("Sim", StringComparison.OrdinalIgnoreCase))
            {
                PrecoProduto("Arroz", 35);
                PrecoProduto("Leite", 16);
                PrecoProduto("Feijão", 20);
                PrecoProduto("Macarrão", 10);
                PrecoProduto("Açúcar", 8);
                PrecoProduto("Café", 12);
                PrecoProduto("Óleo", 15);
                PrecoProduto("Farinha", 7);
                PrecoProduto("Sal", 2);
                PrecoProduto("Molho de Tomate", 5);
            }
            else if (opcaoUsuario.Equals("Nao", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Tabela fechada!");
            }
            else
            {
                Console.WriteLine("Opção inválida! Por favor, digite 'Sim' ou 'Não'.");
            }
        }

        static void PrecoProduto(string produto, decimal preco)
        {
            // Console.WriteLine("O valor do " + produto + " é de: " + preco + " BRL.");
            Console.WriteLine($"O valor do {produto} é de: {preco:F2} BRL.");
        }

    }
    
}