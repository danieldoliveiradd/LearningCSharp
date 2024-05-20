using System;

namespace CalculadoraEMediaAluno
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("1. Calcular circunferência e área de um círculo");
                Console.WriteLine("2. Calcular média das notas do aluno");
                Console.WriteLine("3. Sair");
                string escolha = Console.ReadLine();

                switch (escolha)
                {
                    case "1":
                        CalcularCircunferenciaEArea();
                        break;
                    case "2":
                        CalcularMediaAluno();
                        break;
                    case "3":
                        return;
                    default:
                        Console.WriteLine("Opção inválida, por favor tente novamente.");
                        break;
                }
            }
        }

        static void CalcularCircunferenciaEArea()
        {
            Console.WriteLine("Por favor, insira o valor do raio do círculo: ");
            double raioCirculo;
            while (!double.TryParse(Console.ReadLine(), out raioCirculo) || raioCirculo <= 0)
            {
                Console.WriteLine("Valor inválido. Por favor, insira um valor numérico positivo para o raio do círculo: ");
            }

            double pi = Math.PI;

            double circunferencia = 2 * pi * raioCirculo;
            Console.WriteLine("A circunferência do círculo é: " + circunferencia);

            double area = pi * Math.Pow(raioCirculo, 2);
            Console.WriteLine("A área do círculo é: " + area);
        }

        static void CalcularMediaAluno()
        {
            Console.WriteLine("Insira a sua nota em Matemática: ");
            int notaMatematica = ObterNotaValida();

            Console.WriteLine("Insira a sua nota em Português: ");
            int notaPortugues = ObterNotaValida();

            Console.WriteLine("Insira a sua nota em Geografia: ");
            int notaGeografia = ObterNotaValida();

            Console.WriteLine("Insira a sua nota em Informática: ");
            int notaInformatica = ObterNotaValida();

            int media = (notaMatematica + notaPortugues + notaGeografia + notaInformatica) / 4;

            if (media >= 7)
            {
                Console.WriteLine("Você passou, parabéns! A sua média é: " + media);
            }
            else
            {
                Console.WriteLine("Você reprovou! A sua média é: " + media);
            }
        }

        static int ObterNotaValida()
        {
            int nota;
            while (!int.TryParse(Console.ReadLine(), out nota) || nota < 0 || nota > 10)
            {
                Console.WriteLine("Nota inválida. Por favor, insira um valor entre 0 e 10: ");
            }
            return nota;
        }
    }
}
