using System;

namespace ExercicioFuncaoII
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Estas são as melhores bandas selecionadas: \n");
            ListaMelhoresBandas();
            Console.WriteLine("");
            Console.WriteLine("Qual dessas bandas é a sua favorita?");
            string bandaFavorita = Console.ReadLine();

            if (bandaFavorita.Equals("Linkin Park", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Essa também é a minha banda favorita!");
            }
            else if (bandaFavorita.Equals("Metallica", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Essa é a minha segunda banda favorita.");
            }
            else
            {
                Console.WriteLine($"Interessante, eu também gosto de {bandaFavorita}, mas não é a minha favorita!");
            }
        }

        static void ListaMelhoresBandas()
        {
            Bandas("Metallica", "One");
            Bandas("Nirvana", "Smells Like Teen Spirit");
            Bandas("Led Zeppelin", "Stairway to Heaven");
            Bandas("AC/DC", "Back in Black");
            Bandas("The Rolling Stones", "Paint It Black");
            Bandas("Pink Floyd", "Comfortably Numb");
            Bandas("Queen", "Bohemian Rhapsody");
            Bandas("Guns N' Roses", "Sweet Child o' Mine");
            Bandas("The Beatles", "Come Together");
            Bandas("Red Hot Chili Peppers", "Californication");
            Bandas("Linkin Park", "Crawling");
        }

        static void Bandas(string banda, string musica)
        {
            Console.WriteLine($"Nome da banda: {banda}, música mais conhecida: {musica}");
        }
    }
}
