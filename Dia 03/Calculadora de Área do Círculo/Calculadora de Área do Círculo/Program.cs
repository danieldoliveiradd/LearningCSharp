using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Por favor, insira o valor do raio do círculo: ");
            double raioCirculo = double.Parse(Console.ReadLine());

            double pi = Math.PI;

            double circunferencia = 2 * pi * raioCirculo;
            Console.WriteLine("A circunferência do círculo é: " + circunferencia);

            double area = pi * Math.Pow(raioCirculo, 2);
            Console.WriteLine("A área do círculo é: " + area);
        }
    }
}
