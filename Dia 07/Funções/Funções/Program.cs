using System;
using System.IO;

namespace Funcoes
{
    class Program
    {
        static void Main(string[] args)
        {
            string caminho = @"C:\caminho\para\diretorio";
            string nomeArquivo = "arquivo.txt";

            try
            {
                string conteudo = ObterTexto(caminho, nomeArquivo);
                Console.WriteLine(conteudo);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }
        }

        public int Adicionar(int a, int b)
        {
            return a + b;
        }

        private static string ObterTexto(string caminho, string nomeArquivo)
        {
            string caminhoCompleto = AdicionarSeparadorDeCaminho(caminho) + nomeArquivo;

            if (!File.Exists(caminhoCompleto))
            {
                throw new FileNotFoundException("O arquivo não foi encontrado.", caminhoCompleto);
            }

            using (var leitor = File.OpenText(caminhoCompleto))
            {
                var texto = leitor.ReadToEnd();
                return texto;
            }

            string AdicionarSeparadorDeCaminho(string caminhoArquivo)
            {
                return caminhoArquivo.EndsWith(@"\") ? caminhoArquivo : caminhoArquivo + @"\";
            }
        }
    }
}
