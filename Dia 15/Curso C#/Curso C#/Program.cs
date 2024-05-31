using System;

namespace FinalizandoCurso
{
    class Program
    {
        static void Main(string[] args)
        {
            string cor = Console.ReadLine();

            switch (cor)
            {
                case "Vermelho": 
                        Console.WriteLine("Sua cor favorita é: vermelho");
                    break;
                case "Amarelo":
                    Console.WriteLine("Sua cor favorita é: amarelo");
                    break;
                default:
                    Console.WriteLine("Esta cor não existe");
                    break;
            }
        }
    }
}