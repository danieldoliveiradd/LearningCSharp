using System;

namespace BestSongsLinkinParkin
{
    class Program
    {
        static void Main(string[] args)
        {
            ListBestSongs();
            Console.WriteLine();
            NumerosArray();
        }

        static void ListBestSongs()
        {
            string[] songsLinkinPark =
            {
                "One More Light",
                "Numb",
                "Crawling",
                "What I've Done",
                "Leave Out All The Rest",
                "Faint",
                "Breaking The Habit"
            };

            Console.WriteLine("Melhores músicas do Linkin Park:");
            Console.WriteLine($"Total de músicas: {songsLinkinPark.Length}\n");

            foreach (string song in songsLinkinPark)
            {
                Console.WriteLine(song);
            }
        }

        static void NumerosArray()
        {
            int[] meusNumeros =
            {
                1,
                2,
                3,
                4,
                5,
                6,
                7
            };

            Console.WriteLine("\nNúmeros no array:");
            Console.WriteLine($"Total de números: {meusNumeros.Length}\n");

            foreach (int numero in meusNumeros)
            {
                Console.WriteLine(numero);
            }
        }
    }
}
