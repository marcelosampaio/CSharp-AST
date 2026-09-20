namespace CSharpAT09;

public class Program
{
    public static void Main(string[] args)
    {
        // Array com limite fixo de 5 produtos conforme o enunciado
        Produto[] estoqueArray = new Produto[5];
        int quantidadeCadastrada = 0;

        bool executando = true;

        while (executando)
        {
            Console.Clear();
            Console.WriteLine("=== SISTEMA DE CONTROLE DE ESTOQUE (MEMÓRIA) ===");
            Console.WriteLine("1. Inserir Produto");
            Console.WriteLine("2. Listar Produtos");
            Console.WriteLine("3. Sair");
            Console.Write("\nEscolha uma opção: ");

            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine("=== INSERIR NOVO PRODUTO ===");

                    // Validação do limite de 5 produtos
                    if (quantidadeCadastrada >= 5)
                    {
                        Console.WriteLine("\nLimite de produtos atingido!");
                    }
                    else
                    {
                        Console.Write("Digite o nome do produto: ");
                        string nome = Console.ReadLine();

                        Console.Write("Digite a quantidade em estoque: ");
                        int quantidade = int.Parse(Console.ReadLine());

                        Console.Write("Digite o preço unitário (ex: 4500.00): ");
                        decimal preco = decimal.Parse(Console.ReadLine());

                        // Armazena no array e incrementa o contador
                        estoqueArray[quantidadeCadastrada] = new Produto(nome, quantidade, preco);
                        quantidadeCadastrada++;

                        Console.WriteLine("\nProduto cadastrado com sucesso no array!");
                    }
                    break;

                case "2":
                    Console.Clear();
                    Console.WriteLine("=== LISTA DE PRODUTOS (ESTOQUE) ===");

                    if (quantidadeCadastrada == 0)
                    {
                        Console.WriteLine("\nNenhum produto cadastrado.");
                    }
                    else
                    {
                        for (int i = 0; i < quantidadeCadastrada; i++)
                        {
                            Produto p = estoqueArray[i];
                            Console.WriteLine($"Produto: {p.Nome} | Quantidade: {p.Quantidade} | Preço: {p.Preco:C2}");
                        }
                    }
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