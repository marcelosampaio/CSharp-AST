namespace CSharpAT09;

public class Program
{
    public static void Main(string[] args)
    {
        bool executando = true;

        while (executando)
        {
            Console.Clear();
            Console.WriteLine("=== SISTEMA DE CONTROLE DE ESTOQUE ===");
            Console.WriteLine("1. Inserir Produto");
            Console.WriteLine("2. Listar Produtos");
            Console.WriteLine("3. Sair");
            Console.Write("\nEscolha uma opção: ");

            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Console.WriteLine("\n[Funcionalidade de Inserção será implementada na Fase 2]");
                    break;
                case "2":
                    Console.WriteLine("\n[Funcionalidade de Listagem será implementada na Fase 2]");
                    break;
                case "3":
                    executando = false;
                    Console.WriteLine("\nEncerrando o sistema...");
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