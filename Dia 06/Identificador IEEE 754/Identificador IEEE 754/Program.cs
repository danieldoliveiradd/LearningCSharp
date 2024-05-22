using System;
using System.Text;

namespace SimuladorOrbita
{
    class Program
    {
        class Posicao
        {
            public double x { get; set; }
            public double y { get; set; }
        }

        class Velocidade
        {
            public double x { get; set; }
            public double y { get; set; }
        }

        static void Main(string[] args)
        {
            const double universalGravitacional = 6.67430e-11;
            const double massaTerra = 5.972e24;
            const double massaSatelite = 1000;

            var posicaoSatelite = new Posicao
            {
                x = 0.0,
                y = 42164e3
            };

            var velocidadeSatelite = new Velocidade
            {
                x = 3075.0,
                y = 0.0
            };

            const double dt = 1.0;
            const double tempoTotal = 3600.0;
            double tempoAtual = 0.0;

            while (tempoAtual < tempoTotal)
            {
                double distancia = Math.Sqrt(Math.Pow(posicaoSatelite.x, 2) + Math.Pow(posicaoSatelite.y, 2));
                double forcaGravitacional = (universalGravitacional * massaTerra * massaSatelite) / Math.Pow(distancia, 2);

                double angulo = Math.Atan2(posicaoSatelite.y, posicaoSatelite.x);
                double aceleracaoSateliteX = forcaGravitacional * Math.Cos(angulo) / massaSatelite;
                double aceleracaoSateliteY = forcaGravitacional * Math.Sin(angulo) / massaSatelite;

                velocidadeSatelite.x += aceleracaoSateliteX * dt;
                velocidadeSatelite.y += aceleracaoSateliteY * dt;

                posicaoSatelite.x += velocidadeSatelite.x * dt;
                posicaoSatelite.y += velocidadeSatelite.y * dt;

                tempoAtual += dt;
            }

            Console.WriteLine("Posição final do satélite:");
            Console.WriteLine("X: " + posicaoSatelite.x.ToString("0.00") + " m");
            Console.WriteLine("Y: " + posicaoSatelite.y.ToString("0.00") + " m");

            Console.WriteLine("Representação IEEE 754 da posição final do satélite:");
            Console.WriteLine("X: " + ToIEEE754(posicaoSatelite.x));
            Console.WriteLine("Y: " + ToIEEE754(posicaoSatelite.y));
        }

        static string ToIEEE754(double num)
        {
            byte[] bytes = BitConverter.GetBytes(num);
            Array.Reverse(bytes);
            StringBuilder sb = new StringBuilder();
            foreach (byte b in bytes)
            {
                sb.Append(Convert.ToString(b, 2).PadLeft(8, '0'));
            }
            return sb.ToString();
        }
    }
}

/* O retorno: 

Posição final do satélite:

X: 11190220,06 m
Y: 43577876,67 m

Representação IEEE 754 da posição final do satélite:

X: 0100000101100101010101111111100110000001111111010101010010011000
Y: 0100000110000100110001111001000010100101011000111110011011010101

*/