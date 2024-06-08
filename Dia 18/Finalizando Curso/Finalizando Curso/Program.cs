using System;

class Program
{
    static void Main(string[] args)
    {
        bool continueRunning = true;

        while (continueRunning)
        {
            Console.WriteLine("Escolha uma operação matemática:");
            Console.WriteLine("1 - Adição");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("5 - Sair");
            Console.Write("Digite a sua escolha: ");
            int choice = int.Parse(Console.ReadLine());

            if (choice == 5)
            {
                continueRunning = false;
                Console.WriteLine("Saindo...");
                continue;
            }

            Console.Write("Digite o primeiro número: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            double num2 = double.Parse(Console.ReadLine());

            double result;

            switch (choice)
            {
                case 1:
                    result = Add(num1, num2);
                    Console.WriteLine($"Resultado da Adição: {result}");
                    break;
                case 2:
                    result = Subtract(num1, num2);
                    Console.WriteLine($"Resultado da Subtração: {result}");
                    break;
                case 3:
                    result = Multiply(num1, num2);
                    Console.WriteLine($"Resultado da Multiplicação: {result}");
                    break;
                case 4:
                    result = Divide(num1, num2);
                    Console.WriteLine($"Resultado da Divisão: {result}");
                    break;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }

            Console.WriteLine();
        }
    }

    static double Add(double a, double b)
    {
        return a + b;
    }

    static double Subtract(double a, double b)
    {
        return a - b;
    }

    static double Multiply(double a, double b)
    {
        return a * b;
    }

    static double Divide(double a, double b)
    {
        if (b != 0)
        {
            return a / b;
        }
        else
        {
            Console.WriteLine("Erro: Divisão por zero não é permitida.");
            return 0;
        }
    }
}
