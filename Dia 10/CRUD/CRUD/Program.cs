using System;
using System.Collections.Generic;

namespace SistemaDeGerenciamento
{
    class Program
    {
        static void Main(string[] args)
        {
            var gerenciador = new GerenciadorDePessoas();
            string opcao;

            do
            {
                Console.WriteLine("Selecione uma opção:");
                Console.WriteLine("1 - Adicionar Pessoa");
                Console.WriteLine("2 - Listar Pessoas");
                Console.WriteLine("3 - Atualizar Pessoa");
                Console.WriteLine("4 - Remover Pessoa");
                Console.WriteLine("5 - Sair");
                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        gerenciador.AdicionarPessoa();
                        break;
                    case "2":
                        gerenciador.ListarPessoas();
                        break;
                    case "3":
                        gerenciador.AtualizarPessoa();
                        break;
                    case "4":
                        gerenciador.RemoverPessoa();
                        break;
                }

            } while (opcao != "5");
        }
    }

    class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
    }

    class GerenciadorDePessoas
    {
        private List<Pessoa> pessoas = new List<Pessoa>();
        private int proximoId = 1;

        public void AdicionarPessoa()
        {
            var pessoa = new Pessoa();

            pessoa.Id = proximoId++;
            Console.Write("Digite o nome da pessoa: ");
            pessoa.Nome = Console.ReadLine();
            Console.Write("Digite a idade da pessoa: ");
            pessoa.Idade = int.Parse(Console.ReadLine());

            pessoas.Add(pessoa);
            Console.WriteLine("Pessoa adicionada com sucesso!");
        }

        public void ListarPessoas()
        {
            if (pessoas.Count == 0)
            {
                Console.WriteLine("Nenhuma pessoa cadastrada.");
                return;
            }

            foreach (var pessoa in pessoas)
            {
                Console.WriteLine($"ID: {pessoa.Id}, Nome: {pessoa.Nome}, Idade: {pessoa.Idade}");
            }
        }

        public void AtualizarPessoa()
        {
            Console.Write("Digite o ID da pessoa que deseja atualizar: ");
            int id = int.Parse(Console.ReadLine());

            var pessoa = pessoas.Find(p => p.Id == id);
            if (pessoa == null)
            {
                Console.WriteLine("Pessoa não encontrada.");
                return;
            }

            Console.Write("Digite o novo nome da pessoa: ");
            pessoa.Nome = Console.ReadLine();
            Console.Write("Digite a nova idade da pessoa: ");
            pessoa.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Pessoa atualizada com sucesso!");
        }

        public void RemoverPessoa()
        {
            Console.Write("Digite o ID da pessoa que deseja remover: ");
            int id = int.Parse(Console.ReadLine());

            var pessoa = pessoas.Find(p => p.Id == id);
            if (pessoa == null)
            {
                Console.WriteLine("Pessoa não encontrada.");
                return;
            }

            pessoas.Remove(pessoa);
            Console.WriteLine("Pessoa removida com sucesso!");
        }
    }
}
