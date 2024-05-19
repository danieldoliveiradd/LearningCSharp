using System;

namespace MediaAluno
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira a sua nota em Matemática ");
            int notaMatematica = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira a sua nota em Português: ");
            int notaPortugues = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira a sua nota em Geografia: ");
            int notaGeografia = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira a sua nota em Informática: ");
            int notaInformatica = int.Parse(Console.ReadLine());

            int media = (notaMatematica + notaPortugues + notaGeografia + notaInformatica) / 4;


            if (media >= 7)
            {
                Console.WriteLine("Você passou parabéns! a sua média é: " + media);
            }
            else
            {
                Console.WriteLine("Você reprovou! a sua média é: " + media);
            }

        }
    }
}