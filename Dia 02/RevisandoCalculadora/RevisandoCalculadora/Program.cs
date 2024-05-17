using System;

namespace RevisandoCalculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha um operador: ");
            Console.WriteLine("1) + 2) - 3) * 4) / ");


            int operacao = int.Parse(Console.ReadLine());
            Console.WriteLine("O operador escolhido foi: " + operacao);

            if (operacao < 1 || operacao > 4)
            {
                Console.WriteLine("Operador inválido. Programa será encerrado.");
                Console.WriteLine("Pressione qualquer tecla para sair...");
                Console.ReadKey();
                Environment.Exit(0);
            }

            Console.WriteLine("Agora digite o primeiro número: ");
            int primeiroNumero = int.Parse(Console.ReadLine());
            Console.WriteLine("Agora digite o segundo número: ");
            int segundoNumero = int.Parse(Console.ReadLine());



            if (operacao == 1)
            {
                int resultado = primeiroNumero + segundoNumero;
                Console.WriteLine("O resultado é: " + resultado);
            }
            else if (operacao == 2)
            {
                int resultado = primeiroNumero - segundoNumero;
                Console.WriteLine("O resultado é: " + resultado);
            }
            else if (operacao == 3)
            {
                int resultado = primeiroNumero * segundoNumero;
                Console.WriteLine("O resultado é: " + resultado);
            }
            else if (operacao == 4)
            {
                int resultado = primeiroNumero / segundoNumero;
                Console.WriteLine("O resultado é: " + resultado);
            }


            else
            {
                Console.WriteLine("Nenhum operador selecionado");
            }
            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}