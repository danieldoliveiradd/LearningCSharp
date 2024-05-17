using System;

namespace Conteudo
{
    class Program
    {
        static void Main(string[] args)
        {
            var nomeUsuario = "Daniel";
            int idade = 23;
            string genero = "Masculino";
            float altura = 1.75f; // O número é decimal? use o F no final
            bool direitos = true;

            
            Console.WriteLine(nomeUsuario);
            Console.WriteLine(idade);
            Console.WriteLine(genero);
            Console.WriteLine(altura + " de altura");
            Console.WriteLine(direitos);
        }
    }
}