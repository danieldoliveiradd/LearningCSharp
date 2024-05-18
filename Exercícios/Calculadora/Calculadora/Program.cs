using System;

namespace Calculadora
{
    class Program
    {
       static void Main(string[] args)
        {
            Console.WriteLine("Insira um número: ");
            int primeiroNumero = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira outro número: ");
            int segundoNumero = int.Parse(Console.ReadLine());

            int resultado = primeiroNumero + segundoNumero;

            Console.WriteLine("O resultado é: " + resultado);
        }
    }
}