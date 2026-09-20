namespace CSharpAT09;

public class Program
{
    public static void Main(string[] args)
    {
        GestorArquivo gestorArquivo = new GestorArquivo();
        bool executando = true;

        while (executando)
        {
            Console.Clear();
            Console.WriteLine("=== SISTEMA DE CONTROLE DE ESTOQUE (FINAL) ===");
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
                    
                    var produtosAtuais = gestorArquivo.LerProdutos();
                    if (produtosAtuais.Count >= 5)
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

                        Produto novoProduto = new Produto(nome, quantidade, preco);

                        // Salva diretamente no arquivo
                        gestorArquivo.SalvarProduto(novoProduto);

                        Console.WriteLine("\nProduto cadastrado e salvo com sucesso!");
                    }
                    break;

                case "2":
                    Console.Clear();
                    Console.WriteLine("=== LISTA DE PRODUTOS (ESTOQUE) ===");

                    var listaProdutos = gestorArquivo.LerProdutos();

                    if (listaProdutos.Count == 0)
                    {
                        Console.WriteLine("\nNenhum produto cadastrado.");
                    }
                    else
                    {
                        foreach (var p in listaProdutos)
                        {
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