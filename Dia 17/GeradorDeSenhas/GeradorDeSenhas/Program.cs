using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.WriteLine("Bem-vindo ao Gerador de Senhas!");
        Console.Write("Digite o comprimento desejado da senha: ");
        int comprimento = int.Parse(Console.ReadLine());

        Console.Write("Incluir letras maiúsculas? (s/n): ");
        bool incluirMaiusculas = Console.ReadLine().ToLower() == "s";

        Console.Write("Incluir letras minúsculas? (s/n): ");
        bool incluirMinusculas = Console.ReadLine().ToLower() == "s";

        Console.Write("Incluir números? (s/n): ");
        bool incluirNumeros = Console.ReadLine().ToLower() == "s";

        Console.Write("Incluir caracteres especiais? (s/n): ");
        bool incluirEspeciais = Console.ReadLine().ToLower() == "s";

        string letrasMaiusculas = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        string letrasMinusculas = "abcdefghijklmnopqrstuvwxyz";
        string numeros = "0123456789";
        string caracteresEspeciais = "!@#$%^&*()";

        StringBuilder caracteresDisponiveis = new StringBuilder();
        if (incluirMaiusculas) caracteresDisponiveis.Append(letrasMaiusculas);
        if (incluirMinusculas) caracteresDisponiveis.Append(letrasMinusculas);
        if (incluirNumeros) caracteresDisponiveis.Append(numeros);
        if (incluirEspeciais) caracteresDisponiveis.Append(caracteresEspeciais);

        if (caracteresDisponiveis.Length == 0)
        {
            Console.WriteLine("Você deve selecionar pelo menos um tipo de caractere.");
            return;
        }
        string senha = GerarSenha(comprimento, caracteresDisponiveis.ToString());
        Console.WriteLine($"Senha gerada: {senha}");
    }

    static string GerarSenha(int comprimento, string caracteresDisponiveis)
    {
        StringBuilder senha = new StringBuilder();
        Random random = new Random();

        for (int i = 0; i < comprimento; i++)
        {
            int index = random.Next(caracteresDisponiveis.Length);
            senha.Append(caracteresDisponiveis[index]);
        }

        return senha.ToString();
    }
}
