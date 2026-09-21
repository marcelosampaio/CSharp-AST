using System;
using System.Collections.Generic;

namespace CSharpAT12;

public class Program
{
    public static void Main(string[] args)
    {
        GestorArquivo gestor = new GestorArquivo();
        bool executando = true;

        while (executando)
        {
            Console.Clear();
            Console.WriteLine("=== Gerenciador de Contatos Avançado ===");
            Console.WriteLine("1 - Adicionar novo contato");
            Console.WriteLine("2 - Listar contatos cadastrados");
            Console.WriteLine("3 - Sair");
            Console.Write("\nEscolha uma opção: ");

            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine("=== ADICIONAR NOVO CONTATO ===");

                    Console.Write("Nome: ");
                    string nome = Console.ReadLine();

                    Console.Write("Telefone: ");
                    string telefone = Console.ReadLine();

                    Console.Write("Email: ");
                    string email = Console.ReadLine();

                    Contato novoContato = new Contato(nome, telefone, email);
                    gestor.SalvarContato(novoContato);

                    Console.WriteLine("\nContato cadastrado com sucesso!");
                    break;

                case "2":
                    Console.Clear();
                    Console.WriteLine("=== LISTAR CONTATOS ===");

                    List<Contato> contatos = gestor.LerContatos();

                    if (contatos.Count == 0)
                    {
                        Console.WriteLine("\nNenhum contato cadastrado.");
                    }
                    else
                    {
                        Console.WriteLine("Escolha o formato de exibição:");
                        Console.WriteLine("1 - Markdown");
                        Console.WriteLine("2 - Tabela");
                        Console.WriteLine("3 - Texto Puro");
                        Console.Write("\nOpção de formato: ");

                        string formatoOpcao = Console.ReadLine();
                        Console.WriteLine();

                        ContatoFormatter formatter = formatoOpcao switch
                        {
                            "1" => new MarkdownFormatter(),
                            "2" => new TabelaFormatter(),
                            "3" => new RawTextFormatter(),
                            _ => new RawTextFormatter()
                        };

                        formatter.ExibirContatos(contatos);
                    }
                    break;

                case "3":
                    executando = false;
                    Console.WriteLine("\nEncerrando programa...");
                    break;

                default:
                    Console.WriteLine("\nOpção inválida! Tente novamente.");
                    break;
            }

            if (executando)
            {
                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey();
            }
        }
    }
}