using System; // Importa o namespace System, que contém classes fundamentais como Console para entrada/saída no console.

namespace Base // Declara um namespace chamado Base para organizar o código e evitar conflitos de nomes.
{
    class Funcao // Define uma classe chamada Funcao dentro do namespace Base.
    {
        static void Main(string[] args) // Define o método Main, que é o ponto de entrada do programa. É estático porque é chamado pelo runtime sem a necessidade de uma instância.
        {
            // Exibindo mensagem inicial
            Console.WriteLine("Estudando Funções!"); // Chama o método WriteLine da classe Console para imprimir uma mensagem no console.

            // Criando uma instância da classe Funcao
            Funcao funcao = new Funcao(); // Cria uma nova instância da classe Funcao e a armazena na variável funcao.

            // Chamando o método DadosPessoais da instância de Funcao
            funcao.DadosPessoais(); // Chama o método DadosPessoais na instância funcao.
        }

        // Método DadosPessoais que imprime as informações do usuário
        public void DadosPessoais() // Declara um método público chamado DadosPessoais, que não retorna valor (void).
        {
            // As três linhas abaixo chamam o método WriteLine da classe Console para imprimir informações no console.
            Console.WriteLine("Nome do Usuário: Daniel"); // Imprime "Nome do Usuário: Daniel" no console.
            Console.WriteLine("Idade do Usuário: 24"); // Imprime "Idade do Usuário: 24" no console.
            Console.WriteLine("Nacionalidade do Usuário: Brasileiro"); // Imprime "Nacionalidade do Usuário: Brasileiro" no console.
        }
    }
}
