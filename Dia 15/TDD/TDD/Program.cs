using System;
using System.Collections.Generic;

namespace GerenciadorDeTarefas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> tarefas = new List<string>();

            while (true)
            {
                Console.WriteLine("Olá! Para adicionar uma tarefa, basta digitar 1.");
                Console.WriteLine("Para visualizar as tarefas, basta digitar 2.");
                Console.WriteLine("Para editar uma tarefa, basta digitar 3.");
                Console.WriteLine("Para deletar uma tarefa, basta digitar 4.");
                Console.WriteLine("Para sair, basta digitar 5.");
                Console.Write("\nEscolha uma opção: ");

                int opcaoUsuario = int.Parse(Console.ReadLine());
                Console.WriteLine();

                switch (opcaoUsuario)
                {
                    case 1:
                        Console.Write("Insira o nome da tarefa: ");
                        string adicionandoTarefa = Console.ReadLine();
                        tarefas.Add(adicionandoTarefa);
                        Console.WriteLine($"\nA tarefa '{adicionandoTarefa}' foi adicionada com sucesso.\n");
                        break;
                    case 2:
                        Console.WriteLine("Tarefas:\n");
                        foreach (var tarefa in tarefas)
                        {
                            Console.WriteLine(tarefa);
                        }
                        Console.WriteLine();
                        break;
                    case 5:
                        return;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.\n");
                        break;
                }
            }
        }
    }
}
