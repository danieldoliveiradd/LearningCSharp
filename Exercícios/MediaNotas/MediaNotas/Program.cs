using System;

namespace MediaNotas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira a sua nota em português: ");
            int notaPortugues = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira a sua nota em matemática: ");
            int notaMatematica = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira a sua nota em geografia: ");
            int notaGeografia = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira sua nota em informática: ");
            int notaInformatica = int.Parse(Console.ReadLine());

            int media = (notaPortugues + notaMatematica + notaGeografia + notaInformatica) / 4;
            // Console.WriteLine("A sua media é: " + resultado);

            if(media >= 7)
            {
                Console.WriteLine("Parabéns, você foi aprovado! a sua média é: " + media);
            } 
            else
            {
                Console.WriteLine("Você foi reprovado! a sua média é: " + media);
            }


        }
    }
}