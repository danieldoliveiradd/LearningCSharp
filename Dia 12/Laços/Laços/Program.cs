using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Laço for:");
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i);
        }

        List<string> frutas = new List<string> { "Maçã", "Banana", "Laranja", "Manga" };
        Console.WriteLine("\nLaço foreach:");
        foreach (string fruta in frutas)
        {
            Console.WriteLine(fruta);
        }

        int soma = 0;
        int contador = 1;
        Console.WriteLine("\nLaço while:");
        while (soma < 100)
        {
            soma += contador;
            Console.WriteLine($"Contador: {contador}, Soma: {soma}");
            contador++;
        }

        Random random = new Random();
        int numeroAleatorio;
        Console.WriteLine("\nLaço do-while:");
        do
        {
            numeroAleatorio = random.Next(1, 11);
            Console.WriteLine($"Número aleatório gerado: {numeroAleatorio}");
        } while (numeroAleatorio >= 5);

        Console.WriteLine("\nFim do programa.");
    }
}
