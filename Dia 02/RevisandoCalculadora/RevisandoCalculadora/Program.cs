using System; // Importando o namespace System, que contém classes fundamentais.

namespace RevisandoCalculadora // Definindo o namespace do projeto.
{
    class Program // Definindo a classe Program.
    {
        static void Main(string[] args) // Método principal, ponto de entrada do programa.
        {
            Console.WriteLine("Escolha um operador: "); // Exibindo uma mensagem para o usuário escolher um operador.
            Console.WriteLine("1) + 2) - 3) * 4) / "); // Exibindo as opções de operadores.

            int operacao = int.Parse(Console.ReadLine()); // Lendo a entrada do usuário, convertendo de string para int, e armazenando na variável operacao.
            Console.WriteLine("O operador escolhido foi: " + operacao); // Exibindo a escolha do operador.
            if (operacao < 1 || operacao > 4) // Verificando se a escolha do operador é válida.
            {
                Console.WriteLine("Operador inválido. Programa será encerrado."); // Exibindo mensagem de erro se o operador for inválido.
                Console.WriteLine("Pressione qualquer tecla para sair..."); // Instruindo o usuário a pressionar qualquer tecla para sair.
                Console.ReadKey(); // Aguardando o pressionamento de uma tecla.
                Environment.Exit(0); // Encerrando o programa.
            }

            Console.WriteLine("Agora digite o primeiro número: "); // Solicitando ao usuário o primeiro número.
            int primeiroNumero = int.Parse(Console.ReadLine()); // Lendo o primeiro número digitado pelo usuário e armazenando na variável primeiroNumero.
            Console.WriteLine("Agora digite o segundo número: "); // Solicitando ao usuário o segundo número.
            int segundoNumero = int.Parse(Console.ReadLine()); // Lendo o segundo número digitado pelo usuário e armazenando na variável segundoNumero.

            if (operacao == 1) // Verificando se o operador escolhido é a soma.
            {
                int resultado = primeiroNumero + segundoNumero; // Calculando a soma dos números.
                Console.WriteLine("O resultado é: " + resultado); // Exibindo o resultado da soma.
            }
            else if (operacao == 2) // Verificando se o operador escolhido é a subtração.
            {
                int resultado = primeiroNumero - segundoNumero; // Calculando a subtração dos números.
                Console.WriteLine("O resultado é: " + resultado); // Exibindo o resultado da subtração.
            }
            else if (operacao == 3) // Verificando se o operador escolhido é a multiplicação.
            {
                int resultado = primeiroNumero * segundoNumero; // Calculando a multiplicação dos números.
                Console.WriteLine("O resultado é: " + resultado); // Exibindo o resultado da multiplicação.
            }
            else if (operacao == 4) // Verificando se o operador escolhido é a divisão.
            {
                int resultado = primeiroNumero / segundoNumero; // Calculando a divisão dos números.
                Console.WriteLine("O resultado é: " + resultado); // Exibindo o resultado da divisão.
            }
            Console.WriteLine("Pressione qualquer tecla para sair..."); // Instruindo o usuário a pressionar qualquer tecla para sair.
            Console.ReadKey(); // Aguardando o pressionamento de uma tecla.
        }
    }
}
