using System;

namespace EstudandoFuncoes
{
    class Program
    {
        static void Main(string[] args)
        {
            int primeiraSoma = RetornandoSomas(2, 4, 6);
            int segundaSoma = RetornandoSomas(3, 6, 9);
            int terceiraSoma = RetornandoSomas(4, 8, 12);
            Console.WriteLine($"Os resultados são: {primeiraSoma} + {segundaSoma} + {terceiraSoma}");

            Console.WriteLine("Um array de carros:");
            TrabalhandoComArray();
        }

        static int RetornandoSomas(int x, int y, int z)
        {
            int soma = x + y + z;
            return soma;
        }

        static void TrabalhandoComArray()
        {
            string[] carros = new string[5] 
            { 
                "Fiat Argo", 
                "Fiat Pulse", 
                "Fiat Fastback", 
                "Fiat Punto", 
                "Fiat Uno" 
            };

            Console.WriteLine(carros[1]);

        }
    }
}