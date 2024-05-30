using System;

namespace Exercitando
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            int y = 1;
            int z = 2;

            Console.WriteLine("Soma de x, y e z: " + (x + y + z));

            int[] numeros = { 1, 2, 3, 4, 5 };

            Console.WriteLine("Primeiro número do array: " + numeros[0]);

            int soma = CalcularSoma(numeros);
            Console.WriteLine("Soma dos elementos do array: " + soma);

            int numeroParaVerificar = 7;
            bool ehPrimo = VerificarPrimo(numeroParaVerificar);
            Console.WriteLine($"O número {numeroParaVerificar} é primo? {ehPrimo}");
        }

        static int CalcularSoma(int[] array)
        {
            int soma = 0;
            foreach (int numero in array)
            {
                soma += numero;
            }
            return soma;
        }

        static bool VerificarPrimo(int numero)
        {
            if (numero <= 1) return false;
            for (int i = 2; i < numero; i++)
            {
                if (numero % i == 0) return false;
            }
            return true;
        }

        static void MinhaFuncao()
        {
            Console.WriteLine("Minha função foi chamada!");
        }
    }
}
